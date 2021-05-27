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
            this.graph = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.txtsend = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.btdisc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
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
            this.maintab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btstartgraph = new System.Windows.Forms.Button();
            this.btcleargraph = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnegative = new System.Windows.Forms.RadioButton();
            this.btpositive = new System.Windows.Forms.RadioButton();
            this.msg = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.Location = new System.Drawing.Point(474, 13);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(75, 23);
            this.graph.TabIndex = 34;
            this.graph.Text = "button1";
            this.graph.UseVisualStyleBackColor = true;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(526, 239);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 33;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btsend_Click);
            // 
            // txtsend
            // 
            this.txtsend.Location = new System.Drawing.Point(265, 209);
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(336, 20);
            this.txtsend.TabIndex = 32;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(45, 242);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 31;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btdisc
            // 
            this.btdisc.Location = new System.Drawing.Point(121, 209);
            this.btdisc.Name = "btdisc";
            this.btdisc.Size = new System.Drawing.Size(90, 23);
            this.btdisc.TabIndex = 30;
            this.btdisc.Text = "DISCONNECT";
            this.btdisc.UseVisualStyleBackColor = true;
            this.btdisc.Click += new System.EventHandler(this.btdisc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Received Data";
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(814, 11);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(75, 23);
            this.btclear.TabIndex = 28;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // btconnect
            // 
            this.btconnect.Location = new System.Drawing.Point(20, 209);
            this.btconnect.Name = "btconnect";
            this.btconnect.Size = new System.Drawing.Size(75, 23);
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
            this.txtkq.Location = new System.Drawing.Point(360, 11);
            this.txtkq.Multiline = true;
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(411, 36);
            this.txtkq.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.maintab);
            this.tabControl1.Location = new System.Drawing.Point(7, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 396);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.cbCom);
            this.tabPage1.Controls.Add(this.btSend);
            this.tabPage1.Controls.Add(this.graph);
            this.tabPage1.Controls.Add(this.txtsend);
            this.tabPage1.Controls.Add(this.cbRate);
            this.tabPage1.Controls.Add(this.exit);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btdisc);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btconnect);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbBits);
            this.tabPage1.Controls.Add(this.cbBit);
            this.tabPage1.Controls.Add(this.cbParity);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1044, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // maintab
            // 
            this.maintab.BackColor = System.Drawing.Color.LightGray;
            this.maintab.Controls.Add(this.groupBox1);
            this.maintab.Controls.Add(this.groupBox2);
            this.maintab.Controls.Add(this.btnegative);
            this.maintab.Controls.Add(this.btpositive);
            this.maintab.Controls.Add(this.msg);
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
            this.maintab.Size = new System.Drawing.Size(1044, 370);
            this.maintab.TabIndex = 1;
            this.maintab.Text = "tabPage2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btstartgraph);
            this.groupBox1.Controls.Add(this.btcleargraph);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(277, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 212);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph Menu";
            // 
            // btstartgraph
            // 
            this.btstartgraph.ForeColor = System.Drawing.Color.Blue;
            this.btstartgraph.Location = new System.Drawing.Point(16, 21);
            this.btstartgraph.Name = "btstartgraph";
            this.btstartgraph.Size = new System.Drawing.Size(89, 47);
            this.btstartgraph.TabIndex = 0;
            this.btstartgraph.Text = "START";
            this.btstartgraph.UseVisualStyleBackColor = true;
            this.btstartgraph.Click += new System.EventHandler(this.btstartgraph_Click);
            // 
            // btcleargraph
            // 
            this.btcleargraph.Location = new System.Drawing.Point(17, 155);
            this.btcleargraph.Name = "btcleargraph";
            this.btcleargraph.Size = new System.Drawing.Size(88, 37);
            this.btcleargraph.TabIndex = 26;
            this.btcleargraph.Text = "CLEAR";
            this.btcleargraph.UseVisualStyleBackColor = true;
            this.btcleargraph.Click += new System.EventHandler(this.btcleargraph_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsp);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtpo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(543, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 70);
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
            this.label12.Location = new System.Drawing.Point(206, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "POSITION";
            // 
            // txtpo
            // 
            this.txtpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpo.Location = new System.Drawing.Point(209, 36);
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
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "SPEED";
            // 
            // btnegative
            // 
            this.btnegative.AutoSize = true;
            this.btnegative.Location = new System.Drawing.Point(130, 171);
            this.btnegative.Name = "btnegative";
            this.btnegative.Size = new System.Drawing.Size(71, 17);
            this.btnegative.TabIndex = 41;
            this.btnegative.TabStop = true;
            this.btnegative.Text = "- direction";
            this.btnegative.UseVisualStyleBackColor = true;
            this.btnegative.CheckedChanged += new System.EventHandler(this.btnegative_CheckedChanged);
            // 
            // btpositive
            // 
            this.btpositive.AutoSize = true;
            this.btpositive.Location = new System.Drawing.Point(17, 171);
            this.btpositive.Name = "btpositive";
            this.btpositive.Size = new System.Drawing.Size(74, 17);
            this.btpositive.TabIndex = 33;
            this.btpositive.TabStop = true;
            this.btpositive.Text = "+ direction";
            this.btpositive.UseVisualStyleBackColor = true;
            this.btpositive.CheckedChanged += new System.EventHandler(this.btpositive_CheckedChanged);
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(3, 261);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.ReadOnly = true;
            this.msg.Size = new System.Drawing.Size(333, 35);
            this.msg.TabIndex = 40;
            // 
            // checkpos
            // 
            this.checkpos.AutoSize = true;
            this.checkpos.Location = new System.Drawing.Point(3, 238);
            this.checkpos.Name = "checkpos";
            this.checkpos.Size = new System.Drawing.Size(99, 17);
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
            this.checkspeed.Location = new System.Drawing.Point(3, 203);
            this.checkspeed.Name = "checkspeed";
            this.checkspeed.Size = new System.Drawing.Size(93, 17);
            this.checkspeed.TabIndex = 38;
            this.checkspeed.Text = "Speed Control";
            this.checkspeed.UseVisualStyleBackColor = true;
            this.checkspeed.CheckedChanged += new System.EventHandler(this.checkspeed_CheckedChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "degree";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "rpm";
            // 
            // txtsetposition
            // 
            this.txtsetposition.Location = new System.Drawing.Point(110, 235);
            this.txtsetposition.Name = "txtsetposition";
            this.txtsetposition.Size = new System.Drawing.Size(100, 20);
            this.txtsetposition.TabIndex = 35;
            this.txtsetposition.TextChanged += new System.EventHandler(this.txtsetposition_TextChanged);
            // 
            // txtsetspeed
            // 
            this.txtsetspeed.Location = new System.Drawing.Point(110, 200);
            this.txtsetspeed.Name = "txtsetspeed";
            this.txtsetspeed.Size = new System.Drawing.Size(100, 20);
            this.txtsetspeed.TabIndex = 34;
            this.txtsetspeed.TextChanged += new System.EventHandler(this.txtsetspeed_TextChanged);
            // 
            // btsendcontrol
            // 
            this.btsendcontrol.Location = new System.Drawing.Point(39, 312);
            this.btsendcontrol.Name = "btsendcontrol";
            this.btsendcontrol.Size = new System.Drawing.Size(90, 37);
            this.btsendcontrol.TabIndex = 32;
            this.btsendcontrol.Text = "SEND";
            this.btsendcontrol.UseVisualStyleBackColor = true;
            this.btsendcontrol.Click += new System.EventHandler(this.btsendcontrol_Click);
            // 
            // btstop
            // 
            this.btstop.Location = new System.Drawing.Point(174, 312);
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
            this.label8.Location = new System.Drawing.Point(30, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Kd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ki";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Kp";
            // 
            // kd
            // 
            this.kd.Location = new System.Drawing.Point(59, 139);
            this.kd.Name = "kd";
            this.kd.Size = new System.Drawing.Size(100, 20);
            this.kd.TabIndex = 27;
            this.kd.TextChanged += new System.EventHandler(this.kd_TextChanged);
            // 
            // ki
            // 
            this.ki.Location = new System.Drawing.Point(59, 105);
            this.ki.Name = "ki";
            this.ki.Size = new System.Drawing.Size(100, 20);
            this.ki.TabIndex = 26;
            this.ki.TextChanged += new System.EventHandler(this.ki_TextChanged);
            // 
            // kp
            // 
            this.kp.Location = new System.Drawing.Point(59, 76);
            this.kp.Name = "kp";
            this.kp.Size = new System.Drawing.Size(100, 20);
            this.kp.TabIndex = 25;
            this.kp.TextChanged += new System.EventHandler(this.kp_TextChanged);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(403, 21);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(638, 269);
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
            this.ClientSize = new System.Drawing.Size(1095, 542);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.btclear);
            this.Name = "MotorControl";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MotorControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.maintab.ResumeLayout(false);
            this.maintab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button graph;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btdisc;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btstartgraph;
        private System.Windows.Forms.Button btcleargraph;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton btnegative;
        private System.Windows.Forms.RadioButton btpositive;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.CheckBox checkpos;
        private System.Windows.Forms.CheckBox checkspeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsetposition;
        private System.Windows.Forms.TextBox txtsetspeed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timercheck;
    }
}

