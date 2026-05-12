namespace SyncConsole
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MonitorPanel = new System.Windows.Forms.Panel();
            this.TempMonitorPanel = new System.Windows.Forms.Panel();
            this.ParametersPanel = new System.Windows.Forms.Panel();
            this.ChkLPF = new System.Windows.Forms.CheckBox();
            this.ChkMVPol = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.syncD = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.PidKp = new System.Windows.Forms.NumericUpDown();
            this.PidKi = new System.Windows.Forms.NumericUpDown();
            this.PidKd = new System.Windows.Forms.NumericUpDown();
            this.syncM = new System.Windows.Forms.NumericUpDown();
            this.Label7 = new System.Windows.Forms.Label();
            this.syncType = new System.Windows.Forms.NumericUpDown();
            this.syncA = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.syncK = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.syncKi = new System.Windows.Forms.NumericUpDown();
            this.syncErrMargin = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.ManualMV = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.ButtonSetParameters = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.DVmon = new System.Windows.Forms.Label();
            this.RadioButtonSync = new System.Windows.Forms.RadioButton();
            this.RadioButtonManual = new System.Windows.Forms.RadioButton();
            this.ModeMon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TempMonitor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVdifference = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisturbanceInterval = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.DisturbanceStart = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.DisturbanceApply = new System.Windows.Forms.Button();
            this.DisturbanceAuto = new System.Windows.Forms.RadioButton();
            this.DisturbanceManual = new System.Windows.Forms.RadioButton();
            this.DisturbanceVariable = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.LabelController = new System.Windows.Forms.Label();
            this.RadioButtonIdle = new System.Windows.Forms.RadioButton();
            this.RadioButtonControl = new System.Windows.Forms.RadioButton();
            this.ButtonRecord = new System.Windows.Forms.Button();
            this.DataMonitor = new System.Windows.Forms.DataGridView();
            this.Ch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SVc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MVmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MVg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MVd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelError = new System.Windows.Forms.ToolStripStatusLabel();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.SamplingTimer = new System.Windows.Forms.Timer(this.components);
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PanelMonitor = new System.Windows.Forms.Panel();
            this.lblMVScale25 = new System.Windows.Forms.Label();
            this.lblMVScale75 = new System.Windows.Forms.Label();
            this.PanelMVFrame = new System.Windows.Forms.Panel();
            this.PictureBoxMV = new System.Windows.Forms.PictureBox();
            this.PanelSVPVFrame = new System.Windows.Forms.Panel();
            this.PictureBoxSVPV = new System.Windows.Forms.PictureBox();
            this.LabelTime5 = new System.Windows.Forms.Label();
            this.LabelTime0 = new System.Windows.Forms.Label();
            this.LabelTime4 = new System.Windows.Forms.Label();
            this.LabelTimeUnit = new System.Windows.Forms.Label();
            this.LabelTime3 = new System.Windows.Forms.Label();
            this.LabelTime2 = new System.Windows.Forms.Label();
            this.LabelTime1 = new System.Windows.Forms.Label();
            this.lblMVScale0 = new System.Windows.Forms.Label();
            this.lblTempScale0 = new System.Windows.Forms.Label();
            this.lblTempScale20 = new System.Windows.Forms.Label();
            this.lblTempScale40 = new System.Windows.Forms.Label();
            this.lblTempScale80 = new System.Windows.Forms.Label();
            this.lblTempScale60 = new System.Windows.Forms.Label();
            this.lblMVScale50 = new System.Windows.Forms.Label();
            this.lblMVScale100 = new System.Windows.Forms.Label();
            this.LabelMVunit = new System.Windows.Forms.Label();
            this.LabelPVunit = new System.Windows.Forms.Label();
            this.LabelSVunit = new System.Windows.Forms.Label();
            this.TimerWait = new System.Windows.Forms.Timer(this.components);
            this.MonitorPanel.SuspendLayout();
            this.TempMonitorPanel.SuspendLayout();
            this.ParametersPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syncD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PidKp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PidKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PidKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncErrMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualMV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempMonitor)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisturbanceInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisturbanceStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisturbanceVariable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataMonitor)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.PanelMonitor.SuspendLayout();
            this.PanelMVFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMV)).BeginInit();
            this.PanelSVPVFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSVPV)).BeginInit();
            this.SuspendLayout();
            // 
            // MonitorPanel
            // 
            this.MonitorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MonitorPanel.Controls.Add(this.TempMonitorPanel);
            this.MonitorPanel.Controls.Add(this.ControlPanel);
            this.MonitorPanel.Controls.Add(this.ButtonRecord);
            this.MonitorPanel.Controls.Add(this.DataMonitor);
            this.MonitorPanel.Location = new System.Drawing.Point(645, 3);
            this.MonitorPanel.Name = "MonitorPanel";
            this.MonitorPanel.Size = new System.Drawing.Size(284, 535);
            this.MonitorPanel.TabIndex = 36;
            // 
            // TempMonitorPanel
            // 
            this.TempMonitorPanel.Controls.Add(this.ParametersPanel);
            this.TempMonitorPanel.Controls.Add(this.ButtonSetParameters);
            this.TempMonitorPanel.Controls.Add(this.label16);
            this.TempMonitorPanel.Controls.Add(this.DVmon);
            this.TempMonitorPanel.Controls.Add(this.RadioButtonSync);
            this.TempMonitorPanel.Controls.Add(this.RadioButtonManual);
            this.TempMonitorPanel.Controls.Add(this.ModeMon);
            this.TempMonitorPanel.Controls.Add(this.label2);
            this.TempMonitorPanel.Controls.Add(this.TempMonitor);
            this.TempMonitorPanel.Controls.Add(this.PVdifference);
            this.TempMonitorPanel.Controls.Add(this.label24);
            this.TempMonitorPanel.Location = new System.Drawing.Point(0, 139);
            this.TempMonitorPanel.Name = "TempMonitorPanel";
            this.TempMonitorPanel.Size = new System.Drawing.Size(284, 241);
            this.TempMonitorPanel.TabIndex = 92;
            // 
            // ParametersPanel
            // 
            this.ParametersPanel.Controls.Add(this.ChkLPF);
            this.ParametersPanel.Controls.Add(this.ChkMVPol);
            this.ParametersPanel.Controls.Add(this.tableLayoutPanel1);
            this.ParametersPanel.Controls.Add(this.ManualMV);
            this.ParametersPanel.Controls.Add(this.Label3);
            this.ParametersPanel.Location = new System.Drawing.Point(100, 25);
            this.ParametersPanel.Name = "ParametersPanel";
            this.ParametersPanel.Size = new System.Drawing.Size(183, 159);
            this.ParametersPanel.TabIndex = 2;
            // 
            // ChkLPF
            // 
            this.ChkLPF.AutoSize = true;
            this.ChkLPF.Checked = true;
            this.ChkLPF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkLPF.Location = new System.Drawing.Point(131, 140);
            this.ChkLPF.Name = "ChkLPF";
            this.ChkLPF.Size = new System.Drawing.Size(44, 16);
            this.ChkLPF.TabIndex = 93;
            this.ChkLPF.Text = "LPF";
            this.ChkLPF.UseVisualStyleBackColor = true;
            this.ChkLPF.CheckedChanged += new System.EventHandler(this.Config_Changed);
            // 
            // ChkMVPol
            // 
            this.ChkMVPol.AutoSize = true;
            this.ChkMVPol.Location = new System.Drawing.Point(27, 140);
            this.ChkMVPol.Name = "ChkMVPol";
            this.ChkMVPol.Size = new System.Drawing.Size(74, 16);
            this.ChkMVPol.TabIndex = 92;
            this.ChkMVPol.Text = "MV BiPol.";
            this.ChkMVPol.UseVisualStyleBackColor = true;
            this.ChkMVPol.CheckedChanged += new System.EventHandler(this.Config_Changed);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.syncD, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label25, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label23, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.PidKp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.PidKi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PidKd, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.syncM, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.Label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.syncType, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.syncA, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.syncK, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Label5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label4, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.syncKi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.syncErrMargin, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 106);
            this.tableLayoutPanel1.TabIndex = 89;
            // 
            // syncD
            // 
            this.syncD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.syncD.Location = new System.Drawing.Point(131, 43);
            this.syncD.Margin = new System.Windows.Forms.Padding(1);
            this.syncD.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.syncD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.syncD.Name = "syncD";
            this.syncD.Size = new System.Drawing.Size(50, 19);
            this.syncD.TabIndex = 99;
            this.syncD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.syncD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.syncD.ValueChanged += new System.EventHandler(this.Parameter_Change);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(82, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(9, 12);
            this.label25.TabIndex = 93;
            this.label25.Text = " ";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(97, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 12);
            this.label23.TabIndex = 98;
            this.label23.Text = "D";
            // 
            // PidKp
            // 
            this.PidKp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PidKp.Location = new System.Drawing.Point(28, 1);
            this.PidKp.Margin = new System.Windows.Forms.Padding(1);
            this.PidKp.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.PidKp.Name = "PidKp";
            this.PidKp.Size = new System.Drawing.Size(50, 19);
            this.PidKp.TabIndex = 84;
            this.PidKp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PidKp.ValueChanged += new System.EventHandler(this.Parameter_Change);
            // 
            // PidKi
            // 
            this.PidKi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PidKi.Location = new System.Drawing.Point(28, 22);
            this.PidKi.Margin = new System.Windows.Forms.Padding(1);
            this.PidKi.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.PidKi.Name = "PidKi";
            this.PidKi.Size = new System.Drawing.Size(50, 19);
            this.PidKi.TabIndex = 83;
            this.PidKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PidKi.ValueChanged += new System.EventHandler(this.Parameter_Change);
            // 
            // PidKd
            // 
            this.PidKd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PidKd.Location = new System.Drawing.Point(28, 43);
            this.PidKd.Margin = new System.Windows.Forms.Padding(1);
            this.PidKd.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.PidKd.Name = "PidKd";
            this.PidKd.Size = new System.Drawing.Size(50, 19);
            this.PidKd.TabIndex = 82;
            this.PidKd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PidKd.ValueChanged += new System.EventHandler(this.Parameter_Change);
            // 
            // syncM
            // 
            this.syncM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.syncM.Location = new System.Drawing.Point(131, 85);
            this.syncM.Margin = new System.Windows.Forms.Padding(1);
            this.syncM.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.syncM.Name = "syncM";
            this.syncM.Size = new System.Drawing.Size(50, 19);
            this.syncM.TabIndex = 91;
            this.syncM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.syncM.ValueChanged += new System.EventHandler(this.Parameter_Change);
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label7.Location = new System.Drawing.Point(3, 4);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(18, 12);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Kp";
            // 
            // syncType
            // 
            this.syncType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.syncType.Location = new System.Drawing.Point(131, 1);
            this.syncType.Margin = new System.Windows.Forms.Padding(1);
            this.syncType.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.syncType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.syncType.Name = "syncType";
            this.syncType.Size = new System.Drawing.Size(50, 19);
            this.syncType.TabIndex = 92;
            this.syncType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.syncType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.syncType.ValueChanged += new System.EventHandler(this.Parameter_Change);
            // 
            // syncA
            // 
            this.syncA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.syncA.Location = new System.Drawing.Point(131, 64);
            this.syncA.Margin = new System.Windows.Forms.Padding(1);
            this.syncA.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.syncA.Name = "syncA";
            this.syncA.Size = new System.Drawing.Size(50, 19);
            this.syncA.TabIndex = 85;
            this.syncA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.syncA.ValueChanged += new System.EventHandler(this.Parameter_Change);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.Location = new System.Drawing.Point(97, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 12);
            this.label13.TabIndex = 66;
            this.label13.Text = "Type";
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(3, 25);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(15, 12);
            this.Label8.TabIndex = 27;
            this.Label8.Text = "Ki";
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(3, 46);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(18, 12);
            this.Label9.TabIndex = 28;
            this.Label9.Text = "Kd";
            // 
            // syncK
            // 
            this.syncK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.syncK.Location = new System.Drawing.Point(131, 22);
            this.syncK.Margin = new System.Windows.Forms.Padding(1);
            this.syncK.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.syncK.Name = "syncK";
            this.syncK.Size = new System.Drawing.Size(50, 19);
            this.syncK.TabIndex = 85;
            this.syncK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.syncK.ValueChanged += new System.EventHandler(this.Parameter_Change);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 12);
            this.label12.TabIndex = 66;
            this.label12.Text = "M";
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(97, 25);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(12, 12);
            this.Label5.TabIndex = 66;
            this.Label5.Text = "K";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(97, 67);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(13, 12);
            this.Label4.TabIndex = 65;
            this.Label4.Text = "A";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 12);
            this.label14.TabIndex = 95;
            this.label14.Text = "Si";
            // 
            // syncKi
            // 
            this.syncKi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.syncKi.Location = new System.Drawing.Point(28, 64);
            this.syncKi.Margin = new System.Windows.Forms.Padding(1);
            this.syncKi.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.syncKi.Name = "syncKi";
            this.syncKi.Size = new System.Drawing.Size(50, 19);
            this.syncKi.TabIndex = 93;
            this.syncKi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.syncKi.ValueChanged += new System.EventHandler(this.Parameter_Change);
            // 
            // syncErrMargin
            // 
            this.syncErrMargin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.syncErrMargin.Location = new System.Drawing.Point(28, 85);
            this.syncErrMargin.Margin = new System.Windows.Forms.Padding(1);
            this.syncErrMargin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.syncErrMargin.Name = "syncErrMargin";
            this.syncErrMargin.Size = new System.Drawing.Size(50, 19);
            this.syncErrMargin.TabIndex = 94;
            this.syncErrMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.syncErrMargin.ValueChanged += new System.EventHandler(this.Parameter_Change);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 12);
            this.label15.TabIndex = 96;
            this.label15.Text = "EM";
            // 
            // ManualMV
            // 
            this.ManualMV.BackColor = System.Drawing.SystemColors.Window;
            this.ManualMV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManualMV.Location = new System.Drawing.Point(131, 114);
            this.ManualMV.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ManualMV.Name = "ManualMV";
            this.ManualMV.ReadOnly = true;
            this.ManualMV.Size = new System.Drawing.Size(50, 19);
            this.ManualMV.TabIndex = 91;
            this.ManualMV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ManualMV.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.ManualMV.ValueChanged += new System.EventHandler(this.Parameter_Change);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(48, 116);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 12);
            this.Label3.TabIndex = 90;
            this.Label3.Text = "Manual MV [%]";
            // 
            // ButtonSetParameters
            // 
            this.ButtonSetParameters.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSetParameters.Location = new System.Drawing.Point(146, 189);
            this.ButtonSetParameters.Name = "ButtonSetParameters";
            this.ButtonSetParameters.Size = new System.Drawing.Size(121, 48);
            this.ButtonSetParameters.TabIndex = 18;
            this.ButtonSetParameters.Text = "Set";
            this.ButtonSetParameters.UseVisualStyleBackColor = false;
            this.ButtonSetParameters.Click += new System.EventHandler(this.ButtonSetParameters_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(206, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 12);
            this.label16.TabIndex = 70;
            this.label16.Text = "DV";
            // 
            // DVmon
            // 
            this.DVmon.BackColor = System.Drawing.Color.White;
            this.DVmon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DVmon.Location = new System.Drawing.Point(231, 2);
            this.DVmon.Name = "DVmon";
            this.DVmon.Size = new System.Drawing.Size(50, 19);
            this.DVmon.TabIndex = 69;
            this.DVmon.Text = "--";
            this.DVmon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadioButtonSync
            // 
            this.RadioButtonSync.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButtonSync.BackColor = System.Drawing.SystemColors.Control;
            this.RadioButtonSync.Checked = true;
            this.RadioButtonSync.Location = new System.Drawing.Point(16, 216);
            this.RadioButtonSync.Name = "RadioButtonSync";
            this.RadioButtonSync.Size = new System.Drawing.Size(121, 21);
            this.RadioButtonSync.TabIndex = 22;
            this.RadioButtonSync.TabStop = true;
            this.RadioButtonSync.Text = "Sync";
            this.RadioButtonSync.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonSync.UseVisualStyleBackColor = false;
            this.RadioButtonSync.CheckedChanged += new System.EventHandler(this.Algorism_CheckedChanged);
            // 
            // RadioButtonManual
            // 
            this.RadioButtonManual.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButtonManual.BackColor = System.Drawing.SystemColors.Control;
            this.RadioButtonManual.Location = new System.Drawing.Point(16, 190);
            this.RadioButtonManual.Name = "RadioButtonManual";
            this.RadioButtonManual.Size = new System.Drawing.Size(121, 21);
            this.RadioButtonManual.TabIndex = 14;
            this.RadioButtonManual.Text = "Manual";
            this.RadioButtonManual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonManual.UseVisualStyleBackColor = false;
            this.RadioButtonManual.CheckedChanged += new System.EventHandler(this.Algorism_CheckedChanged);
            // 
            // ModeMon
            // 
            this.ModeMon.BackColor = System.Drawing.Color.White;
            this.ModeMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModeMon.Location = new System.Drawing.Point(127, 2);
            this.ModeMon.Name = "ModeMon";
            this.ModeMon.Size = new System.Drawing.Size(50, 19);
            this.ModeMon.TabIndex = 69;
            this.ModeMon.Text = "--";
            this.ModeMon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 68;
            this.label2.Text = "Mode";
            // 
            // TempMonitor
            // 
            this.TempMonitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TempMonitor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TempMonitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TempMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TempMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.TempMonitor.Location = new System.Drawing.Point(6, 30);
            this.TempMonitor.MultiSelect = false;
            this.TempMonitor.Name = "TempMonitor";
            this.TempMonitor.RowHeadersVisible = false;
            this.TempMonitor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TempMonitor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TempMonitor.RowTemplate.Height = 21;
            this.TempMonitor.RowTemplate.ReadOnly = true;
            this.TempMonitor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TempMonitor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TempMonitor.Size = new System.Drawing.Size(80, 117); //117 to 147 well 21(header) + 21*6(sensor rows) =147
            this.TempMonitor.TabIndex = 67;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Ch";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 23;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "#.00";
            dataGridViewCellStyle3.NullValue = "--";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "T [℃]";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // PVdifference
            // 
            this.PVdifference.BackColor = System.Drawing.Color.White;
            this.PVdifference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PVdifference.Location = new System.Drawing.Point(34, 2);
            this.PVdifference.Name = "PVdifference";
            this.PVdifference.Size = new System.Drawing.Size(50, 19);
            this.PVdifference.TabIndex = 2;
            this.PVdifference.Text = "--";
            this.PVdifference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 5);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(26, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "dPV";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.groupBox1);
            this.ControlPanel.Controls.Add(this.LabelController);
            this.ControlPanel.Controls.Add(this.RadioButtonIdle);
            this.ControlPanel.Controls.Add(this.RadioButtonControl);
            this.ControlPanel.Location = new System.Drawing.Point(0, 385);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(284, 150);
            this.ControlPanel.TabIndex = 91;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisturbanceInterval);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.DisturbanceStart);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.DisturbanceApply);
            this.groupBox1.Controls.Add(this.DisturbanceAuto);
            this.groupBox1.Controls.Add(this.DisturbanceManual);
            this.groupBox1.Controls.Add(this.DisturbanceVariable);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(5, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 90);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disturbance";
            // 
            // DisturbanceInterval
            // 
            this.DisturbanceInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisturbanceInterval.Location = new System.Drawing.Point(212, 65);
            this.DisturbanceInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DisturbanceInterval.Name = "DisturbanceInterval";
            this.DisturbanceInterval.Size = new System.Drawing.Size(50, 19);
            this.DisturbanceInterval.TabIndex = 120;
            this.DisturbanceInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DisturbanceInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(129, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 12);
            this.label19.TabIndex = 119;
            this.label19.Text = "Interval [s]";
            // 
            // DisturbanceStart
            // 
            this.DisturbanceStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisturbanceStart.Location = new System.Drawing.Point(212, 42);
            this.DisturbanceStart.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DisturbanceStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DisturbanceStart.Name = "DisturbanceStart";
            this.DisturbanceStart.Size = new System.Drawing.Size(50, 19);
            this.DisturbanceStart.TabIndex = 118;
            this.DisturbanceStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DisturbanceStart.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(129, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 117;
            this.label18.Text = "Start Time [s]";
            // 
            // DisturbanceApply
            // 
            this.DisturbanceApply.BackColor = System.Drawing.SystemColors.Control;
            this.DisturbanceApply.Enabled = false;
            this.DisturbanceApply.Location = new System.Drawing.Point(141, 15);
            this.DisturbanceApply.Name = "DisturbanceApply";
            this.DisturbanceApply.Size = new System.Drawing.Size(121, 21);
            this.DisturbanceApply.TabIndex = 116;
            this.DisturbanceApply.Text = "Apply";
            this.DisturbanceApply.UseVisualStyleBackColor = false;
            this.DisturbanceApply.Click += new System.EventHandler(this.DisturbanceApply_Click);
            // 
            // DisturbanceAuto
            // 
            this.DisturbanceAuto.AutoSize = true;
            this.DisturbanceAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisturbanceAuto.Location = new System.Drawing.Point(77, 44);
            this.DisturbanceAuto.Name = "DisturbanceAuto";
            this.DisturbanceAuto.Size = new System.Drawing.Size(46, 16);
            this.DisturbanceAuto.TabIndex = 115;
            this.DisturbanceAuto.Text = "Auto";
            this.DisturbanceAuto.UseVisualStyleBackColor = true;
            // 
            // DisturbanceManual
            // 
            this.DisturbanceManual.AutoSize = true;
            this.DisturbanceManual.Checked = true;
            this.DisturbanceManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisturbanceManual.Location = new System.Drawing.Point(77, 18);
            this.DisturbanceManual.Name = "DisturbanceManual";
            this.DisturbanceManual.Size = new System.Drawing.Size(58, 16);
            this.DisturbanceManual.TabIndex = 114;
            this.DisturbanceManual.TabStop = true;
            this.DisturbanceManual.Text = "Manual";
            this.DisturbanceManual.UseVisualStyleBackColor = true;
            // 
            // DisturbanceVariable
            // 
            this.DisturbanceVariable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisturbanceVariable.Location = new System.Drawing.Point(11, 39);
            this.DisturbanceVariable.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.DisturbanceVariable.Name = "DisturbanceVariable";
            this.DisturbanceVariable.Size = new System.Drawing.Size(50, 19);
            this.DisturbanceVariable.TabIndex = 113;
            this.DisturbanceVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DisturbanceVariable.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 12);
            this.label17.TabIndex = 112;
            this.label17.Text = "DV [%]";
            // 
            // LabelController
            // 
            this.LabelController.BackColor = System.Drawing.Color.Blue;
            this.LabelController.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelController.ForeColor = System.Drawing.Color.Black;
            this.LabelController.Location = new System.Drawing.Point(5, 4);
            this.LabelController.Name = "LabelController";
            this.LabelController.Size = new System.Drawing.Size(273, 23);
            this.LabelController.TabIndex = 85;
            this.LabelController.Text = "Controller";
            this.LabelController.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RadioButtonIdle
            // 
            this.RadioButtonIdle.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButtonIdle.BackColor = System.Drawing.SystemColors.Control;
            this.RadioButtonIdle.Checked = true;
            this.RadioButtonIdle.Location = new System.Drawing.Point(16, 32);
            this.RadioButtonIdle.Name = "RadioButtonIdle";
            this.RadioButtonIdle.Size = new System.Drawing.Size(121, 21);
            this.RadioButtonIdle.TabIndex = 32;
            this.RadioButtonIdle.TabStop = true;
            this.RadioButtonIdle.Text = "Idle";
            this.RadioButtonIdle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonIdle.UseVisualStyleBackColor = false;
            this.RadioButtonIdle.CheckedChanged += new System.EventHandler(this.RadioButtonIdle_CheckedChanged);
            // 
            // RadioButtonControl
            // 
            this.RadioButtonControl.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButtonControl.BackColor = System.Drawing.SystemColors.Control;
            this.RadioButtonControl.Enabled = false;
            this.RadioButtonControl.Location = new System.Drawing.Point(146, 31);
            this.RadioButtonControl.Name = "RadioButtonControl";
            this.RadioButtonControl.Size = new System.Drawing.Size(121, 21);
            this.RadioButtonControl.TabIndex = 31;
            this.RadioButtonControl.Text = "Control";
            this.RadioButtonControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RadioButtonControl.UseVisualStyleBackColor = false;
            this.RadioButtonControl.CheckedChanged += new System.EventHandler(this.RadioButtonControl_CheckedChanged);
            // 
            // ButtonRecord
            // 
            this.ButtonRecord.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonRecord.Location = new System.Drawing.Point(5, 0);
            this.ButtonRecord.Name = "ButtonRecord";
            this.ButtonRecord.Size = new System.Drawing.Size(273, 21);
            this.ButtonRecord.TabIndex = 90;
            this.ButtonRecord.Text = "Record";
            this.ButtonRecord.UseVisualStyleBackColor = false;
            this.ButtonRecord.Click += new System.EventHandler(this.ButtonRecord_Click);
            // 
            // DataMonitor
            // 
            this.DataMonitor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataMonitor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataMonitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ch,
            this.SVc,
            this.PVmon,
            this.MVmon,
            this.MVg,
            this.MVd});
            this.DataMonitor.Location = new System.Drawing.Point(5, 27);
            this.DataMonitor.MultiSelect = false;
            this.DataMonitor.Name = "DataMonitor";
            this.DataMonitor.RowHeadersVisible = false;
            this.DataMonitor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataMonitor.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DataMonitor.RowTemplate.Height = 21;
            this.DataMonitor.RowTemplate.ReadOnly = true;
            this.DataMonitor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataMonitor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataMonitor.Size = new System.Drawing.Size(273, 110); //107 to 110 21(header) + 21*9(rows) = 210 if Height = 107px about 4-5 column (header ~21px + collum ~21px)
            this.DataMonitor.TabIndex = 66;
            // 
            // Ch
            // 
            this.Ch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ch.DefaultCellStyle = dataGridViewCellStyle6;
            this.Ch.Frozen = true;
            this.Ch.HeaderText = "Ch";
            this.Ch.Name = "Ch";
            this.Ch.ReadOnly = true;
            this.Ch.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Ch.Width = 23;
            // 
            // SVc
            // 
            this.SVc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SVc.HeaderText = "SV [℃]";
            this.SVc.Name = "SVc";
            this.SVc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SVc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SVc.Width = 50;
            // 
            // PVmon
            // 
            this.PVmon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "#.00";
            dataGridViewCellStyle7.NullValue = "--";
            this.PVmon.DefaultCellStyle = dataGridViewCellStyle7;
            this.PVmon.HeaderText = "PV [℃]";
            this.PVmon.Name = "PVmon";
            this.PVmon.ReadOnly = true;
            this.PVmon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PVmon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PVmon.Width = 50;
            // 
            // MVmon
            // 
            this.MVmon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "000.0";
            dataGridViewCellStyle8.NullValue = "--";
            this.MVmon.DefaultCellStyle = dataGridViewCellStyle8;
            this.MVmon.HeaderText = "MV [%]";
            this.MVmon.Name = "MVmon";
            this.MVmon.ReadOnly = true;
            this.MVmon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MVmon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MVmon.Width = 50;
            // 
            // MVg
            // 
            this.MVg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Format = "000";
            this.MVg.DefaultCellStyle = dataGridViewCellStyle9;
            this.MVg.HeaderText = "A [%]";
            this.MVg.Name = "MVg";
            this.MVg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MVg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MVg.Width = 50;
            // 
            // MVd
            // 
            dataGridViewCellStyle10.Format = "000";
            this.MVd.DefaultCellStyle = dataGridViewCellStyle10;
            this.MVd.HeaderText = "L[0.1s]";
            this.MVd.Name = "MVd";
            this.MVd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MVd.Width = 50;
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ToolStripStatusLabelTime
            // 
            this.ToolStripStatusLabelTime.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStripStatusLabelTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripStatusLabelTime.Name = "ToolStripStatusLabelTime";
            this.ToolStripStatusLabelTime.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel,
            this.toolStripStatusLabelError,
            this.ToolStripStatusLabelTime});
            this.StatusStrip.Location = new System.Drawing.Point(0, 539);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(932, 22);
            this.StatusStrip.TabIndex = 37;
            this.StatusStrip.Text = "StatusStrip1";
            // 
            // toolStripStatusLabelError
            // 
            this.toolStripStatusLabelError.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelError.Name = "toolStripStatusLabelError";
            this.toolStripStatusLabelError.Size = new System.Drawing.Size(0, 17);
            // 
            // SerialPort
            // 
            this.SerialPort.BaudRate = 115200;
            this.SerialPort.PortName = "COM4";
            this.SerialPort.ReadTimeout = 500;
            this.SerialPort.WriteTimeout = 500;
            // 
            // SamplingTimer
            // 
            this.SamplingTimer.Interval = 1000;
            this.SamplingTimer.Tick += new System.EventHandler(this.SamplingTimer_Tick);
            // 
            // PanelMonitor
            // 
            this.PanelMonitor.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMonitor.Controls.Add(this.lblMVScale25);
            this.PanelMonitor.Controls.Add(this.lblMVScale75);
            this.PanelMonitor.Controls.Add(this.PanelMVFrame);
            this.PanelMonitor.Controls.Add(this.PanelSVPVFrame);
            this.PanelMonitor.Controls.Add(this.LabelTime5);
            this.PanelMonitor.Controls.Add(this.LabelTime0);
            this.PanelMonitor.Controls.Add(this.LabelTime4);
            this.PanelMonitor.Controls.Add(this.LabelTimeUnit);
            this.PanelMonitor.Controls.Add(this.LabelTime3);
            this.PanelMonitor.Controls.Add(this.LabelTime2);
            this.PanelMonitor.Controls.Add(this.LabelTime1);
            this.PanelMonitor.Controls.Add(this.lblMVScale0);
            this.PanelMonitor.Controls.Add(this.lblTempScale0);
            this.PanelMonitor.Controls.Add(this.lblTempScale20);
            this.PanelMonitor.Controls.Add(this.lblTempScale40);
            this.PanelMonitor.Controls.Add(this.lblTempScale80);
            this.PanelMonitor.Controls.Add(this.lblTempScale60);
            this.PanelMonitor.Controls.Add(this.lblMVScale50);
            this.PanelMonitor.Controls.Add(this.lblMVScale100);
            this.PanelMonitor.Controls.Add(this.LabelMVunit);
            this.PanelMonitor.Controls.Add(this.LabelPVunit);
            this.PanelMonitor.Controls.Add(this.LabelSVunit);
            this.PanelMonitor.Location = new System.Drawing.Point(2, 3);
            this.PanelMonitor.Name = "PanelMonitor";
            this.PanelMonitor.Size = new System.Drawing.Size(640, 532);
            this.PanelMonitor.TabIndex = 68;
            // 
            // lblMVScale25
            // 
            this.lblMVScale25.Location = new System.Drawing.Point(0, 437);
            this.lblMVScale25.Margin = new System.Windows.Forms.Padding(1);
            this.lblMVScale25.Name = "lblMVScale25";
            this.lblMVScale25.Size = new System.Drawing.Size(25, 12);
            this.lblMVScale25.TabIndex = 59;
            this.lblMVScale25.Text = "25";
            this.lblMVScale25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMVScale75
            // 
            this.lblMVScale75.Location = new System.Drawing.Point(0, 367);
            this.lblMVScale75.Margin = new System.Windows.Forms.Padding(1);
            this.lblMVScale75.Name = "lblMVScale75";
            this.lblMVScale75.Size = new System.Drawing.Size(25, 12);
            this.lblMVScale75.TabIndex = 58;
            this.lblMVScale75.Text = "75";
            this.lblMVScale75.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PanelMVFrame
            // 
            this.PanelMVFrame.BackColor = System.Drawing.SystemColors.Control;
            this.PanelMVFrame.Controls.Add(this.PictureBoxMV);
            this.PanelMVFrame.Location = new System.Drawing.Point(27, 328);
            this.PanelMVFrame.Name = "PanelMVFrame";
            this.PanelMVFrame.Size = new System.Drawing.Size(601, 161);
            this.PanelMVFrame.TabIndex = 57;
            // 
            // PictureBoxMV
            // 
            this.PictureBoxMV.BackColor = System.Drawing.Color.Silver;
            this.PictureBoxMV.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxMV.Name = "PictureBoxMV";
            this.PictureBoxMV.Size = new System.Drawing.Size(70, 88);
            this.PictureBoxMV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxMV.TabIndex = 1;
            this.PictureBoxMV.TabStop = false;
            // 
            // PanelSVPVFrame
            // 
            this.PanelSVPVFrame.BackColor = System.Drawing.SystemColors.Control;
            this.PanelSVPVFrame.Controls.Add(this.PictureBoxSVPV);
            this.PanelSVPVFrame.Location = new System.Drawing.Point(27, 4);
            this.PanelSVPVFrame.Name = "PanelSVPVFrame";
            this.PanelSVPVFrame.Size = new System.Drawing.Size(601, 321);
            this.PanelSVPVFrame.TabIndex = 2;
            // 
            // PictureBoxSVPV
            // 
            this.PictureBoxSVPV.BackColor = System.Drawing.Color.Silver;
            this.PictureBoxSVPV.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxSVPV.Name = "PictureBoxSVPV";
            this.PictureBoxSVPV.Size = new System.Drawing.Size(70, 165);
            this.PictureBoxSVPV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxSVPV.TabIndex = 1;
            this.PictureBoxSVPV.TabStop = false;
            // 
            // LabelTime5
            // 
            this.LabelTime5.Location = new System.Drawing.Point(583, 493);
            this.LabelTime5.Margin = new System.Windows.Forms.Padding(1);
            this.LabelTime5.Name = "LabelTime5";
            this.LabelTime5.Size = new System.Drawing.Size(54, 12);
            this.LabelTime5.TabIndex = 55;
            this.LabelTime5.Text = "5120";
            this.LabelTime5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelTime0
            // 
            this.LabelTime0.Location = new System.Drawing.Point(1, 493);
            this.LabelTime0.Margin = new System.Windows.Forms.Padding(1);
            this.LabelTime0.Name = "LabelTime0";
            this.LabelTime0.Size = new System.Drawing.Size(54, 12);
            this.LabelTime0.TabIndex = 7;
            this.LabelTime0.Text = "0";
            this.LabelTime0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTime4
            // 
            this.LabelTime4.Location = new System.Drawing.Point(480, 493);
            this.LabelTime4.Margin = new System.Windows.Forms.Padding(1);
            this.LabelTime4.Name = "LabelTime4";
            this.LabelTime4.Size = new System.Drawing.Size(54, 12);
            this.LabelTime4.TabIndex = 54;
            this.LabelTime4.Text = "15552000";
            this.LabelTime4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTimeUnit
            // 
            this.LabelTimeUnit.Location = new System.Drawing.Point(303, 493);
            this.LabelTimeUnit.Margin = new System.Windows.Forms.Padding(1);
            this.LabelTimeUnit.Name = "LabelTimeUnit";
            this.LabelTimeUnit.Size = new System.Drawing.Size(45, 12);
            this.LabelTimeUnit.TabIndex = 25;
            this.LabelTimeUnit.Text = "[min]";
            this.LabelTimeUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTime3
            // 
            this.LabelTime3.Location = new System.Drawing.Point(360, 493);
            this.LabelTime3.Margin = new System.Windows.Forms.Padding(1);
            this.LabelTime3.Name = "LabelTime3";
            this.LabelTime3.Size = new System.Drawing.Size(54, 12);
            this.LabelTime3.TabIndex = 24;
            this.LabelTime3.Text = "0";
            this.LabelTime3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTime2
            // 
            this.LabelTime2.Location = new System.Drawing.Point(240, 493);
            this.LabelTime2.Margin = new System.Windows.Forms.Padding(1);
            this.LabelTime2.Name = "LabelTime2";
            this.LabelTime2.Size = new System.Drawing.Size(54, 12);
            this.LabelTime2.TabIndex = 23;
            this.LabelTime2.Text = "0";
            this.LabelTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTime1
            // 
            this.LabelTime1.Location = new System.Drawing.Point(120, 493);
            this.LabelTime1.Margin = new System.Windows.Forms.Padding(1);
            this.LabelTime1.Name = "LabelTime1";
            this.LabelTime1.Size = new System.Drawing.Size(54, 12);
            this.LabelTime1.TabIndex = 22;
            this.LabelTime1.Text = "0";
            this.LabelTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMVScale0
            // 
            this.lblMVScale0.Location = new System.Drawing.Point(0, 468);
            this.lblMVScale0.Margin = new System.Windows.Forms.Padding(1);
            this.lblMVScale0.Name = "lblMVScale0";
            this.lblMVScale0.Size = new System.Drawing.Size(25, 11);
            this.lblMVScale0.TabIndex = 14;
            this.lblMVScale0.Text = "0";
            this.lblMVScale0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTempScale0
            // 
            this.lblTempScale0.Location = new System.Drawing.Point(0, 243);
            this.lblTempScale0.Margin = new System.Windows.Forms.Padding(1);
            this.lblTempScale0.Name = "lblTempScale0";
            this.lblTempScale0.Size = new System.Drawing.Size(25, 12);
            this.lblTempScale0.TabIndex = 14;
            this.lblTempScale0.Text = "0";
            this.lblTempScale0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTempScale20
            // 
            this.lblTempScale20.Location = new System.Drawing.Point(0, 198);
            this.lblTempScale20.Margin = new System.Windows.Forms.Padding(1);
            this.lblTempScale20.Name = "lblTempScale20";
            this.lblTempScale20.Size = new System.Drawing.Size(25, 12);
            this.lblTempScale20.TabIndex = 14;
            this.lblTempScale20.Text = "20";
            this.lblTempScale20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTempScale40
            // 
            this.lblTempScale40.Location = new System.Drawing.Point(0, 148);
            this.lblTempScale40.Margin = new System.Windows.Forms.Padding(1);
            this.lblTempScale40.Name = "lblTempScale40";
            this.lblTempScale40.Size = new System.Drawing.Size(25, 12);
            this.lblTempScale40.TabIndex = 13;
            this.lblTempScale40.Text = "40";
            this.lblTempScale40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTempScale80
            // 
            this.lblTempScale80.Location = new System.Drawing.Point(0, 48);
            this.lblTempScale80.Margin = new System.Windows.Forms.Padding(1);
            this.lblTempScale80.Name = "lblTempScale80";
            this.lblTempScale80.Size = new System.Drawing.Size(25, 12);
            this.lblTempScale80.TabIndex = 13;
            this.lblTempScale80.Text = "80";
            this.lblTempScale80.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTempScale60
            // 
            this.lblTempScale60.Location = new System.Drawing.Point(0, 98);
            this.lblTempScale60.Margin = new System.Windows.Forms.Padding(1);
            this.lblTempScale60.Name = "lblTempScale60";
            this.lblTempScale60.Size = new System.Drawing.Size(25, 12);
            this.lblTempScale60.TabIndex = 13;
            this.lblTempScale60.Text = "60";
            this.lblTempScale60.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMVScale50
            // 
            this.lblMVScale50.Location = new System.Drawing.Point(0, 402);
            this.lblMVScale50.Margin = new System.Windows.Forms.Padding(1);
            this.lblMVScale50.Name = "lblMVScale50";
            this.lblMVScale50.Size = new System.Drawing.Size(25, 12);
            this.lblMVScale50.TabIndex = 12;
            this.lblMVScale50.Text = "50";
            this.lblMVScale50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMVScale100
            // 
            this.lblMVScale100.Location = new System.Drawing.Point(0, 330);
            this.lblMVScale100.Margin = new System.Windows.Forms.Padding(1);
            this.lblMVScale100.Name = "lblMVScale100";
            this.lblMVScale100.Size = new System.Drawing.Size(25, 12);
            this.lblMVScale100.TabIndex = 12;
            this.lblMVScale100.Text = "100";
            this.lblMVScale100.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelMVunit
            // 
            this.LabelMVunit.AutoSize = true;
            this.LabelMVunit.Location = new System.Drawing.Point(3, 382);
            this.LabelMVunit.Name = "LabelMVunit";
            this.LabelMVunit.Size = new System.Drawing.Size(22, 12);
            this.LabelMVunit.TabIndex = 3;
            this.LabelMVunit.Text = "MV";
            // 
            // LabelPVunit
            // 
            this.LabelPVunit.AutoSize = true;
            this.LabelPVunit.Location = new System.Drawing.Point(3, 32);
            this.LabelPVunit.Name = "LabelPVunit";
            this.LabelPVunit.Size = new System.Drawing.Size(20, 12);
            this.LabelPVunit.TabIndex = 3;
            this.LabelPVunit.Text = "PV";
            // 
            // LabelSVunit
            // 
            this.LabelSVunit.AutoSize = true;
            this.LabelSVunit.Location = new System.Drawing.Point(3, 20);
            this.LabelSVunit.Name = "LabelSVunit";
            this.LabelSVunit.Size = new System.Drawing.Size(20, 12);
            this.LabelSVunit.TabIndex = 3;
            this.LabelSVunit.Text = "SV";
            // 
            // TimerWait
            // 
            this.TimerWait.Interval = 10;
            this.TimerWait.Tick += new System.EventHandler(this.TimerWait_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 561);
            this.Controls.Add(this.PanelMonitor);
            this.Controls.Add(this.MonitorPanel);
            this.Controls.Add(this.StatusStrip);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MonitorPanel.ResumeLayout(false);
            this.TempMonitorPanel.ResumeLayout(false);
            this.TempMonitorPanel.PerformLayout();
            this.ParametersPanel.ResumeLayout(false);
            this.ParametersPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syncD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PidKp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PidKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PidKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncErrMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManualMV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempMonitor)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisturbanceInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisturbanceStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisturbanceVariable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataMonitor)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.PanelMonitor.ResumeLayout(false);
            this.PanelMonitor.PerformLayout();
            this.PanelMVFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMV)).EndInit();
            this.PanelSVPVFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSVPV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridViewTextBoxColumn MVcolum;
        internal System.Windows.Forms.DataGridViewTextBoxColumn PVcolum;
        internal System.Windows.Forms.Panel MonitorPanel;
        internal System.Windows.Forms.RadioButton RadioButtonIdle;
        internal System.Windows.Forms.RadioButton RadioButtonControl;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelTime;
        internal System.Windows.Forms.StatusStrip StatusStrip;
        internal System.IO.Ports.SerialPort SerialPort;
        internal System.Windows.Forms.Timer SamplingTimer;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog;
        internal System.Windows.Forms.RadioButton RadioButtonSync;
        internal System.Windows.Forms.Button ButtonSetParameters;
        internal System.Windows.Forms.RadioButton RadioButtonManual;
        internal System.Windows.Forms.Label LabelController;
        internal System.Windows.Forms.Panel PanelMonitor;
        internal System.Windows.Forms.Panel PanelMVFrame;
        internal System.Windows.Forms.PictureBox PictureBoxMV;
        internal System.Windows.Forms.Panel PanelSVPVFrame;
        internal System.Windows.Forms.PictureBox PictureBoxSVPV;
        internal System.Windows.Forms.Label LabelTime5;
        internal System.Windows.Forms.Label LabelTime0;
        internal System.Windows.Forms.Label LabelTime4;
        internal System.Windows.Forms.Label LabelTimeUnit;
        internal System.Windows.Forms.Label LabelTime3;
        internal System.Windows.Forms.Label LabelTime2;
        internal System.Windows.Forms.Label LabelTime1;
        internal System.Windows.Forms.Label lblMVScale0;
        internal System.Windows.Forms.Label lblTempScale20;
        internal System.Windows.Forms.Label lblTempScale40;
        internal System.Windows.Forms.Label lblTempScale80;
        internal System.Windows.Forms.Label lblTempScale60;
        internal System.Windows.Forms.Label lblMVScale50;
        internal System.Windows.Forms.Label lblMVScale100;
        internal System.Windows.Forms.Label LabelMVunit;
        internal System.Windows.Forms.Label LabelPVunit;
        internal System.Windows.Forms.Label LabelSVunit;
        internal System.Windows.Forms.Button ButtonRecord;
        internal System.Windows.Forms.Label lblTempScale0;
        internal System.Windows.Forms.Timer TimerWait;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelError;
        private System.Windows.Forms.Label PVdifference;
        private System.Windows.Forms.DataGridView DataMonitor;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown DisturbanceInterval;
        internal System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown DisturbanceStart;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Button DisturbanceApply;
        private System.Windows.Forms.RadioButton DisturbanceAuto;
        private System.Windows.Forms.RadioButton DisturbanceManual;
        private System.Windows.Forms.NumericUpDown DisturbanceVariable;
        internal System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel TempMonitorPanel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView TempMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label DVmon;
        private System.Windows.Forms.Label ModeMon;
        internal System.Windows.Forms.Label lblMVScale25;
        internal System.Windows.Forms.Label lblMVScale75;
        private System.Windows.Forms.Panel ParametersPanel;
        private System.Windows.Forms.CheckBox ChkLPF;
        private System.Windows.Forms.CheckBox ChkMVPol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown syncD;
        internal System.Windows.Forms.Label label25;
        internal System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown PidKp;
        private System.Windows.Forms.NumericUpDown PidKi;
        private System.Windows.Forms.NumericUpDown PidKd;
        private System.Windows.Forms.NumericUpDown syncM;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.NumericUpDown syncType;
        private System.Windows.Forms.NumericUpDown syncA;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        private System.Windows.Forms.NumericUpDown syncK;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown syncKi;
        private System.Windows.Forms.NumericUpDown syncErrMargin;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown ManualMV;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SVc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MVmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MVg;
        private System.Windows.Forms.DataGridViewTextBoxColumn MVd;
    }
}

