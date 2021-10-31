namespace MotorControl6h39
{
    partial class MotorControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btSend = new System.Windows.Forms.Button();
            this.txtsend = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.btdisc = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.btconnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbBits = new System.Windows.Forms.ComboBox();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btrefesh = new System.Windows.Forms.Button();
            this.maintab = new System.Windows.Forms.TabPage();
            this.btcleargraph = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.sendnao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnegative = new System.Windows.Forms.RadioButton();
            this.btpositive = new System.Windows.Forms.RadioButton();
            this.checkpos = new System.Windows.Forms.CheckBox();
            this.checkspeed = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsetposition = new System.Windows.Forms.TextBox();
            this.txtsetspeed = new System.Windows.Forms.TextBox();
            this.btsendcontrol = new System.Windows.Forms.Button();
            this.btstop = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kd = new System.Windows.Forms.TextBox();
            this.ki = new System.Windows.Forms.TextBox();
            this.kp = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timercheck = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.maintab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(330, 88);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 33;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btsend_Click);
            // 
            // txtsend
            // 
            this.txtsend.Location = new System.Drawing.Point(329, 54);
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(336, 20);
            this.txtsend.TabIndex = 32;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(839, 411);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(167, 49);
            this.exit.TabIndex = 31;
            this.exit.Text = "Exit Program";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btdisc
            // 
            this.btdisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdisc.Location = new System.Drawing.Point(160, 209);
            this.btdisc.Name = "btdisc";
            this.btdisc.Size = new System.Drawing.Size(120, 39);
            this.btdisc.TabIndex = 30;
            this.btdisc.Text = "DISCONNECT";
            this.btdisc.UseVisualStyleBackColor = true;
            this.btdisc.Click += new System.EventHandler(this.btdisc_Click);
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(444, 409);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(75, 23);
            this.btclear.TabIndex = 28;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // btconnect
            // 
            this.btconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconnect.Location = new System.Drawing.Point(20, 209);
            this.btconnect.Name = "btconnect";
            this.btconnect.Size = new System.Drawing.Size(95, 39);
            this.btconnect.TabIndex = 27;
            this.btconnect.Text = "CONNECT";
            this.btconnect.UseVisualStyleBackColor = true;
            this.btconnect.Click += new System.EventHandler(this.btconnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Stopbit";
            // 
            // cbBit
            // 
            this.cbBit.FormattingEnabled = true;
            this.cbBit.Location = new System.Drawing.Point(90, 165);
            this.cbBit.Name = "cbBit";
            this.cbBit.Size = new System.Drawing.Size(121, 21);
            this.cbBit.TabIndex = 25;
            this.cbBit.SelectedIndexChanged += new System.EventHandler(this.cbBit_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "COM";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(90, 132);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 21);
            this.cbParity.TabIndex = 19;
            this.cbParity.SelectedIndexChanged += new System.EventHandler(this.cbParity_SelectedIndexChanged);
            // 
            // cbBits
            // 
            this.cbBits.FormattingEnabled = true;
            this.cbBits.Location = new System.Drawing.Point(90, 85);
            this.cbBits.Name = "cbBits";
            this.cbBits.Size = new System.Drawing.Size(121, 21);
            this.cbBits.TabIndex = 18;
            this.cbBits.SelectedIndexChanged += new System.EventHandler(this.cbBits_SelectedIndexChanged);
            // 
            // cbRate
            // 
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Location = new System.Drawing.Point(90, 58);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(121, 21);
            this.cbRate.TabIndex = 17;
            this.cbRate.SelectedIndexChanged += new System.EventHandler(this.cbRate_SelectedIndexChanged);
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(90, 18);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 21);
            this.cbCom.TabIndex = 20;
            this.cbCom.SelectedIndexChanged += new System.EventHandler(this.cbCom_SelectedIndexChanged);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(12, 411);
            this.txtkq.Multiline = true;
            this.txtkq.Name = "txtkq";
            this.txtkq.ReadOnly = true;
            this.txtkq.Size = new System.Drawing.Size(426, 55);
            this.txtkq.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.maintab);
            this.tabControl1.Location = new System.Drawing.Point(7, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(3, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 397);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btrefesh);
            this.tabPage1.Controls.Add(this.cbCom);
            this.tabPage1.Controls.Add(this.btSend);
            this.tabPage1.Controls.Add(this.txtsend);
            this.tabPage1.Controls.Add(this.cbRate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btdisc);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btconnect);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbBits);
            this.tabPage1.Controls.Add(this.cbBit);
            this.tabPage1.Controls.Add(this.cbParity);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btrefesh
            // 
            this.btrefesh.Location = new System.Drawing.Point(229, 18);
            this.btrefesh.Name = "btrefesh";
            this.btrefesh.Size = new System.Drawing.Size(112, 23);
            this.btrefesh.TabIndex = 34;
            this.btrefesh.Text = "Refesh COM";
            this.btrefesh.UseVisualStyleBackColor = true;
            this.btrefesh.Click += new System.EventHandler(this.btrefesh_Click);
            // 
            // maintab
            // 
            this.maintab.BackColor = System.Drawing.Color.Transparent;
            this.maintab.Controls.Add(this.btcleargraph);
            this.maintab.Controls.Add(this.label14);
            this.maintab.Controls.Add(this.sendnao);
            this.maintab.Controls.Add(this.groupBox2);
            this.maintab.Controls.Add(this.btnegative);
            this.maintab.Controls.Add(this.btpositive);
            this.maintab.Controls.Add(this.checkpos);
            this.maintab.Controls.Add(this.checkspeed);
            this.maintab.Controls.Add(this.label10);
            this.maintab.Controls.Add(this.label11);
            this.maintab.Controls.Add(this.txtsetposition);
            this.maintab.Controls.Add(this.txtsetspeed);
            this.maintab.Controls.Add(this.btsendcontrol);
            this.maintab.Controls.Add(this.btstop);
            this.maintab.Controls.Add(this.label8);
            this.maintab.Controls.Add(this.label7);
            this.maintab.Controls.Add(this.label9);
            this.maintab.Controls.Add(this.kd);
            this.maintab.Controls.Add(this.ki);
            this.maintab.Controls.Add(this.kp);
            this.maintab.Controls.Add(this.zedGraphControl1);
            this.maintab.Location = new System.Drawing.Point(4, 22);
            this.maintab.Name = "maintab";
            this.maintab.Padding = new System.Windows.Forms.Padding(3);
            this.maintab.Size = new System.Drawing.Size(1076, 371);
            this.maintab.TabIndex = 1;
            this.maintab.Text = "tabPage2";
            // 
            // btcleargraph
            // 
            this.btcleargraph.Location = new System.Drawing.Point(294, 10);
            this.btcleargraph.Name = "btcleargraph";
            this.btcleargraph.Size = new System.Drawing.Size(89, 45);
            this.btcleargraph.TabIndex = 26;
            this.btcleargraph.Text = "CLEAR";
            this.btcleargraph.UseVisualStyleBackColor = true;
            this.btcleargraph.Click += new System.EventHandler(this.btcleargraph_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(114, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Sent Control String";
            // 
            // sendnao
            // 
            this.sendnao.Location = new System.Drawing.Point(65, 307);
            this.sendnao.Name = "sendnao";
            this.sendnao.ReadOnly = true;
            this.sendnao.Size = new System.Drawing.Size(215, 20);
            this.sendnao.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsp);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtpo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(488, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 70);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Feedback Value";
            // 
            // txtsp
            // 
            this.txtsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsp.Location = new System.Drawing.Point(37, 36);
            this.txtsp.Multiline = true;
            this.txtsp.Name = "txtsp";
            this.txtsp.ReadOnly = true;
            this.txtsp.Size = new System.Drawing.Size(137, 28);
            this.txtsp.TabIndex = 8;
            this.txtsp.TextChanged += new System.EventHandler(this.txtsp_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "POSITION";
            // 
            // txtpo
            // 
            this.txtpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpo.Location = new System.Drawing.Point(252, 34);
            this.txtpo.Multiline = true;
            this.txtpo.Name = "txtpo";
            this.txtpo.ReadOnly = true;
            this.txtpo.Size = new System.Drawing.Size(127, 28);
            this.txtpo.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "SPEED";
            // 
            // btnegative
            // 
            this.btnegative.AutoSize = true;
            this.btnegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnegative.Location = new System.Drawing.Point(140, 131);
            this.btnegative.Name = "btnegative";
            this.btnegative.Size = new System.Drawing.Size(91, 22);
            this.btnegative.TabIndex = 41;
            this.btnegative.TabStop = true;
            this.btnegative.Text = "- direction";
            this.btnegative.UseVisualStyleBackColor = true;
            this.btnegative.CheckedChanged += new System.EventHandler(this.btnegative_CheckedChanged);
            // 
            // btpositive
            // 
            this.btpositive.AutoSize = true;
            this.btpositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpositive.Location = new System.Drawing.Point(28, 131);
            this.btpositive.Name = "btpositive";
            this.btpositive.Size = new System.Drawing.Size(95, 22);
            this.btpositive.TabIndex = 33;
            this.btpositive.TabStop = true;
            this.btpositive.Text = "+ direction";
            this.btpositive.UseVisualStyleBackColor = true;
            this.btpositive.CheckedChanged += new System.EventHandler(this.btpositive_CheckedChanged);
            // 
            // checkpos
            // 
            this.checkpos.AutoSize = true;
            this.checkpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkpos.Location = new System.Drawing.Point(13, 198);
            this.checkpos.Name = "checkpos";
            this.checkpos.Size = new System.Drawing.Size(126, 21);
            this.checkpos.TabIndex = 39;
            this.checkpos.Text = "Position Control";
            this.checkpos.UseVisualStyleBackColor = true;
            this.checkpos.CheckedChanged += new System.EventHandler(this.checkpos_CheckedChanged_1);
            // 
            // checkspeed
            // 
            this.checkspeed.AutoSize = true;
            this.checkspeed.Checked = true;
            this.checkspeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkspeed.Location = new System.Drawing.Point(13, 163);
            this.checkspeed.Name = "checkspeed";
            this.checkspeed.Size = new System.Drawing.Size(117, 21);
            this.checkspeed.TabIndex = 38;
            this.checkspeed.Text = "Speed Control";
            this.checkspeed.UseVisualStyleBackColor = true;
            this.checkspeed.CheckedChanged += new System.EventHandler(this.checkspeed_CheckedChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "degree";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(265, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "rpm";
            // 
            // txtsetposition
            // 
            this.txtsetposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsetposition.Location = new System.Drawing.Point(142, 198);
            this.txtsetposition.Name = "txtsetposition";
            this.txtsetposition.Size = new System.Drawing.Size(100, 26);
            this.txtsetposition.TabIndex = 35;
            this.txtsetposition.TextChanged += new System.EventHandler(this.txtsetposition_TextChanged);
            // 
            // txtsetspeed
            // 
            this.txtsetspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsetspeed.Location = new System.Drawing.Point(142, 164);
            this.txtsetspeed.Name = "txtsetspeed";
            this.txtsetspeed.Size = new System.Drawing.Size(100, 26);
            this.txtsetspeed.TabIndex = 34;
            this.txtsetspeed.TextChanged += new System.EventHandler(this.txtsetspeed_TextChanged);
            // 
            // btsendcontrol
            // 
            this.btsendcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsendcontrol.Location = new System.Drawing.Point(27, 237);
            this.btsendcontrol.Name = "btsendcontrol";
            this.btsendcontrol.Size = new System.Drawing.Size(90, 37);
            this.btsendcontrol.TabIndex = 32;
            this.btsendcontrol.Text = "SEND";
            this.btsendcontrol.UseVisualStyleBackColor = true;
            this.btsendcontrol.Click += new System.EventHandler(this.btsendcontrol_Click);
            // 
            // btstop
            // 
            this.btstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstop.Location = new System.Drawing.Point(170, 237);
            this.btstop.Name = "btstop";
            this.btstop.Size = new System.Drawing.Size(96, 37);
            this.btstop.TabIndex = 31;
            this.btstop.Text = "STOP";
            this.btstop.UseVisualStyleBackColor = true;
            this.btstop.Click += new System.EventHandler(this.btstop_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Kd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ki";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Kp";
            // 
            // kd
            // 
            this.kd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kd.Location = new System.Drawing.Point(53, 84);
            this.kd.Name = "kd";
            this.kd.Size = new System.Drawing.Size(100, 23);
            this.kd.TabIndex = 27;
            this.kd.TextChanged += new System.EventHandler(this.kd_TextChanged);
            // 
            // ki
            // 
            this.ki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ki.Location = new System.Drawing.Point(53, 50);
            this.ki.Name = "ki";
            this.ki.Size = new System.Drawing.Size(100, 23);
            this.ki.TabIndex = 26;
            this.ki.TextChanged += new System.EventHandler(this.ki_TextChanged);
            // 
            // kp
            // 
            this.kp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kp.Location = new System.Drawing.Point(53, 21);
            this.kp.Name = "kp";
            this.kp.Size = new System.Drawing.Size(100, 23);
            this.kp.TabIndex = 25;
            this.kp.TextChanged += new System.EventHandler(this.kp_TextChanged);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl1.Location = new System.Drawing.Point(403, 6);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(667, 284);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timercheck
            // 
            this.timercheck.Enabled = true;
            this.timercheck.Interval = 20;
            this.timercheck.Tick += new System.EventHandler(this.timercheck_Tick);
            // 
            // MotorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1095, 472);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.exit);
            this.Name = "MotorControl";
            this.Text = "Nhóm 9. PWM và Encoder";
            this.Load += new System.EventHandler(this.MotorControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.maintab.ResumeLayout(false);
            this.maintab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btdisc;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btconnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBits;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.TextBox txtkq;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage maintab;
        private System.Windows.Forms.Button btstop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox kd;
        private System.Windows.Forms.TextBox ki;
        private System.Windows.Forms.TextBox kp;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button btsendcontrol;
        private System.Windows.Forms.Button btcleargraph;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton btnegative;
        private System.Windows.Forms.RadioButton btpositive;
        private System.Windows.Forms.CheckBox checkpos;
        private System.Windows.Forms.CheckBox checkspeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsetposition;
        private System.Windows.Forms.TextBox txtsetspeed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timercheck;
        private System.Windows.Forms.TextBox sendnao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btrefesh;
    }
}

