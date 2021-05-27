using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOTHI_HIENCLUBVN;
using ZedGraph;

namespace MotorControl6h39
{
    public partial class MotorControl : Form
    {
        private uint k = 0;
        ControlSignals control = new ControlSignals();
        GraphPane myPane = new GraphPane(); // Khai báo sửa dụng Graph loại GraphPane;
        //Create a new Serial Port object
        SerialPort P = new System.IO.Ports.SerialPort();
        //Declare a buffer for storing data
        string InputData = String.Empty;

        //load of control
        // khi khởi động sẽ được chạy
       
        PointPairList listPointsOne = new PointPairList();
        LineItem myCurveOne;
     
        //declare an event inside a class
        delegate void SetTextCallback(string text);

        private void MotorControl_Load(object sender, EventArgs e)
        {
          
            cbCom.SelectedIndex = 0; // chọn COM được tìm thấy đầu tiên
            cbRate.SelectedIndex = 3; // 9600
            cbBits.SelectedIndex = 2; // 8
            cbParity.SelectedIndex = 0; // None
            cbBit.SelectedIndex = 0; // None
            btdisc.Enabled = false;
            P.Close();
            //myPane.XAxis.Scale.MinorStep = 1;  // Đơn vị chia nhỏ nhất 1
            //myPane.XAxis.Scale.MajorStep = 5; // Đơn vị chia lớn 5
            ////trục y
            //myPane.YAxis.Scale.Min = 0;
            //myPane.YAxis.Scale.Max = 10;
            // set your pane
            myPane = zedGraphControl1.GraphPane;
            // set a title
            myPane.Title.Text = "Điều khiển động cơ";
            // set X and Y axis titles
            myPane.XAxis.Title.Text = "Thời gian";
            myPane.YAxis.Title.Text = "Speed(rpm)";
            zedGraphControl1.AxisChange();
            timer1.Interval = 10;

            // Khởi động timer về vị trí ban đầu 
            tickStart = Environment.TickCount;
            //enable button
            btpositive.Checked = true;
            kp.Text = "0";
            ki.Text = "0";
            kd.Text = "0";
            btsendcontrol.Enabled = false;
            txtsetposition.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //draw(5, 20);
            draw(Int32.Parse(txtsp.Text));
        }

        public MotorControl()
        {
                InitializeComponent();
                //ports variable to store all the available COM ports in Device List
                string[] ports = System.IO.Ports.SerialPort.GetPortNames();
                /* Thêm toàn bộ các COM đã tìm được vào combox cbCom
                 * Sử dụng AddRange thay vì dùng foreach
                */
                cbCom.Items.AddRange(ports);
                P.ReadTimeout = 1000;
                P.DataReceived += new SerialDataReceivedEventHandler(DataReceive);

                // Cài đặt cho BaudRate
                string[] BaudRate =
                {
                    "1200", "2400", "4800", "9600", "19200",
                    "38400", "57600", "115200"
                };
                cbRate.Items.AddRange(BaudRate);
                // Cài đặt cho DataBits
                string[] Databits = {"6", "7", "8"};
                cbBits.Items.AddRange(Databits);
                //Cho Parity
                string[] Parity = {"None", "Odd", "Even"};
                cbParity.Items.AddRange(Parity);
                //Cho Stop bit
                string[] stopbit = {"1", "1.5", "2"};
                cbBit.Items.AddRange(stopbit);
                /* Mấy cái này khá đơn giản, bạn đừng hỏi vì sao. cứ COPY paste
                cho nhanh. :D */
            }

            // Hàm này được sự kiện nhận dử liệu gọi đến. Mục đích để hiển thị thôi
            private void DataReceive(object obj, SerialDataReceivedEventArgs e)
            {
                InputData = P.ReadExisting();
                if (InputData != String.Empty)
                {
                    /* txtIn.Text = InputData; // Ko dùng đc như thế này vì khác
                    threads. */
                    SetText(InputData); /* Chính vì vậy phải sử dụng ủy quyền tại
                đây.Gọi delegate đã khai báo trước đó. */
                }
            }

            // Hàm của em nó là ở đây. Đừng hỏi vì sao lại thế.
            private void SetText(string text)
            {

                if (this.txtkq.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText); /* khởi tạo
                1 delegate mới gọi đến SetText */
                    this.Invoke(d, new object[] {text});
                }
                else
                {
                    if (text == "*")
                    {
                        Control frm = new Control();
                        //call a method in class Dothi to handle the string
                        COMhandler(this.txtkq.Text);
                        this.txtkq.Text = "";
                    }
                    else
                    {
                        this.txtkq.Text += text;
                    }

                }
            }
            // Toàn bộ cái này bạn nên COPY, nó cũng làm tôi đau đầu. :D

            private void cbCom_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (P.IsOpen)
                {
                    // Nếu đang mở Port thì phải đóng lại. Vì không thể đang chạy mà thay đổi Port được
                    P.Close();
                }
                P.PortName = cbCom.SelectedItem.ToString(); // Assign PortName by selected COM port!
            P.Open();
        }

        private void cbRate_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (P.IsOpen)
                {
                    P.Close();
                }
                P.BaudRate = Convert.ToInt32(cbRate.Text);
                P.Open();
            }

            private void cbBits_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (P.IsOpen)
                {
                    P.Close();
                }
                P.DataBits = Convert.ToInt32(cbBits.Text);
                P.Open();
            }

            private void cbParity_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (P.IsOpen)
                {
                    P.Close();
                }
                // Với thằng Parity hơn lằng nhằng. Nhưng cũng OK thôi. ^_^
                switch (cbParity.SelectedItem.ToString())
                {
                    case "Odd":
                        P.Parity = Parity.Odd;
                        break;
                    case "None":
                        P.Parity = Parity.None;
                        break;
                    case "Even":
                        P.Parity = Parity.Even;
                        break;
                }
                P.Open();
            }

            private void cbBit_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (P.IsOpen)
                {
                    P.Close();
                }
                switch (cbBit.SelectedItem.ToString())
                {
                    case "1":
                        P.StopBits = StopBits.One;
                        break;
                    case "1.5":
                        P.StopBits = StopBits.OnePointFive;
                        break;
                    case "2":
                        P.StopBits = StopBits.Two;
                        break;
                }
                P.Open();
            }

            private void btconnect_Click(object sender, EventArgs e)
            {

                P.Open();
                //User cannot click in the btKetnoi button anymore

                btconnect.Enabled = false;
                //User now can click in the btdisc button
                btdisc.Enabled = true;
                // Hiện thị Status
            }

            private void btdisc_Click(object sender, EventArgs e)
            {
                P.Close();
                btconnect.Enabled = true;
                btdisc.Enabled = false;
            }

            private void btexit_Click(object sender, EventArgs e)
            {
                DialogResult kq = MessageBox.Show("Do you want to exit?",
                    "mfrc522", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    MessageBox.Show("Thanks!", "mfrc522");
                    this.Close();
                }
            }

            private void btclear_Click(object sender, EventArgs e)
            {
                txtkq.Clear();
            }

            private void btsend_Click(object sender, EventArgs e)
            {
                if (P.IsOpen)
                {
                    P.Write(txtsend.Text);
                }
                else
                    MessageBox.Show("COM isn't connected", "mfrc522",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            public void sendkit(string sdata)
            {
                if (P.IsOpen)
                {
                    P.Write(sdata);
                }
                else
                    MessageBox.Show("COM isn't connected", "mfrc522",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        //CONTROL TAB

        double Kp, Ki, Kd, POS, SP;
        private int i, j;
        bool checkki = true, checkkp = true, checkkd = true;
        //Checking the number requirement and show message
        private string speedtxt = "", postxt = "";
        private bool spcheck,pocheck;
 

        //Receive the feedback data from the KIT. Xu li va hien thi. Dong thoi dung de ve do thi
        public void COMhandler(string data)
        {
            try
            {
                double fbspeed, fbposition;
                bool checkfbspeed, checkfbposition;
                checkfbspeed = Double.TryParse(data.Substring(1, 5), out fbspeed);
                checkfbposition = Double.TryParse(data.Substring(6, 5), out fbposition);
                if (checkfbspeed)
                {
                    //Hien thi len sptext. Dong thoi ve do thi
                    txtsp.Text = Convert.ToString(fbspeed);
                    draw(fbspeed);
                }
                if (checkfbposition)
                {
                    //Hien thi len sptext. Dong thoi ve do thi
                    txtpo.Text = Convert.ToString(fbposition);
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                //throw;
            }
        }


        // Khai báo 1 biến dùng cho timer, chạy cột thời gian tính bằng ms
        int tickStart = 0;
      

        // Để tiện cho việc sử dụng chúng ta sẽ xây dựng 1 hàm draw phục vụ cho việc vẽ đồ thị
        public void draw(double ypoint) // Ở ví dụ này chúng ta có 2 đường
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            // Time được tính bằng ms
            double time = (Environment.TickCount - tickStart) / 1000.0;
            //add point to Zed Graph
            listPointsOne.Add(time, ypoint);
            myCurveOne = myPane.AddCurve(null, listPointsOne, Color.Red, SymbolType.Default);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

      
        int check = 0; // để cho khi nhấn Start là sẽ bắt đầu từ điểm 0

        private void ki_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Ki = Convert.ToDouble(ki.Text);
                if (Ki >= 0 && Kp < 1000)
                {
                    Ki = Math.Round(Ki, 3);
                    checkki = true;
                }
                else
                {
                checkki = false;
                }
            }
            catch (Exception exception)
            {
                checkki = false;
                //Console.WriteLine(exception);
                //throw;

            }
        }

        private void kp_TextChanged(object sender, EventArgs e)
        {

            try
            {
                Kp = Convert.ToDouble(kp.Text);
                if (Kp >= 0 && Kp < 1000)
                {
                        Kp = Math.Round(Kp, 3);
                    checkkp = true;
                }
                else
                {
                    checkkp = false;
                }
            }
            catch (Exception exception)
            {
                checkkp = false;
                //Console.WriteLine(exception);
                //throw;

            }
        }

        private void kd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Kd = Convert.ToDouble(kd.Text);
                if (Kd >= 0 && Kd < 1000)
                {
                    Kd = Math.Round(Kd, 3);
                    checkkd = true;
                }
                else
                {
                    checkkd = false;
                }

            }
            catch (Exception exception)
            {
                checkkd = false;
                //Console.WriteLine(exception);
                //throw;
            }
        }

        private void btstartgraph_Click(object sender, EventArgs e)
        {
  
            {
                if (btstartgraph.Text == "START")
                {
                    timer1.Enabled = true;
                    btstartgraph.Text = "STOP";
                    timer1.Start();
                    timer1.Enabled = true;
                }
                else
                {
                    timer1.Enabled = false;
                    btstartgraph.Text = "START";
                    k = 0;
                    timer1.Enabled = false;

                }
            }
        }
        private void btcleargraph_Click(object sender, EventArgs e)
        {

        }

        public string sendstring;

        private void txtsp_TextChanged(object sender, EventArgs e)
        {

        }
        private void timercheck_Tick(object sender, EventArgs e)
        {
            if (checkki && checkkp && checkkd && (spcheck || pocheck))
            {
                btsendcontrol.Enabled = true;
            }
            else
            {
                btsendcontrol.Enabled = false;
            }
        }

        private void txtsetspeed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SP = Convert.ToDouble(txtsetspeed.Text);
                if (SP >= 0 && SP <= 400)
                {
                    SP = Math.Round(SP, 3);
                    spcheck = true;
                }
                else
                {
                    spcheck = false;
                }
            }
            catch (Exception exception)
            {
                spcheck = false;
                //Console.WriteLine(exception);
                //throw;

            }
        }

        private void txtsetposition_TextChanged(object sender, EventArgs e)
        {
            try
            {
                POS = Convert.ToDouble(txtsetposition.Text);
                if (POS >= 0 && SP <= 360)
                {
                    POS = Math.Round(POS, 3);
                    pocheck = true;
                }
                else
                {
                    pocheck = false;
                }
            }
            catch (Exception exception)
            {
                pocheck = false;
                //Console.WriteLine(exception);
                //throw;

            }
        }
        private void btsendcontrol_Click(object sender, EventArgs e)
        {
            //Xu li tin hieu trong Text Box. Kp Ki Kd
   
            bool dir=true;
            if (checkspeed.CheckState == CheckState.Checked)
            {
                //Speed Control. xu li o text speed
                
               if (btnegative.Checked)
                {
                    //speed control with - direction
                    dir = false;
                }
                control.sendspeedcontrol(dir, Kp, Ki, Kd, SP, out sendstring);
            }
            else if (checkpos.CheckState == CheckState.Checked)
            {
                //Position Control. Format: #KpKiKd@setposition
                control.sendpositioncontrol(Kp, Ki, Kd, POS,out sendstring);
            }
            sendkit(sendstring);
        }
        private void btstop_Click(object sender, EventArgs e)
        {
            //Send command to stop the motor
            sendkit("#");
        }


        private void checkspeed_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkspeed.CheckState == CheckState.Checked)
            {
                checkpos.CheckState = CheckState.Unchecked;
                //Position textbox disable
                txtsetposition.Enabled = false;
                txtsetspeed.Enabled = true;
                btpositive.Enabled = true;
                btnegative.Enabled = true;
            }
        }

        private void checkpos_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkpos.CheckState == CheckState.Checked)
            {
                checkspeed.CheckState = CheckState.Unchecked;
                txtsetspeed.Enabled = false;
                txtsetposition.Enabled = true;
                btpositive.Enabled = false;
                btnegative.Enabled = false;
            }
        }

        private void btpositive_CheckedChanged(object sender, EventArgs e)
        {
            if (btpositive.Checked)
                btnegative.Checked = false;
        }

        private void btnegative_CheckedChanged(object sender, EventArgs e)
        {
            if (btnegative.Checked)
                btpositive.Checked = false;
        }

    }
    }

    

