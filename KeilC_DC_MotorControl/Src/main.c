#include "stm32f4xx_hal.h"

TIM_HandleTypeDef htim2; // thoi gian lay mau
TIM_HandleTypeDef htim3;
TIM_HandleTypeDef htim4; // pwm

UART_HandleTypeDef huart3;
DMA_HandleTypeDef hdma_usart3_rx;

void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_TIM2_Init(void);
static void MX_TIM3_Init(void);
static void MX_TIM4_Init(void);
static void MX_USART3_UART_Init(void);
static void MX_DMA_Init(void);

void HAL_TIM_MspPostInit(TIM_HandleTypeDef *htim);
float trap_mf(float x, float L, float C1, float C2, float R);
float speed(void);
float position(void);
int32_t A, B;
float count, count1, dir = 0;
float setpoint, measurep, KP, KI, KD, oo, measures, uu, VANTOC, VITRI;
float KP, KI, KD, Ts = 0.015, ek2, ek1, ek, uk, uk1, umax = 20000, umin = -20000, u, setpoint,
                  measure, tam3;
uint8_t mystr[29], data[29], i, a, b, sdata[16];
uint16_t tam1, tam2;
int main(void) {
    HAL_Init();
    SystemClock_Config();
    MX_GPIO_Init();
    MX_TIM2_Init();
    MX_TIM3_Init();
    MX_TIM4_Init();
    MX_USART3_UART_Init();
    HAL_TIM_Base_Start_IT(&htim2);
    HAL_TIM_PWM_Start(&htim4, TIM_CHANNEL_4);
    HAL_UART_Receive_IT(&huart3, mystr, 29);
    sdata[15] = '\r';
    while (1) {
        for (i = 0; i < 29; i++) {
            data[i] = mystr[i] - 48;
        }
        a = data[22] + 48;
        b = data[0] + 48;
        //	Xu ly du lieu
        if ((a == 'V') | (a == 'X')) {

            KP =
                (float)(data[2] * 10000 + data[3] * 1000 + data[4] * 100 + data[6] * 10 + data[7]) /
                100;
            KI = (float)(data[9] * 10000 + data[10] * 1000 + data[11] * 100 + data[13] * 10 +
                         data[14]) /
                 100;
            KD = (float)(data[16] * 10000 + data[17] * 1000 + data[18] * 100 + data[20] * 10 +
                         data[21]) /
                 100;
            setpoint = (float)(data[23] * 10000 + data[24] * 1000 + data[25] * 100 + data[27] * 10 +
                               data[28]) /
                       100;
        } else {
            KP = 0;
            KI = 0;
            KD = 0;
            setpoint = 0;
            u = 0;
            oo = 0;
            HAL_GPIO_WritePin(GPIOD, GPIO_PIN_13, GPIO_PIN_RESET);
            __HAL_TIM_SET_COMPARE(&htim4, TIM_CHANNEL_4, 0);
        }
        if (a == 'X') {
            KD = KD / 100;
            // PID_position_controll
            HAL_Delay(15);
            // float
            // KP=5,KI=3,KD=0.03,Ts=0.015,ek2,ek1,ek,uk,uk1,umax=20000,umin=-20000,u,setpoint=180,measure;
            measurep = (float)((int)count % 3540);
            oo = measurep * 360 / 3540;
            u = speed();
            ek2 = ek1;
            ek1 = ek;
            ek = setpoint * 3540 / 360 - measurep;
            uk1 = uk;
            uk =
                uk1 + KP * (ek - ek1) + KI * Ts * (ek + ek1) / 2 + (KD) * (ek - 2 * ek1 + ek2) / Ts;
            if (uk > umax)
                uk = umax;
            if (uk < umin)
                uk = umin;
            if (uk < 0) {
                HAL_GPIO_WritePin(GPIOD, GPIO_PIN_13, GPIO_PIN_SET);
                __HAL_TIM_SET_COMPARE(&htim4, TIM_CHANNEL_4, 20000 + uk);
            } else {
                HAL_GPIO_WritePin(GPIOD, GPIO_PIN_13, GPIO_PIN_RESET);
                __HAL_TIM_SET_COMPARE(&htim4, TIM_CHANNEL_4, uk);
            }
        }
        if (a == 'V') {
            if (b == '!')
                uu = -setpoint;
            if (b == '@')
                uu = setpoint;
            // PID_speed_controll
            // float
            // KP=50,KI=500,KD=15,Ts=0.015,ek2,ek1,ek,uk,uk1,umax=20000,umin=-20000,u,setpoint=200,measure;
            HAL_Delay(15);
            measurep = (float)((int)count % 3540);
            oo = measurep * 360 / 3540;
            u = speed();
            measures = u;
            ek2 = ek1;
            ek1 = ek;
            ek = uu - measures;
            uk1 = uk;
            uk = uk1 + KP * (ek - ek1) + KI * Ts * (ek + ek1) / 2 + KD * (ek - 2 * ek1 + ek2) / Ts;
            if (uk > umax)
                uk = umax;
            if (uk < umin)
                uk = umin;
            if (uk < 0) {
                HAL_GPIO_WritePin(GPIOD, GPIO_PIN_13, GPIO_PIN_SET);
                __HAL_TIM_SET_COMPARE(&htim4, TIM_CHANNEL_4, 20000 + uk);
            } else {
                HAL_GPIO_WritePin(GPIOD, GPIO_PIN_13, GPIO_PIN_RESET);
                __HAL_TIM_SET_COMPARE(&htim4, TIM_CHANNEL_4, uk);
            }
        }
        // guidulieu		(+/-)xxx.xx*xxx.xx
        if (u >= 0)
            sdata[0] = '+';
        if (u < 0)
            sdata[0] = '-';
        tam1 = (int)(u * 100);
        if (u < 0)
            tam1 = -tam1;
        tam2 = (int)(oo * 100);
        sdata[1] = tam1 / 10000 + 48;
        sdata[2] = (tam1 % 10000) / 1000 + 48; // 12345
        sdata[3] = (tam1 % 1000) / 100 + 48;
        sdata[4] = '.';
        sdata[5] = (tam1 % 100) / 10 + 48;
        sdata[6] = (tam1 % 10) + 48;
        sdata[7] = '*';
        sdata[8] = tam2 / 10000 + 48;
        sdata[9] = (tam2 % 10000) / 1000 + 48; // 12345
        sdata[10] = (tam2 % 1000) / 100 + 48;
        sdata[11] = '.';
        sdata[12] = (tam2 % 100) / 10 + 48;
        sdata[13] = (tam2 % 10) + 48;
        sdata[14] = '$';
        HAL_UART_Transmit_IT(&huart3, sdata, 16);
    }
}
void HAL_UART_RxCpltCallback(UART_HandleTypeDef *huart) {
    if (huart->Instance == huart3.Instance) {
        HAL_UART_Receive_DMA(&huart3, mystr, 29);
    }
}
void HAL_TIM_PeriodElapsedCallback(TIM_HandleTypeDef *htim) {
    if (htim->Instance == htim2.Instance) {
    }
}
// toc do encorder
float speed(void) {
    float speed0;
    speed0 = (count - count1) * 60 / (0.015 * 334 * 9);
    count1 = count;
    return speed0;
}

// doc encorder
void HAL_GPIO_EXTI_Callback(uint16_t GPIO_Pin) {
    A = HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_3);
    B = HAL_GPIO_ReadPin(GPIOA, GPIO_PIN_4);
    if (A == 1) {
        if (B == 1)
            dir = -1;
        else
            dir = 1;
        count += dir;
    }
}
/** System Clock Configuration
 */
void SystemClock_Config(void) {

    RCC_OscInitTypeDef RCC_OscInitStruct;
    RCC_ClkInitTypeDef RCC_ClkInitStruct;

    __HAL_RCC_PWR_CLK_ENABLE();

    __HAL_PWR_VOLTAGESCALING_CONFIG(PWR_REGULATOR_VOLTAGE_SCALE1);

    RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
    RCC_OscInitStruct.HSEState = RCC_HSE_ON;
    RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
    RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
    RCC_OscInitStruct.PLL.PLLM = 8;
    RCC_OscInitStruct.PLL.PLLN = 336;
    RCC_OscInitStruct.PLL.PLLP = RCC_PLLP_DIV2;
    RCC_OscInitStruct.PLL.PLLQ = 4;
    HAL_RCC_OscConfig(&RCC_OscInitStruct);

    RCC_ClkInitStruct.ClockType =
        RCC_CLOCKTYPE_HCLK | RCC_CLOCKTYPE_SYSCLK | RCC_CLOCKTYPE_PCLK1 | RCC_CLOCKTYPE_PCLK2;
    RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
    RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
    RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV4;
    RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV4;
    HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_5);

    HAL_SYSTICK_Config(HAL_RCC_GetHCLKFreq() / 1000);

    HAL_SYSTICK_CLKSourceConfig(SYSTICK_CLKSOURCE_HCLK);

    /* SysTick_IRQn interrupt configuration */
    HAL_NVIC_SetPriority(SysTick_IRQn, 0, 0);
}

/* TIM2 init function */
void MX_TIM2_Init(void) {

    TIM_ClockConfigTypeDef sClockSourceConfig;
    TIM_MasterConfigTypeDef sMasterConfig;

    htim2.Instance = TIM2;
    htim2.Init.Prescaler = 84; // 15ms
    htim2.Init.CounterMode = TIM_COUNTERMODE_UP;
    htim2.Init.Period = 15000;
    htim2.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
    HAL_TIM_Base_Init(&htim2);

    sClockSourceConfig.ClockSource = TIM_CLOCKSOURCE_INTERNAL;
    HAL_TIM_ConfigClockSource(&htim2, &sClockSourceConfig);

    sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
    sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
    HAL_TIMEx_MasterConfigSynchronization(&htim2, &sMasterConfig);
}

/* TIM3 init function */
void MX_TIM3_Init(void) {

    TIM_ClockConfigTypeDef sClockSourceConfig;
    TIM_MasterConfigTypeDef sMasterConfig;

    htim3.Instance = TIM3;
    htim3.Init.Prescaler = 450;
    htim3.Init.CounterMode = TIM_COUNTERMODE_UP;
    htim3.Init.Period = 7200;
    htim3.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
    HAL_TIM_Base_Init(&htim3);

    sClockSourceConfig.ClockSource = TIM_CLOCKSOURCE_INTERNAL;
    HAL_TIM_ConfigClockSource(&htim3, &sClockSourceConfig);

    sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
    sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
    HAL_TIMEx_MasterConfigSynchronization(&htim3, &sMasterConfig);
}

/* TIM4 init function */
void MX_TIM4_Init(void) {

    TIM_MasterConfigTypeDef sMasterConfig;
    TIM_OC_InitTypeDef sConfigOC;

    htim4.Instance = TIM4;
    htim4.Init.Prescaler = 84;
    htim4.Init.CounterMode = TIM_COUNTERMODE_UP;
    htim4.Init.Period = 20000;
    htim4.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
    HAL_TIM_PWM_Init(&htim4);

    sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
    sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
    HAL_TIMEx_MasterConfigSynchronization(&htim4, &sMasterConfig);

    sConfigOC.OCMode = TIM_OCMODE_PWM1;
    sConfigOC.Pulse = 0;
    sConfigOC.OCPolarity = TIM_OCPOLARITY_HIGH;
    sConfigOC.OCFastMode = TIM_OCFAST_DISABLE;
    HAL_TIM_PWM_ConfigChannel(&htim4, &sConfigOC, TIM_CHANNEL_4);

    HAL_TIM_MspPostInit(&htim4);
}

/* USART3 init function */
void MX_USART3_UART_Init(void) {

    huart3.Instance = USART3;
    huart3.Init.BaudRate = 9600;
    huart3.Init.WordLength = UART_WORDLENGTH_8B;
    huart3.Init.StopBits = UART_STOPBITS_1;
    huart3.Init.Parity = UART_PARITY_NONE;
    huart3.Init.Mode = UART_MODE_TX_RX;
    huart3.Init.HwFlowCtl = UART_HWCONTROL_NONE;
    huart3.Init.OverSampling = UART_OVERSAMPLING_16;
    HAL_UART_Init(&huart3);
}

static void MX_DMA_Init(void) {
    /* DMA controller clock enable */
    __HAL_RCC_DMA1_CLK_ENABLE();

    /* DMA interrupt init */
    /* DMA1_Stream1_IRQn interrupt configuration */
    HAL_NVIC_SetPriority(DMA1_Stream1_IRQn, 0, 0);
    HAL_NVIC_EnableIRQ(DMA1_Stream1_IRQn);
    /* DMA1_Stream5_IRQn interrupt configuration */
    HAL_NVIC_SetPriority(DMA1_Stream5_IRQn, 0, 0);
    HAL_NVIC_EnableIRQ(DMA1_Stream5_IRQn);
}

/** Configure pins as
 * Analog
 * Input
 * Output
 * EVENT_OUT
 * EXTI
 */
void MX_GPIO_Init(void) {

    GPIO_InitTypeDef GPIO_InitStruct;

    /* GPIO Ports Clock Enable */
    __HAL_RCC_GPIOH_CLK_ENABLE();
    __HAL_RCC_GPIOA_CLK_ENABLE();
    __HAL_RCC_GPIOB_CLK_ENABLE();
    __HAL_RCC_GPIOD_CLK_ENABLE();

    /*Configure GPIO pin : PA3 */
    GPIO_InitStruct.Pin = GPIO_PIN_3;
    GPIO_InitStruct.Mode = GPIO_MODE_IT_RISING;
    GPIO_InitStruct.Pull = GPIO_NOPULL;
    HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

    /*Configure GPIO pin : PA4 */
    GPIO_InitStruct.Pin = GPIO_PIN_4;
    GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
    GPIO_InitStruct.Pull = GPIO_PULLUP;
    HAL_GPIO_Init(GPIOA, &GPIO_InitStruct);

    /*Configure GPIO pin : PD13 */
    GPIO_InitStruct.Pin = GPIO_PIN_13;
    GPIO_InitStruct.Mode = GPIO_MODE_OUTPUT_PP;
    GPIO_InitStruct.Pull = GPIO_NOPULL;
    GPIO_InitStruct.Speed = GPIO_SPEED_FREQ_VERY_HIGH;
    HAL_GPIO_Init(GPIOD, &GPIO_InitStruct);

    /*Configure GPIO pin : PD14 Rx */
    GPIO_InitStruct.Pin = GPIO_PIN_14;
    GPIO_InitStruct.Mode = GPIO_MODE_INPUT;
    GPIO_InitStruct.Pull = GPIO_NOPULL;
    HAL_GPIO_Init(GPIOD, &GPIO_InitStruct);

    /*Configure GPIO pin Output Level */
    HAL_GPIO_WritePin(GPIOD, GPIO_PIN_13, GPIO_PIN_RESET);

    /* EXTI interrupt init*/
    HAL_NVIC_SetPriority(EXTI3_IRQn, 0, 0);
    HAL_NVIC_EnableIRQ(EXTI3_IRQn);
}

/* USER CODE BEGIN 4 */

/* USER CODE END 4 */

#ifdef USE_FULL_ASSERT

/**
 * @brief Reports the name of the source file and the source line number
 * where the assert_param error has occurred.
 * @param file: pointer to the source file name
 * @param line: assert_param error line source number
 * @retval None
 */
void assert_failed(uint8_t *file, uint32_t line) {
    /* USER CODE BEGIN 6 */
    /* User can add his own implementation to report the file name and line
      number, ex: printf("Wrong parameters value: file %s on line %d\r\n", file,
      line) */
    /* USER CODE END 6 */
}

#endif

/**
 * @}
 */

/**
 * @}
 */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
