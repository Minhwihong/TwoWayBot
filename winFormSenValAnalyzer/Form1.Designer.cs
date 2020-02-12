namespace winFormSenValAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtAcceleration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtUDP_PortNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveAccel = new System.Windows.Forms.Button();
            this.btnInitSenData = new System.Windows.Forms.Button();
            this.tmUDPListener = new System.Windows.Forms.Timer(this.components);
            this.btnServerOpen = new System.Windows.Forms.Button();
            this.btnServerClose = new System.Windows.Forms.Button();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.btnMotorStop = new System.Windows.Forms.Button();
            this.btnMotorRev = new System.Windows.Forms.Button();
            this.numPWMDuty = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMotorForw = new System.Windows.Forms.Button();
            this.btnLogStart = new System.Windows.Forms.Button();
            this.txtFilDeg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefreshGyro = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numPID_Kp = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numPID_Ki = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numPID_Kd = new System.Windows.Forms.NumericUpDown();
            this.btnPID_start = new System.Windows.Forms.Button();
            this.btnPID_stop = new System.Windows.Forms.Button();
            this.btnPID_reset = new System.Windows.Forms.Button();
            this.txtPID_err = new System.Windows.Forms.TextBox();
            this.txtPID_accumErr = new System.Windows.Forms.TextBox();
            this.txtPID_Ireg = new System.Windows.Forms.TextBox();
            this.txtPID_Preg = new System.Windows.Forms.TextBox();
            this.txtPID_Dreg = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPID_val = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnPID_renew = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPIDLogging = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbBotCtl = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBotCtl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSetTrgAngle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numTrgAngle = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbtnKalmanFilter = new System.Windows.Forms.RadioButton();
            this.rdbtnCompliFilter = new System.Windows.Forms.RadioButton();
            this.rdbtnNoFilter = new System.Windows.Forms.RadioButton();
            this.chbPID_sensing = new System.Windows.Forms.CheckBox();
            this.chbPID_target = new System.Windows.Forms.CheckBox();
            this.chbReserve3 = new System.Windows.Forms.CheckBox();
            this.chbAccumErr = new System.Windows.Forms.CheckBox();
            this.chbCurrErr = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.chbShowGyroZ = new System.Windows.Forms.CheckBox();
            this.chbShowGyroY = new System.Windows.Forms.CheckBox();
            this.chbShowGyroX = new System.Windows.Forms.CheckBox();
            this.chbShowAccZ = new System.Windows.Forms.CheckBox();
            this.chbShowAccY = new System.Windows.Forms.CheckBox();
            this.chbShowAccX = new System.Windows.Forms.CheckBox();
            this.chrtGyroscope = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grvMonitor = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAcceleration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPWMDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPID_Kp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPID_Ki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPID_Kd)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbBotCtl.SuspendLayout();
            this.tabBotCtl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrgAngle)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGyroscope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtAcceleration
            // 
            chartArea5.Name = "ChartArea1";
            this.chrtAcceleration.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chrtAcceleration.Legends.Add(legend5);
            this.chrtAcceleration.Location = new System.Drawing.Point(91, 7);
            this.chrtAcceleration.Name = "chrtAcceleration";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chrtAcceleration.Series.Add(series5);
            this.chrtAcceleration.Size = new System.Drawing.Size(860, 288);
            this.chrtAcceleration.TabIndex = 0;
            this.chrtAcceleration.Text = "chart1";
            // 
            // txtUDP_PortNum
            // 
            this.txtUDP_PortNum.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUDP_PortNum.Location = new System.Drawing.Point(45, 53);
            this.txtUDP_PortNum.Name = "txtUDP_PortNum";
            this.txtUDP_PortNum.Size = new System.Drawing.Size(57, 22);
            this.txtUDP_PortNum.TabIndex = 2;
            this.txtUDP_PortNum.Text = "44444";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "포트";
            // 
            // btnSaveAccel
            // 
            this.btnSaveAccel.Location = new System.Drawing.Point(87, 156);
            this.btnSaveAccel.Name = "btnSaveAccel";
            this.btnSaveAccel.Size = new System.Drawing.Size(73, 35);
            this.btnSaveAccel.TabIndex = 12;
            this.btnSaveAccel.Text = "데이터저장";
            this.btnSaveAccel.UseVisualStyleBackColor = true;
            this.btnSaveAccel.Click += new System.EventHandler(this.btnSaveAccel_Click);
            // 
            // btnInitSenData
            // 
            this.btnInitSenData.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInitSenData.Location = new System.Drawing.Point(26, 262);
            this.btnInitSenData.Name = "btnInitSenData";
            this.btnInitSenData.Size = new System.Drawing.Size(59, 35);
            this.btnInitSenData.TabIndex = 14;
            this.btnInitSenData.Text = "그래프지우기";
            this.btnInitSenData.UseVisualStyleBackColor = true;
            this.btnInitSenData.Click += new System.EventHandler(this.btnInitSenData_Click);
            // 
            // tmUDPListener
            // 
            this.tmUDPListener.Interval = 1;
            this.tmUDPListener.Tick += new System.EventHandler(this.tmUDPListener_Tick);
            // 
            // btnServerOpen
            // 
            this.btnServerOpen.Location = new System.Drawing.Point(111, 53);
            this.btnServerOpen.Name = "btnServerOpen";
            this.btnServerOpen.Size = new System.Drawing.Size(67, 26);
            this.btnServerOpen.TabIndex = 16;
            this.btnServerOpen.Text = "서버오픈";
            this.btnServerOpen.UseVisualStyleBackColor = true;
            this.btnServerOpen.Click += new System.EventHandler(this.btnServerOpen_Click);
            // 
            // btnServerClose
            // 
            this.btnServerClose.Location = new System.Drawing.Point(111, 81);
            this.btnServerClose.Name = "btnServerClose";
            this.btnServerClose.Size = new System.Drawing.Size(67, 26);
            this.btnServerClose.TabIndex = 17;
            this.btnServerClose.Text = "서버닫기";
            this.btnServerClose.UseVisualStyleBackColor = true;
            this.btnServerClose.Click += new System.EventHandler(this.btnServerClose_Click);
            // 
            // txtTheta
            // 
            this.txtTheta.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTheta.Location = new System.Drawing.Point(89, 24);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.ReadOnly = true;
            this.txtTheta.Size = new System.Drawing.Size(70, 22);
            this.txtTheta.TabIndex = 30;
            // 
            // btnMotorStop
            // 
            this.btnMotorStop.Location = new System.Drawing.Point(11, 156);
            this.btnMotorStop.Name = "btnMotorStop";
            this.btnMotorStop.Size = new System.Drawing.Size(73, 35);
            this.btnMotorStop.TabIndex = 31;
            this.btnMotorStop.Text = "정지";
            this.btnMotorStop.UseVisualStyleBackColor = true;
            this.btnMotorStop.Click += new System.EventHandler(this.btnMotorStop_Click);
            // 
            // btnMotorRev
            // 
            this.btnMotorRev.Location = new System.Drawing.Point(87, 118);
            this.btnMotorRev.Name = "btnMotorRev";
            this.btnMotorRev.Size = new System.Drawing.Size(73, 35);
            this.btnMotorRev.TabIndex = 33;
            this.btnMotorRev.Text = "후진";
            this.btnMotorRev.UseVisualStyleBackColor = true;
            this.btnMotorRev.Click += new System.EventHandler(this.btnMotorRev_Click);
            // 
            // numPWMDuty
            // 
            this.numPWMDuty.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numPWMDuty.Location = new System.Drawing.Point(89, 77);
            this.numPWMDuty.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numPWMDuty.Name = "numPWMDuty";
            this.numPWMDuty.Size = new System.Drawing.Size(71, 26);
            this.numPWMDuty.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(19, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "PWM Duty";
            // 
            // btnMotorForw
            // 
            this.btnMotorForw.Location = new System.Drawing.Point(11, 118);
            this.btnMotorForw.Name = "btnMotorForw";
            this.btnMotorForw.Size = new System.Drawing.Size(73, 35);
            this.btnMotorForw.TabIndex = 36;
            this.btnMotorForw.Text = "전진";
            this.btnMotorForw.UseVisualStyleBackColor = true;
            this.btnMotorForw.Click += new System.EventHandler(this.btnMotorForw_Click);
            // 
            // btnLogStart
            // 
            this.btnLogStart.Location = new System.Drawing.Point(163, 118);
            this.btnLogStart.Name = "btnLogStart";
            this.btnLogStart.Size = new System.Drawing.Size(73, 35);
            this.btnLogStart.TabIndex = 37;
            this.btnLogStart.Text = "로깅시작";
            this.btnLogStart.UseVisualStyleBackColor = true;
            this.btnLogStart.Click += new System.EventHandler(this.btnLogStart_Click);
            // 
            // txtFilDeg
            // 
            this.txtFilDeg.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFilDeg.Location = new System.Drawing.Point(111, 18);
            this.txtFilDeg.Name = "txtFilDeg";
            this.txtFilDeg.Size = new System.Drawing.Size(96, 22);
            this.txtFilDeg.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "상보필터 적용";
            // 
            // btnRefreshGyro
            // 
            this.btnRefreshGyro.Location = new System.Drawing.Point(163, 156);
            this.btnRefreshGyro.Name = "btnRefreshGyro";
            this.btnRefreshGyro.Size = new System.Drawing.Size(73, 35);
            this.btnRefreshGyro.TabIndex = 41;
            this.btnRefreshGyro.Text = "자이로 Refresh";
            this.btnRefreshGyro.UseVisualStyleBackColor = true;
            this.btnRefreshGyro.Click += new System.EventHandler(this.btnRefreshGyro_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(9, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Kp";
            // 
            // numPID_Kp
            // 
            this.numPID_Kp.DecimalPlaces = 3;
            this.numPID_Kp.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numPID_Kp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numPID_Kp.Location = new System.Drawing.Point(34, 20);
            this.numPID_Kp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numPID_Kp.Name = "numPID_Kp";
            this.numPID_Kp.Size = new System.Drawing.Size(74, 22);
            this.numPID_Kp.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(11, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "Ki";
            // 
            // numPID_Ki
            // 
            this.numPID_Ki.DecimalPlaces = 3;
            this.numPID_Ki.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numPID_Ki.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numPID_Ki.Location = new System.Drawing.Point(34, 46);
            this.numPID_Ki.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numPID_Ki.Name = "numPID_Ki";
            this.numPID_Ki.Size = new System.Drawing.Size(74, 22);
            this.numPID_Ki.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(9, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "Kd";
            // 
            // numPID_Kd
            // 
            this.numPID_Kd.DecimalPlaces = 3;
            this.numPID_Kd.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numPID_Kd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numPID_Kd.Location = new System.Drawing.Point(34, 72);
            this.numPID_Kd.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numPID_Kd.Name = "numPID_Kd";
            this.numPID_Kd.Size = new System.Drawing.Size(74, 22);
            this.numPID_Kd.TabIndex = 46;
            // 
            // btnPID_start
            // 
            this.btnPID_start.Location = new System.Drawing.Point(117, 19);
            this.btnPID_start.Name = "btnPID_start";
            this.btnPID_start.Size = new System.Drawing.Size(84, 25);
            this.btnPID_start.TabIndex = 48;
            this.btnPID_start.Text = "PID 시작";
            this.btnPID_start.UseVisualStyleBackColor = true;
            this.btnPID_start.Click += new System.EventHandler(this.btnPID_start_Click);
            // 
            // btnPID_stop
            // 
            this.btnPID_stop.Location = new System.Drawing.Point(117, 45);
            this.btnPID_stop.Name = "btnPID_stop";
            this.btnPID_stop.Size = new System.Drawing.Size(84, 25);
            this.btnPID_stop.TabIndex = 49;
            this.btnPID_stop.Text = "PID 정지";
            this.btnPID_stop.UseVisualStyleBackColor = true;
            this.btnPID_stop.Click += new System.EventHandler(this.btnPID_stop_Click);
            // 
            // btnPID_reset
            // 
            this.btnPID_reset.Location = new System.Drawing.Point(117, 71);
            this.btnPID_reset.Name = "btnPID_reset";
            this.btnPID_reset.Size = new System.Drawing.Size(84, 25);
            this.btnPID_reset.TabIndex = 50;
            this.btnPID_reset.Text = "PID Reset";
            this.btnPID_reset.UseVisualStyleBackColor = true;
            this.btnPID_reset.Click += new System.EventHandler(this.btnPID_reset_Click);
            // 
            // txtPID_err
            // 
            this.txtPID_err.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPID_err.Location = new System.Drawing.Point(78, 18);
            this.txtPID_err.Name = "txtPID_err";
            this.txtPID_err.ReadOnly = true;
            this.txtPID_err.Size = new System.Drawing.Size(125, 22);
            this.txtPID_err.TabIndex = 51;
            // 
            // txtPID_accumErr
            // 
            this.txtPID_accumErr.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPID_accumErr.Location = new System.Drawing.Point(78, 46);
            this.txtPID_accumErr.Name = "txtPID_accumErr";
            this.txtPID_accumErr.ReadOnly = true;
            this.txtPID_accumErr.Size = new System.Drawing.Size(125, 22);
            this.txtPID_accumErr.TabIndex = 52;
            // 
            // txtPID_Ireg
            // 
            this.txtPID_Ireg.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPID_Ireg.Location = new System.Drawing.Point(78, 103);
            this.txtPID_Ireg.Name = "txtPID_Ireg";
            this.txtPID_Ireg.ReadOnly = true;
            this.txtPID_Ireg.Size = new System.Drawing.Size(125, 22);
            this.txtPID_Ireg.TabIndex = 54;
            // 
            // txtPID_Preg
            // 
            this.txtPID_Preg.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPID_Preg.Location = new System.Drawing.Point(78, 75);
            this.txtPID_Preg.Name = "txtPID_Preg";
            this.txtPID_Preg.ReadOnly = true;
            this.txtPID_Preg.Size = new System.Drawing.Size(125, 22);
            this.txtPID_Preg.TabIndex = 53;
            // 
            // txtPID_Dreg
            // 
            this.txtPID_Dreg.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPID_Dreg.Location = new System.Drawing.Point(78, 131);
            this.txtPID_Dreg.Name = "txtPID_Dreg";
            this.txtPID_Dreg.ReadOnly = true;
            this.txtPID_Dreg.Size = new System.Drawing.Size(125, 22);
            this.txtPID_Dreg.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(11, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 56;
            this.label11.Text = "Error";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(11, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 57;
            this.label12.Text = "누적에러";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(11, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 15);
            this.label13.TabIndex = 58;
            this.label13.Text = "P-Reg";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(11, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 59;
            this.label14.Text = "I-Reg";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(11, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 60;
            this.label15.Text = "D-Reg";
            // 
            // txtPID_val
            // 
            this.txtPID_val.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPID_val.Location = new System.Drawing.Point(78, 159);
            this.txtPID_val.Name = "txtPID_val";
            this.txtPID_val.ReadOnly = true;
            this.txtPID_val.Size = new System.Drawing.Size(125, 22);
            this.txtPID_val.TabIndex = 61;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(11, 162);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 15);
            this.label16.TabIndex = 62;
            this.label16.Text = "PID";
            // 
            // btnPID_renew
            // 
            this.btnPID_renew.Location = new System.Drawing.Point(34, 100);
            this.btnPID_renew.Name = "btnPID_renew";
            this.btnPID_renew.Size = new System.Drawing.Size(74, 26);
            this.btnPID_renew.TabIndex = 63;
            this.btnPID_renew.Text = "갱신";
            this.btnPID_renew.UseVisualStyleBackColor = true;
            this.btnPID_renew.Click += new System.EventHandler(this.btnPID_renew_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 24);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem,
            this.tableToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.tableToolStripMenuItem.Text = "Table";
            this.tableToolStripMenuItem.Click += new System.EventHandler(this.tableToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uDPToolStripMenuItem,
            this.testModeToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.settingToolStripMenuItem.Text = "setting";
            // 
            // uDPToolStripMenuItem
            // 
            this.uDPToolStripMenuItem.Name = "uDPToolStripMenuItem";
            this.uDPToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.uDPToolStripMenuItem.Text = "setup";
            // 
            // testModeToolStripMenuItem
            // 
            this.testModeToolStripMenuItem.Name = "testModeToolStripMenuItem";
            this.testModeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.testModeToolStripMenuItem.Text = "TestMode";
            this.testModeToolStripMenuItem.Click += new System.EventHandler(this.testModeToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1258, 25);
            this.toolStrip1.TabIndex = 65;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPID_Preg);
            this.groupBox1.Controls.Add(this.txtPID_err);
            this.groupBox1.Controls.Add(this.txtPID_accumErr);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtPID_Ireg);
            this.groupBox1.Controls.Add(this.txtPID_val);
            this.groupBox1.Controls.Add(this.txtPID_Dreg);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(8, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 191);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PID 파라미터";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPIDLogging);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numPID_Kp);
            this.groupBox2.Controls.Add(this.numPID_Ki);
            this.groupBox2.Controls.Add(this.btnPID_renew);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnPID_reset);
            this.groupBox2.Controls.Add(this.numPID_Kd);
            this.groupBox2.Controls.Add(this.btnPID_stop);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnPID_start);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 135);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PID제어";
            // 
            // btnPIDLogging
            // 
            this.btnPIDLogging.Location = new System.Drawing.Point(117, 100);
            this.btnPIDLogging.Name = "btnPIDLogging";
            this.btnPIDLogging.Size = new System.Drawing.Size(84, 25);
            this.btnPIDLogging.TabIndex = 64;
            this.btnPIDLogging.Text = "PID 로깅";
            this.btnPIDLogging.UseVisualStyleBackColor = true;
            this.btnPIDLogging.Click += new System.EventHandler(this.btnPIDLogging_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(10, 130);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbBotCtl);
            this.splitContainer1.Panel1.Controls.Add(this.tabBotCtl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.chbPID_sensing);
            this.splitContainer1.Panel2.Controls.Add(this.chbPID_target);
            this.splitContainer1.Panel2.Controls.Add(this.chbReserve3);
            this.splitContainer1.Panel2.Controls.Add(this.chbAccumErr);
            this.splitContainer1.Panel2.Controls.Add(this.btnInitSenData);
            this.splitContainer1.Panel2.Controls.Add(this.chbCurrErr);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox9);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox5);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox6);
            this.splitContainer1.Panel2.Controls.Add(this.chbShowGyroZ);
            this.splitContainer1.Panel2.Controls.Add(this.chbShowGyroY);
            this.splitContainer1.Panel2.Controls.Add(this.chbShowGyroX);
            this.splitContainer1.Panel2.Controls.Add(this.chbShowAccZ);
            this.splitContainer1.Panel2.Controls.Add(this.chbShowAccY);
            this.splitContainer1.Panel2.Controls.Add(this.chbShowAccX);
            this.splitContainer1.Panel2.Controls.Add(this.chrtGyroscope);
            this.splitContainer1.Panel2.Controls.Add(this.chrtAcceleration);
            this.splitContainer1.Size = new System.Drawing.Size(1239, 610);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 69;
            // 
            // grbBotCtl
            // 
            this.grbBotCtl.Controls.Add(this.btnSetTrgAngle);
            this.grbBotCtl.Controls.Add(this.numPWMDuty);
            this.grbBotCtl.Controls.Add(this.label3);
            this.grbBotCtl.Controls.Add(this.label1);
            this.grbBotCtl.Controls.Add(this.numTrgAngle);
            this.grbBotCtl.Controls.Add(this.label6);
            this.grbBotCtl.Controls.Add(this.btnLogStart);
            this.grbBotCtl.Controls.Add(this.btnRefreshGyro);
            this.grbBotCtl.Controls.Add(this.btnSaveAccel);
            this.grbBotCtl.Controls.Add(this.btnMotorStop);
            this.grbBotCtl.Controls.Add(this.btnMotorForw);
            this.grbBotCtl.Controls.Add(this.txtTheta);
            this.grbBotCtl.Controls.Add(this.btnMotorRev);
            this.grbBotCtl.Enabled = false;
            this.grbBotCtl.Location = new System.Drawing.Point(7, 8);
            this.grbBotCtl.Name = "grbBotCtl";
            this.grbBotCtl.Size = new System.Drawing.Size(255, 207);
            this.grbBotCtl.TabIndex = 45;
            this.grbBotCtl.TabStop = false;
            this.grbBotCtl.Text = "로봇 조종";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "측정각도";
            // 
            // tabBotCtl
            // 
            this.tabBotCtl.Controls.Add(this.tabPage1);
            this.tabBotCtl.Controls.Add(this.tabPage2);
            this.tabBotCtl.Enabled = false;
            this.tabBotCtl.Location = new System.Drawing.Point(7, 221);
            this.tabBotCtl.Name = "tabBotCtl";
            this.tabBotCtl.SelectedIndex = 0;
            this.tabBotCtl.Size = new System.Drawing.Size(255, 378);
            this.tabBotCtl.TabIndex = 68;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(247, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PID제어";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(247, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "각도 보정";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSetTrgAngle
            // 
            this.btnSetTrgAngle.Location = new System.Drawing.Point(165, 49);
            this.btnSetTrgAngle.Name = "btnSetTrgAngle";
            this.btnSetTrgAngle.Size = new System.Drawing.Size(71, 25);
            this.btnSetTrgAngle.TabIndex = 64;
            this.btnSetTrgAngle.Text = "적용";
            this.btnSetTrgAngle.UseVisualStyleBackColor = true;
            this.btnSetTrgAngle.Click += new System.EventHandler(this.btnSetTrgAngle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtFilDeg);
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Location = new System.Drawing.Point(8, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 103);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "상보필터";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(8, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 49;
            this.label5.Text = "Bias. Gyro";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Bias. Acc";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 3;
            this.numericUpDown3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown3.Location = new System.Drawing.Point(111, 72);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(85, 22);
            this.numericUpDown3.TabIndex = 47;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown2.Location = new System.Drawing.Point(111, 45);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(85, 22);
            this.numericUpDown2.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "목표각도";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numTrgAngle
            // 
            this.numTrgAngle.DecimalPlaces = 3;
            this.numTrgAngle.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numTrgAngle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numTrgAngle.Location = new System.Drawing.Point(89, 49);
            this.numTrgAngle.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numTrgAngle.Name = "numTrgAngle";
            this.numTrgAngle.Size = new System.Drawing.Size(71, 25);
            this.numTrgAngle.TabIndex = 44;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbtnKalmanFilter);
            this.groupBox4.Controls.Add(this.rdbtnCompliFilter);
            this.groupBox4.Controls.Add(this.rdbtnNoFilter);
            this.groupBox4.Location = new System.Drawing.Point(4, 478);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(82, 80);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "필터적용";
            // 
            // rdbtnKalmanFilter
            // 
            this.rdbtnKalmanFilter.AutoSize = true;
            this.rdbtnKalmanFilter.Location = new System.Drawing.Point(7, 58);
            this.rdbtnKalmanFilter.Name = "rdbtnKalmanFilter";
            this.rdbtnKalmanFilter.Size = new System.Drawing.Size(71, 16);
            this.rdbtnKalmanFilter.TabIndex = 2;
            this.rdbtnKalmanFilter.TabStop = true;
            this.rdbtnKalmanFilter.Text = "칼만필터";
            this.rdbtnKalmanFilter.UseVisualStyleBackColor = true;
            // 
            // rdbtnCompliFilter
            // 
            this.rdbtnCompliFilter.AutoSize = true;
            this.rdbtnCompliFilter.Location = new System.Drawing.Point(7, 37);
            this.rdbtnCompliFilter.Name = "rdbtnCompliFilter";
            this.rdbtnCompliFilter.Size = new System.Drawing.Size(71, 16);
            this.rdbtnCompliFilter.TabIndex = 1;
            this.rdbtnCompliFilter.TabStop = true;
            this.rdbtnCompliFilter.Text = "상보필터";
            this.rdbtnCompliFilter.UseVisualStyleBackColor = true;
            // 
            // rdbtnNoFilter
            // 
            this.rdbtnNoFilter.AutoSize = true;
            this.rdbtnNoFilter.Location = new System.Drawing.Point(7, 17);
            this.rdbtnNoFilter.Name = "rdbtnNoFilter";
            this.rdbtnNoFilter.Size = new System.Drawing.Size(59, 16);
            this.rdbtnNoFilter.TabIndex = 0;
            this.rdbtnNoFilter.TabStop = true;
            this.rdbtnNoFilter.Text = "미적용";
            this.rdbtnNoFilter.UseVisualStyleBackColor = true;
            // 
            // chbPID_sensing
            // 
            this.chbPID_sensing.AutoSize = true;
            this.chbPID_sensing.Location = new System.Drawing.Point(7, 348);
            this.chbPID_sensing.Name = "chbPID_sensing";
            this.chbPID_sensing.Size = new System.Drawing.Size(70, 16);
            this.chbPID_sensing.TabIndex = 46;
            this.chbPID_sensing.Text = "Sensing";
            this.chbPID_sensing.UseVisualStyleBackColor = true;
            this.chbPID_sensing.CheckedChanged += new System.EventHandler(this.chbPID_sensing_CheckedChanged);
            // 
            // chbPID_target
            // 
            this.chbPID_target.AutoSize = true;
            this.chbPID_target.Checked = true;
            this.chbPID_target.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPID_target.Location = new System.Drawing.Point(7, 330);
            this.chbPID_target.Name = "chbPID_target";
            this.chbPID_target.Size = new System.Drawing.Size(60, 16);
            this.chbPID_target.TabIndex = 45;
            this.chbPID_target.Text = "Target";
            this.chbPID_target.UseVisualStyleBackColor = true;
            this.chbPID_target.CheckedChanged += new System.EventHandler(this.chbPID_target_CheckedChanged);
            // 
            // chbReserve3
            // 
            this.chbReserve3.AutoSize = true;
            this.chbReserve3.Location = new System.Drawing.Point(7, 404);
            this.chbReserve3.Name = "chbReserve3";
            this.chbReserve3.Size = new System.Drawing.Size(56, 16);
            this.chbReserve3.TabIndex = 41;
            this.chbReserve3.Text = "Res.3";
            this.chbReserve3.UseVisualStyleBackColor = true;
            // 
            // chbAccumErr
            // 
            this.chbAccumErr.AutoSize = true;
            this.chbAccumErr.Location = new System.Drawing.Point(7, 384);
            this.chbAccumErr.Name = "chbAccumErr";
            this.chbAccumErr.Size = new System.Drawing.Size(77, 16);
            this.chbAccumErr.TabIndex = 40;
            this.chbAccumErr.Text = "Accu Err.";
            this.chbAccumErr.UseVisualStyleBackColor = true;
            this.chbAccumErr.CheckedChanged += new System.EventHandler(this.chbAccumErr_CheckedChanged);
            // 
            // chbCurrErr
            // 
            this.chbCurrErr.AutoSize = true;
            this.chbCurrErr.Checked = true;
            this.chbCurrErr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCurrErr.Location = new System.Drawing.Point(7, 366);
            this.chbCurrErr.Name = "chbCurrErr";
            this.chbCurrErr.Size = new System.Drawing.Size(72, 16);
            this.chbCurrErr.TabIndex = 39;
            this.chbCurrErr.Text = "Curr Err.";
            this.chbCurrErr.UseVisualStyleBackColor = true;
            this.chbCurrErr.CheckedChanged += new System.EventHandler(this.chbCurrErr_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(12, 156);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(56, 16);
            this.checkBox9.TabIndex = 38;
            this.checkBox9.Text = "Res.3";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(12, 137);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(56, 16);
            this.checkBox5.TabIndex = 37;
            this.checkBox5.Text = "Res.2";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(12, 118);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(56, 16);
            this.checkBox6.TabIndex = 36;
            this.checkBox6.Text = "Res.1";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // chbShowGyroZ
            // 
            this.chbShowGyroZ.AutoSize = true;
            this.chbShowGyroZ.Location = new System.Drawing.Point(12, 101);
            this.chbShowGyroZ.Name = "chbShowGyroZ";
            this.chbShowGyroZ.Size = new System.Drawing.Size(49, 16);
            this.chbShowGyroZ.TabIndex = 35;
            this.chbShowGyroZ.Text = "Yaw";
            this.chbShowGyroZ.UseVisualStyleBackColor = true;
            this.chbShowGyroZ.CheckedChanged += new System.EventHandler(this.chbShowGyroZ_CheckedChanged);
            // 
            // chbShowGyroY
            // 
            this.chbShowGyroY.AutoSize = true;
            this.chbShowGyroY.Location = new System.Drawing.Point(12, 83);
            this.chbShowGyroY.Name = "chbShowGyroY";
            this.chbShowGyroY.Size = new System.Drawing.Size(52, 16);
            this.chbShowGyroY.TabIndex = 34;
            this.chbShowGyroY.Text = "Pitch";
            this.chbShowGyroY.UseVisualStyleBackColor = true;
            this.chbShowGyroY.CheckedChanged += new System.EventHandler(this.chbShowGyroY_CheckedChanged);
            // 
            // chbShowGyroX
            // 
            this.chbShowGyroX.AutoSize = true;
            this.chbShowGyroX.Checked = true;
            this.chbShowGyroX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowGyroX.Location = new System.Drawing.Point(12, 66);
            this.chbShowGyroX.Name = "chbShowGyroX";
            this.chbShowGyroX.Size = new System.Drawing.Size(45, 16);
            this.chbShowGyroX.TabIndex = 33;
            this.chbShowGyroX.Text = "Roll";
            this.chbShowGyroX.UseVisualStyleBackColor = true;
            this.chbShowGyroX.CheckedChanged += new System.EventHandler(this.chbShowGyroX_CheckedChanged);
            // 
            // chbShowAccZ
            // 
            this.chbShowAccZ.AutoSize = true;
            this.chbShowAccZ.Checked = true;
            this.chbShowAccZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowAccZ.Location = new System.Drawing.Point(12, 47);
            this.chbShowAccZ.Name = "chbShowAccZ";
            this.chbShowAccZ.Size = new System.Drawing.Size(58, 16);
            this.chbShowAccZ.TabIndex = 32;
            this.chbShowAccZ.Text = "Acc.Z";
            this.chbShowAccZ.UseVisualStyleBackColor = true;
            this.chbShowAccZ.CheckedChanged += new System.EventHandler(this.chbShowAccZ_CheckedChanged);
            // 
            // chbShowAccY
            // 
            this.chbShowAccY.AutoSize = true;
            this.chbShowAccY.Checked = true;
            this.chbShowAccY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowAccY.Location = new System.Drawing.Point(12, 29);
            this.chbShowAccY.Name = "chbShowAccY";
            this.chbShowAccY.Size = new System.Drawing.Size(58, 16);
            this.chbShowAccY.TabIndex = 31;
            this.chbShowAccY.Text = "Acc.Y";
            this.chbShowAccY.UseVisualStyleBackColor = true;
            this.chbShowAccY.CheckedChanged += new System.EventHandler(this.chbShowAccY_CheckedChanged);
            // 
            // chbShowAccX
            // 
            this.chbShowAccX.AutoSize = true;
            this.chbShowAccX.Location = new System.Drawing.Point(12, 11);
            this.chbShowAccX.Name = "chbShowAccX";
            this.chbShowAccX.Size = new System.Drawing.Size(58, 16);
            this.chbShowAccX.TabIndex = 30;
            this.chbShowAccX.Text = "Acc.X";
            this.chbShowAccX.UseVisualStyleBackColor = true;
            this.chbShowAccX.CheckedChanged += new System.EventHandler(this.chbShowAccX_CheckedChanged);
            // 
            // chrtGyroscope
            // 
            chartArea6.Name = "ChartArea1";
            this.chrtGyroscope.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chrtGyroscope.Legends.Add(legend6);
            this.chrtGyroscope.Location = new System.Drawing.Point(91, 301);
            this.chrtGyroscope.Name = "chrtGyroscope";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chrtGyroscope.Series.Add(series6);
            this.chrtGyroscope.Size = new System.Drawing.Size(860, 298);
            this.chrtGyroscope.TabIndex = 3;
            this.chrtGyroscope.Text = "chart2";
            // 
            // grvMonitor
            // 
            this.grvMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMonitor.Location = new System.Drawing.Point(366, 51);
            this.grvMonitor.Name = "grvMonitor";
            this.grvMonitor.RowTemplate.Height = 23;
            this.grvMonitor.Size = new System.Drawing.Size(865, 71);
            this.grvMonitor.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(26, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 35);
            this.button1.TabIndex = 47;
            this.button1.Text = "그래프지우기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 746);
            this.Controls.Add(this.grvMonitor);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnServerClose);
            this.Controls.Add(this.btnServerOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUDP_PortNum);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtAcceleration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPWMDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPID_Kp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPID_Ki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPID_Kd)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbBotCtl.ResumeLayout(false);
            this.grbBotCtl.PerformLayout();
            this.tabBotCtl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTrgAngle)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGyroscope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAcceleration;
        private System.Windows.Forms.TextBox txtUDP_PortNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveAccel;
        private System.Windows.Forms.Button btnInitSenData;
        private System.Windows.Forms.Timer tmUDPListener;
        private System.Windows.Forms.Button btnServerOpen;
        private System.Windows.Forms.Button btnServerClose;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.Button btnMotorStop;
        private System.Windows.Forms.Button btnMotorRev;
        private System.Windows.Forms.NumericUpDown numPWMDuty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMotorForw;
        private System.Windows.Forms.Button btnLogStart;
        private System.Windows.Forms.TextBox txtFilDeg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefreshGyro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPID_Kp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numPID_Ki;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPID_Kd;
        private System.Windows.Forms.Button btnPID_start;
        private System.Windows.Forms.Button btnPID_stop;
        private System.Windows.Forms.Button btnPID_reset;
        private System.Windows.Forms.TextBox txtPID_err;
        private System.Windows.Forms.TextBox txtPID_accumErr;
        private System.Windows.Forms.TextBox txtPID_Ireg;
        private System.Windows.Forms.TextBox txtPID_Preg;
        private System.Windows.Forms.TextBox txtPID_Dreg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPID_val;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnPID_renew;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabBotCtl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtGyroscope;
        private System.Windows.Forms.DataGridView grvMonitor;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uDPToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTrgAngle;
        private System.Windows.Forms.CheckBox chbReserve3;
        private System.Windows.Forms.CheckBox chbAccumErr;
        private System.Windows.Forms.CheckBox chbCurrErr;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox chbShowGyroZ;
        private System.Windows.Forms.CheckBox chbShowGyroY;
        private System.Windows.Forms.CheckBox chbShowGyroX;
        private System.Windows.Forms.CheckBox chbShowAccZ;
        private System.Windows.Forms.CheckBox chbShowAccY;
        private System.Windows.Forms.CheckBox chbShowAccX;
        private System.Windows.Forms.GroupBox grbBotCtl;
        private System.Windows.Forms.Button btnSetTrgAngle;
        private System.Windows.Forms.ToolStripMenuItem testModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnPIDLogging;
        private System.Windows.Forms.CheckBox chbPID_sensing;
        private System.Windows.Forms.CheckBox chbPID_target;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbtnKalmanFilter;
        private System.Windows.Forms.RadioButton rdbtnCompliFilter;
        private System.Windows.Forms.RadioButton rdbtnNoFilter;
        private System.Windows.Forms.Button button1;
    }
}

