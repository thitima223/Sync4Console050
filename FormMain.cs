using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SyncConsole
{
    public partial class FormMain : Form
    {
        // -- monitor
        private Graphics Image_SVPV, Image_MV;
        private Bitmap Bitmap_SVPV, Bitmap_MV;
        private Color[] DataColor, TempColor;
        private const int SVPV_ROW = 9, MV_ROW = 9; //x graph
        private const int SVPV_ROW_HEIGHT = 80, MV_ROW_HEIGHT = 40;
        private const int SVPV_FS_HEIGHT = SVPV_ROW * SVPV_ROW_HEIGHT;  //80C
        //private const int SVPVFS_HEIGHT = 250;      // 100 ℃
        private const int MV_FS_HEIGHT = MV_ROW * MV_ROW_HEIGHT;      // 100%
        //private const int MVFS_HEIGHT = 50;      // 100%
        private const decimal SVPV_SCALE = (decimal)SVPV_FS_HEIGHT / 80, MV_SCALE = (decimal)MV_FS_HEIGHT / 100;
        private const int MONITOR_WIDTH = 600;       // 600 sec
        private const int MONITOR_OFFSET = 610;
        private const int MONITOR_PAGE_NUM = 10;
        private const int MONITOR_DATA_NUM = 3 * 24 * 60 * 60;   // 3days < 600sec * 2^9pages
        private int TimePosition;
        private int MonitorPageDisp;      // MonitorPageDisp：表示ページ
        private Label[] Label_Time, Label_TempScale, Label_MVScale;
        private const int GraphOffset = 5;

        // -- controller
        private const int AXIS_NUM = 9; // TEC 2x2 3x3
        private const int SENSOR_NUM = 6; // Temperature 6

        private const char CMD_READ = 'R';
        private const char CMD_PARAMETERS = 'V';
        private const char CMD_Idle = 'I';
        private const char CMD_Manual = 'M';
        private const char CMD_PID = 'P';
        private const char CMD_Sync = 'S';
        private const char CMD_AllCh = 'Z';

        private bool REQ_PARAMETERS, REQ_CONTROL_START, REQ_CONTROL_STOP;

        private const int MonitorGrid_Ch = 0;
        private const int MonitorGrid_SV = 1;
        private const int MonitorGrid_PV = 2;
        private const int MonitorGrid_MV = 3;
        private const int MonitorGrid_MVgain = 4;
        private const int MonitorGrid_MVderay = 5;
        private const int SensorGrid_T = 1;

        //private int[] SVcmd = new int[Constants.CONTROLLER_NUM];
        private NumericUpDown[] SVcmd, MVgain, MVdelay;
        private int[] SV = new int[AXIS_NUM], PV = new int[AXIS_NUM], K = new int[AXIS_NUM];
        //private int MODE;
        private double[] T = new double[SENSOR_NUM]; //int[] T = new int[SENSOR_NUM];
        private decimal[] SVdeg = new decimal[AXIS_NUM], PVdeg = new decimal[AXIS_NUM], MV = new decimal[AXIS_NUM], Tdeg = new decimal[SENSOR_NUM];
        private decimal[] MonMVkura = new decimal[AXIS_NUM], MonMVp = new decimal[AXIS_NUM], MonMVi = new decimal[AXIS_NUM], MonMVd = new decimal[AXIS_NUM];
        //private NumericUpDown[] ;
        private string Parameters;

        public decimal[] TCp1 = new decimal[AXIS_NUM + SENSOR_NUM], TCp0 = new decimal[AXIS_NUM + SENSOR_NUM];

        private int DV;
        private int DisturbStartCounter, DisturbIntervalCounter;

        // -- system
        private string AppTitle;
        private Color Ready = Color.Cyan, NotReady = Color.Gray, Active = Color.Cyan, InActive = SystemColors.Control, CommGood = Color.GreenYellow, CommErr = Color.Red;

        // -- file
        private StreamWriter DataFile;
        private const string CAL_FILE_NAME = "SYNC4_050.csv";
        private const string INI_FILE_NAME = "SYNC4_050.ini";
        private const int INI_FILE_TAB = 9;

        // -- program
        //private bool F_ProgramRun;

        public FormMain()
        {
            InitializeComponent();
        }

        //-- サンプリングタイマ処理 ---------------------------------------------------------------
        private void SamplingTimer_Tick(object sender, EventArgs e)
        {
            int i;

            // -- data read ----------------------------------------------
            if (DisturbStartCounter > 0)
            {
                DisturbStartCounter -= 1;
                if (DisturbStartCounter == 0)
                {
                    DisturbIntervalCounter = (int)DisturbanceInterval.Value;
                    DV = (int)DisturbanceVariable.Value;
                }
            }
            if (DisturbIntervalCounter > 0)
            {
                DisturbIntervalCounter -= 1;
                if (DisturbIntervalCounter == 0)
                {
                    DV = 0;
                }
            }
            bool commState = readPVMV();

            // -- write parameters ---------------------------------------
            if (commState && REQ_PARAMETERS)
            {
                if (writeParameters())
                {
                    LabelController.BackColor = Ready;
                    RadioButtonControl.Enabled = true;
                }
                REQ_PARAMETERS = false;
            }

            // -- write control start ------------------------------------
            if (commState && REQ_CONTROL_START)
            {
                if (writeControlStart())
                {
                    REQ_CONTROL_START = false;
                }
            }

            // -- write control stop -------------------------------------
            if (commState && REQ_CONTROL_STOP)
            {
                if (writeControlStop())
                {
                    parameterChangeEnable(true);
                }
            }

            // -- data print/draw ----------------------------------------
            if (commState)
            {
                // -- print data
                for (i = 0; i < AXIS_NUM; i++)
                {
                    DataMonitor.Rows[i].Cells[MonitorGrid_PV].Value = PVdeg[i];
                    DataMonitor.Rows[i].Cells[MonitorGrid_MV].Value = MV[i];
                }
                PVdifference.Text = string.Format("{0}", (PVdeg.Max() - PVdeg.Min()).ToString("00.00;;"));
                for (i = 0; i < SENSOR_NUM; i++)
                {
                    TempMonitor.Rows[i].Cells[SensorGrid_T].Value = Tdeg[i];
                }
                // -- draw data
                if (TimePosition > MONITOR_WIDTH * Math.Pow(2, MonitorPageDisp))
                {
                    MonitorPageDisp++;
                    PictureBoxSVPV.Left = -MONITOR_OFFSET * MonitorPageDisp;
                    PictureBoxMV.Left = PictureBoxSVPV.Left;
                    dispTimeUnit();
                }
                drawMonitorPage();
            }

            // -- save data
            if (ButtonRecord.BackColor == Active)
            {
                try
                {
                    string saveData = DateTime.Now + ",";
                    if (commState)
                    {
                        saveData += ModeMon.Text + ",";
                        for (i = 0; i < AXIS_NUM; i++)
                            saveData += SVdeg[i] + ",";
                        for (i = 0; i < AXIS_NUM; i++)
                            saveData += PVdeg[i] + ",";
                        for (i = 0; i < AXIS_NUM; i++)
                            saveData += MV[i] + ",";
                        saveData += DVmon.Text + ",";
                        for (i = 0; i < AXIS_NUM; i++)
                            saveData += K[i] + ",";
                        for (i = 0; i < AXIS_NUM; i++)
                            saveData += MonMVkura[i] + ",";
                        for (i = 0; i < AXIS_NUM; i++)
                            saveData += MonMVp[i] + ",";
                        for (i = 0; i < AXIS_NUM; i++)
                            saveData += MonMVi[i] + ",";
                        for (i = 0; i < AXIS_NUM; i++)
                            saveData += MonMVd[i] + ",";
                        for (i = 0; i < SENSOR_NUM; i++)
                            saveData += Tdeg[i] + ",";
                        for (i = 0; i < AXIS_NUM; i++)
                            saveData += SV[i] + ",";
                        for (i = 0; i < AXIS_NUM; i++)
                            saveData += PV[i] + ",";
                        for (i = 0; i < SENSOR_NUM; i++)
                            saveData += T[i] + ",";
                    }
                    else
                    {
                        for (i = 0; i < AXIS_NUM * 10 + SENSOR_NUM * 2 + 1 ; i++)
                            saveData += "--,";
                    }
                    saveData += commState;
                    DataFile.WriteLine(saveData);
                }
                catch (Exception)
                {
                }
            }

            // -- increment TimePosition ---------------------------------
            if (TimePosition > MONITOR_DATA_NUM)
            {
                SamplingTimer.Enabled = false;
                MessageBox.Show("記録データ数の上限に達しました．リセットします．", AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (DataFile != null)
                    DataFile.Close();
                resetPage();
                SamplingTimer.Enabled = true;
            }
            else
                TimePosition++;
            ToolStripStatusLabelTime.Text = DateTime.Now.ToString();

        }

        //-- PVMV読込処理 -----------------------------------------------------------------------
        private bool readPVMV()
        {
            const int TRANS_DATA_NUM = 125; 
            const int RECV_DATA_NUM = 161; // data 17+(16x9) = 161byte (81)
            byte[] trans = new byte[TRANS_DATA_NUM], recv = new byte[RECV_DATA_NUM], data = new byte[4];
            int i;

            try
            {
                if (SerialPort.IsOpen == false)
                    SerialPort.Open();
                trans[0] = (byte)CMD_READ;
                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", (DV + 100).ToString("000;;")));
                Array.Copy(data, 0, trans, 1, 3);
                trans[TRANS_DATA_NUM - 1] = (byte)'\r';
                SerialPort.Write(trans, 0, 3);
                SerialPort.Write("\n");
                SerialPort.Read(recv, 0, 1);
                SerialPort.Write(trans, 3, 2);
                while (SerialPort.BytesToRead < RECV_DATA_NUM)
                {
                    Application.DoEvents();
                }
                SerialPort.Read(recv, 0, RECV_DATA_NUM);
                if ((recv[0] != trans[0]) || (recv[RECV_DATA_NUM - 1] != trans[TRANS_DATA_NUM - 1]))
                {
                    toolStripStatusLabelError.Text = "通信データ異常";
                    throw new FormatException();
                }
                ModeMon.Text = ((char)recv[1]).ToString();
                for (i = 0; i < AXIS_NUM; i++) // shift data
                {
                    SV[i] = recv[i * 2 + 2] * 256 + recv[i * 2 + 3];
                    SVdeg[i] = SV[i] * TCp1[i] + TCp0[i];
                    PV[i] = recv[i * 2 + 20] * 256 + recv[i * 2 + 21]; //10,11
                    PVdeg[i] = PV[i] * TCp1[i] + TCp0[i];
                    MV[i] = (recv[i * 2 + 38] * 256 + recv[i * 2 + 39]); //18,19
                    if (MV[i] > 0x8000) MV[i] -= 0x10000;
                    MV[i] /= 10;
                    K[i] = recv[i * 2 + 56] * 256 + recv[i * 2 + 57]; //26,27
                    MonMVkura[i] = (recv[i * 2 + 74] * 256 + recv[i * 2 + 75]); //34,35
                    if (MonMVkura[i] > 0x8000) MonMVkura[i] -= 0x10000;
                    MonMVkura[i] /= 10;
                    MonMVp[i] = (recv[i * 2 + 92] * 256 + recv[i * 2 + 93]); //43,43
                    if (MonMVp[i] > 0x8000) MonMVp[i] -= 0x10000;
                    MonMVp[i] /= 10;
                    MonMVi[i] = (recv[i * 2 + 110] * 256 + recv[i * 2 + 111]); //50,51
                    if (MonMVi[i] > 0x8000) MonMVi[i] -= 0x10000;
                    MonMVi[i] /= 10;
                    MonMVd[i] = (recv[i * 2 + 128] * 256 + recv[i * 2 + 129]); //58,59
                    if (MonMVd[i] > 0x8000) MonMVd[i] -= 0x10000;
                    MonMVd[i] /= 10;
                }
                int dv_raw = recv[146] * 256 + recv[147]; // Index = 2(Header)+(8datatype*9tec*2byte) = 146
                DVmon.Text = (recv[146] * 256 + recv[147] - 100).ToString(); // 2+(16x9) = 146 recv[66,67]
                //DVmon.Text = (dv_raw - 100).ToString();
                for (i = 0; i < SENSOR_NUM; i++)
                {
                    //T[i] = recv[i * 2 + 148] * 256 + recv[i * 2 + 149]; //68,69
                    T[i] = (double)(short)(recv[i * 2 + 148] * 256 + recv[i * 2 + 149]) / 10;
                    Tdeg[i] = (decimal)T[i] * TCp1[i + AXIS_NUM] + TCp0[i + AXIS_NUM]; //T[i]
                }
                if (SerialPort.IsOpen == true)
                    SerialPort.Close();
                ToolStripStatusLabel.BackColor = CommGood;
                ToolStripStatusLabel.Text = "Comm state Good";
                toolStripStatusLabelError.Text = "";
                return true;
            }
            catch (Exception)
            {
                ToolStripStatusLabel.BackColor = CommErr;
                ToolStripStatusLabel.Text = "Comm state Bad";
                return false;
            }
        }

        //-- パラメータ書込処理 -------------------------------------------------------------------
        private bool writeParameters()
        {
            const int TRANS_DATA_NUM = 125; //75
            byte[] trans = new byte[TRANS_DATA_NUM], recv = new byte[2], data = new byte[4];
            int i;

            try
            {
                if (SerialPort.IsOpen == false)
                    SerialPort.Open();
                trans[0] = (byte)CMD_PARAMETERS;
                for (i = 0; i < AXIS_NUM; i++)
                {

                    data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", ((SVcmd[i].Value - TCp0[i]) / TCp1[i]).ToString("0000;;"))); // SV keep 4 byte/tec start index 1 [cite: 99]
                    Array.Copy(data, 0, trans, i * 4 + 1, 4);
                    data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", MVgain[i].Value.ToString("000;;")));// MV Gain keep 3 byte/sheet start to SV (1 + 4*9 = 37) [cite: 100]
                    Array.Copy(data, 0, trans, i * 3 + 37, 3);
                    data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", MVdelay[i].Value.ToString("000;;"))); // MV Delay keep 3 byte/sheet start to Gain (37 + 3*9 = 64) [cite: 101]
                    Array.Copy(data, 0, trans, i * 3 + 64, 3);
                }
                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", (ManualMV.Value + 100).ToString("000;;"))); // 3.center data (start at index 91 cause 64 + (3*9) = 91) [cite: 102]
            Array.Copy(data, 0, trans, 91, 3);
                Parameters = "ManualMV:" + ManualMV.Value;

                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", PidKp.Value.ToString("000;;"))); //[cite: 103]
                Array.Copy(data, 0, trans, 94, 3);
                Parameters += " PidKp:" + PidKp.Value;

                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", PidKi.Value.ToString("000;;"))); //[cite: 104]
                Array.Copy(data, 0, trans, 97, 3);
                Parameters += " PidKi:" + PidKi.Value;

                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", PidKd.Value.ToString("000;;"))); //[cite: 105]
                Array.Copy(data, 0, trans, 100, 3);
                Parameters += " PidKd:" + PidKd.Value;

                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", syncType.Value.ToString("0;;"))); //[cite: 106]
                Array.Copy(data, 0, trans, 103, 1);
                Parameters += " SyncType:" + syncType.Value;

                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", syncK.Value.ToString("000;;"))); //[cite: 107]
                Array.Copy(data, 0, trans, 104, 3);
                Parameters += " SyncK:" + syncK.Value;
   
                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", syncD.Value.ToString("000;;"))); //[cite: 108]
                Array.Copy(data, 0, trans, 107, 3);
                Parameters += " SyncD:" + syncD.Value;

                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", syncA.Value.ToString("000;;"))); //[cite: 109]
                Array.Copy(data, 0, trans, 110, 3);
                Parameters += " SyncA:" + syncA.Value;

                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", syncM.Value.ToString("000;;"))); //[cite: 110]
                Array.Copy(data, 0, trans, 113, 3);
                Parameters += " SyncM:" + syncM.Value;

                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", syncKi.Value.ToString("000;;"))); //[cite: 111]
                Array.Copy(data, 0, trans, 116, 3);
                Parameters += " SyncKi:" + syncKi.Value;

                data = Encoding.GetEncoding("Shift_JIS").GetBytes(String.Format("{0}", syncErrMargin.Value.ToString("000;;"))); //[cite: 112]
                Array.Copy(data, 0, trans, 119, 3);
                Parameters += " SyncErrMargin:" + syncErrMargin.Value; //[cite: 113]

       
                if (ChkMVPol.Checked) // 4.controll last bit
                    trans[122] = (byte)'1'; //72
                else //[cite: 114]
                    trans[122] = (byte)'0';

                if (ChkLPF.Checked) //[cite: 115]
                    trans[123] = (byte)'1';
                else //[cite: 116]
                    trans[123] = (byte)'0';

                trans[124] = (byte)'\r';

                int step = 3; //[cite: 117]
                i = 0;
                while (i < TRANS_DATA_NUM) //[cite: 118]
                {
                    if (TRANS_DATA_NUM - i < step)
                        step = TRANS_DATA_NUM - i;
                    SerialPort.Write(trans, i, step); //[cite: 119]
                    if (i + step < TRANS_DATA_NUM) {
                        SerialPort.Write("\n");
                        SerialPort.Read(recv, 0, 1); //[cite: 120]
                        if (recv[0] != '\n') {
                            toolStripStatusLabelError.Text = "通信データ異常";
                            throw new FormatException(); //[cite: 121]
                        }
                    }
                    i += step;
                }
                while (SerialPort.BytesToRead < 2) //[cite: 122]
                {
                    Application.DoEvents(); //[cite: 123]
                }
                SerialPort.Read(recv, 0, 2);
                if ((recv[0] != trans[0]) || (recv[1] != trans[TRANS_DATA_NUM - 1])) //[cite: 124]
                {
                    toolStripStatusLabelError.Text = "通信データ異常";
                    throw new FormatException(); //[cite: 125]
                }
                
                if (SerialPort.IsOpen == true)
                    SerialPort.Close();
                return true; //[cite: 126]
            }
            catch (Exception)
            {
                ToolStripStatusLabel.BackColor = CommErr;
                ToolStripStatusLabel.Text = "Comm state Bad"; //[cite: 127]
                return false;
            }
        }

        //-- 制御開始書込処理 ---------------------------------------------------------------------------
        private bool writeControlStart()
        {
            byte[] trans = new byte[11], recv = new byte[11];

            try
            {
                if (SerialPort.IsOpen == false)
                    SerialPort.Open();
                if (RadioButtonManual.Checked == true)
                {
                    trans[0] = (byte)CMD_Manual;
                }
                //else if (RadioButtonPID.Checked == true)
                //{
                //    trans[0] = (byte)CMD_PID;
                //}
                else
                {
                    trans[0] = (byte)CMD_Sync;
                }
                trans[1] = (byte)'\r';
                SerialPort.Write(trans, 0, 2);
                
                while (SerialPort.BytesToRead < 2)
                {
                    Application.DoEvents();
                }
                SerialPort.Read(recv, 0, 2);
                if ((recv[0] != trans[0]) || (recv[1] != trans[1]))
                {
                    toolStripStatusLabelError.Text = "通信データ異常";
                    throw new FormatException();
                }

                if (SerialPort.IsOpen == true)
                    SerialPort.Close();
                return true;
            }
            catch (Exception)
            {
                ToolStripStatusLabel.BackColor = CommErr;
                ToolStripStatusLabel.Text = "Comm state Bad";
                return false;
            }

        }

        //-- 制御停止書込処理 ---------------------------------------------------------------------------
        private bool writeControlStop()
        {
            byte[] trans = new byte[11], recv = new byte[11];

            try
            {
                if (SerialPort.IsOpen == false)
                    SerialPort.Open();
                trans[0] = (byte)CMD_Idle;
                trans[1] = (byte)'\r';
                SerialPort.Write(trans, 0, 2);

                while (SerialPort.BytesToRead < 2)
                {
                    Application.DoEvents();
                }
                SerialPort.Read(recv, 0, 2);
                if ((recv[0] != trans[0]) || (recv[1] != trans[1]))
                {
                    toolStripStatusLabelError.Text = "通信データ異常";
                    throw new FormatException();
                }

                if (SerialPort.IsOpen == true)
                    SerialPort.Close();
                return true;
            }
            catch (Exception)
            {
                ToolStripStatusLabel.BackColor = CommErr;
                ToolStripStatusLabel.Text = "Comm state Bad";
                return false;
            }

        }

        //-- タイムアウト処理 ---------------------------------------------------------------------
        private void TimerWait_Tick(object sender, EventArgs e)
        {
            TimerWait.Enabled = false;
        }

        //-- メインフォーム：ロード処理 -----------------------------------------------------------
        private void FormMain_Load(object sender, EventArgs e)
        {
            AppTitle = Application.ProductName + " " + Application.ProductVersion;
            this.Text = AppTitle;

            initObject();
            loadSystemSettings();
            LabelController.BackColor = NotReady;

            SerialPort.NewLine = "\r";

            REQ_CONTROL_STOP = true;

            SamplingTimer.Enabled = true;

            //// SVverify = False

            //F_ProgramSet = false;
            //F_ProgramRun = false;
            //mnuProgramRun.Enabled = false;
            //PrgStepNum = 0;
            //PrgStart = 1;
            //PrgStop = 1;
            //PrgRepeat = false;
        }

        private void loadSystemSettings()
        {
            StreamReader dataFile = StreamReader.Null;
            // TC cal. data
            try
            {
                dataFile = new StreamReader(Path.Combine(Application.StartupPath, CAL_FILE_NAME), Encoding.Default);
                string[] cols;
                for (int i = 0; i < AXIS_NUM + SENSOR_NUM; i++)
                {
                    string line1 = dataFile.ReadLine();
                    string line2 = dataFile.ReadLine();

                    if (line1 == null || line2 == null)
                    {
                        MessageBox.Show(
                            $"キャリブレーションファイルのデータが不足しています。(行 {i * 2 + 1})",//if have error massage ex.行 21 it mean can read 20 line 10 channel and end (well we can edit error in .csv add more channel for keep more data)
                            AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        return;
                    }
                    cols = line1.Split(',');
                    TCp1[i] = decimal.Parse(cols[1]);
                    cols = line2.Split(',');
                    TCp0[i] = decimal.Parse(cols[1]);
                    /*cols = dataFile.ReadLine().Split(',');
                    TCp1[i] = decimal.Parse(cols[1]);
                    cols = dataFile.ReadLine().Split(',');
                    TCp0[i] = decimal.Parse(cols[1]);*/
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                if (dataFile != null)
                    dataFile.Close();
            }
            // parameters
            try
            {
                dataFile = new StreamReader(Path.Combine(Application.StartupPath, INI_FILE_NAME), Encoding.Default);
                SerialPort.PortName = dataFile.ReadLine().Substring(INI_FILE_TAB);
                for (int i = 0; i < AXIS_NUM; i++)
                {
                    SVcmd[i].Value= int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                    MVgain[i].Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                    MVdelay[i].Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                }
                ChkLPF.Checked = bool.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                ChkMVPol.Checked = bool.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                ManualMV.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                PidKp.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                PidKi.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                PidKd.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                syncType.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                syncK.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                syncD.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                syncA.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                syncM.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                syncKi.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                syncErrMargin.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                DisturbanceVariable.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                DisturbanceAuto.Checked = bool.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                DisturbanceStart.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
                DisturbanceInterval.Value = int.Parse(dataFile.ReadLine().Substring(INI_FILE_TAB));
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                if (dataFile != null)
                    dataFile.Close();
                SetManualMin();
                AlgorismSelect();
            }
        }

        //-- メインフォーム：クローズ処理 ---------------------------------------------------------
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("終了します", "終了確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
                e.Cancel = true;// Ending , Completion confirmation
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter dataFile = StreamWriter.Null;

            try
            {
                dataFile = new StreamWriter(Path.Combine(Application.StartupPath, INI_FILE_NAME));
                dataFile.WriteLine("portName " + SerialPort.PortName);
                for (int i = 0; i < AXIS_NUM; i++)
                {
                    dataFile.WriteLine("SV" + String.Format("{0:00}", i) + "     " + SVcmd[i].Value);
                    dataFile.WriteLine("Ch" + String.Format("{0:00}", i) + "MVg  " + MVgain[i].Value);
                    dataFile.WriteLine("Ch" + String.Format("{0:00}", i) + "MVd  " + MVdelay[i].Value);
                }
                dataFile.WriteLine("LPF      " + ChkLPF.Checked);
                dataFile.WriteLine("MVPol    " + ChkMVPol.Checked);
                dataFile.WriteLine("Manual   " + ManualMV.Value);
                dataFile.WriteLine("Kp       " + PidKp.Value);
                dataFile.WriteLine("Ki       " + PidKi.Value);
                dataFile.WriteLine("Kd       " + PidKd.Value);
                dataFile.WriteLine("syncType " + syncType.Value);
                dataFile.WriteLine("syncK    " + syncK.Value);
                dataFile.WriteLine("syncD    " + syncD.Value);
                dataFile.WriteLine("syncA    " + syncA.Value);
                dataFile.WriteLine("syncM    " + syncM.Value);
                dataFile.WriteLine("syncKi   " + syncKi.Value);
                dataFile.WriteLine("syncEM   " + syncErrMargin.Value);
                dataFile.WriteLine("DstbVari " + DisturbanceVariable.Value);
                dataFile.WriteLine("DstbAuto " + DisturbanceAuto.Checked);
                dataFile.WriteLine("DstbStart" + DisturbanceStart.Value);
                dataFile.WriteLine("DstbItvl " + DisturbanceInterval.Value);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dataFile != null)
                    dataFile.Close();
                Environment.Exit(0);
            }
        }

        //-- 初期化処理 ---------------------------------------------------------------------------
        private void initObject()
        {
            int i;

            PanelSVPVFrame.Height = SVPV_ROW * SVPV_ROW_HEIGHT + 1;
            initPicBox(ref PictureBoxSVPV, PanelSVPVFrame, ref Bitmap_SVPV, ref Image_SVPV);
            PanelMVFrame.Top = PanelSVPVFrame.Top + PanelSVPVFrame.Height + 5;
            PanelMVFrame.Height = MV_ROW * MV_ROW_HEIGHT + 1;
            initPicBox(ref PictureBoxMV, PanelMVFrame, ref Bitmap_MV, ref Image_MV);

            //SVcmd = new NumericUpDown[] { SVcmd1_, SVcmd2_, SVcmd3_, SVcmd4_ };
            DataColor = new Color[] { Color.Red, Color.LimeGreen, Color.Yellow, Color.DodgerBlue, Color.Magenta, Color.Orange, Color.Pink, Color.LightSkyBlue, Color.Gold }; //addon
            TempColor = new Color[] { Color.Pink, Color.GreenYellow, Color.LightYellow, Color.LightBlue, Color.Lavender, Color.White };
            Label_Time = new Label[] { LabelTime0, LabelTime1, LabelTime2, LabelTime3, LabelTime4, LabelTime5 };
            Label_TempScale = new Label[] { lblTempScale0, lblTempScale20, lblTempScale40, lblTempScale60, lblTempScale80 };
            Label_MVScale = new Label[] { lblMVScale0, lblMVScale25, lblMVScale50, lblMVScale75, lblMVScale100 };
            LabelTimeUnit.Top = PanelMVFrame.Top + PanelMVFrame.Height + 5;
            for (i = 0; i < Label_Time.Length; i++)
                Label_Time[i].Top = LabelTimeUnit.Top;
            for (i = 0; i < Label_TempScale.Length; i++)
            {
                Label_TempScale[i].Top = PanelSVPVFrame.Top + PanelSVPVFrame.Height - SVPV_ROW_HEIGHT * i;
                if (i != Label_TempScale.Length - 1)
                    Label_TempScale[i].Top -= 10;
            }
            LabelSVunit.Top = (Label_TempScale[2].Top + Label_TempScale[3].Top) / 2 - LabelSVunit.Height / 2;
            LabelPVunit.Top = LabelSVunit.Top + LabelSVunit.Height;
            for (i = 0; i < Label_MVScale.Length; i++)
            {
                Label_MVScale[i].Top = PanelMVFrame.Top + PanelMVFrame.Height - MV_ROW_HEIGHT * i;
                if (i != Label_MVScale.Length - 1)
                    Label_MVScale[i].Top -= 10;
            }
            LabelMVunit.Top = (Label_MVScale[2].Top + Label_MVScale[3].Top) / 2;


            //Ready = Color.LimeGreen;
            //NotReady = Color.Gray;

            ButtonRecord.BackColor = InActive;

            DataMonitor.RowCount = AXIS_NUM;
            for (i = 0; i < AXIS_NUM; i++)
            {
                DataMonitor.Rows[i].Cells[MonitorGrid_Ch].Style.BackColor = DataColor[i];
                DataMonitor.Rows[i].Cells[MonitorGrid_Ch].Value = i + 1;
            }
            DataMonitor.ClearSelection();
            DataMonitor.Width = DataMonitor.Columns[0].Width + 2;
            for (i = 1; i < DataMonitor.Columns.Count; i++)
                DataMonitor.Width += DataMonitor.Columns[i].Width;
            DataMonitor.Height = DataMonitor.ColumnHeadersHeight + DataMonitor.Rows[1].Height * AXIS_NUM;

            SVcmd = new NumericUpDown[AXIS_NUM];
            MVgain = new NumericUpDown[AXIS_NUM];
            MVdelay = new NumericUpDown[AXIS_NUM];
            SuspendLayout();
            for (i = 0; i < AXIS_NUM; i++)
            {
                SVcmd[i] = new NumericUpDown();
                SVcmd[i].Maximum = 70;
                SVcmd[i].Name = "SVcmd" + i.ToString();
                SVcmd[i].Size = new Size(45, 15);
                SVcmd[i].BorderStyle = BorderStyle.None;
                SVcmd[i].TextAlign = HorizontalAlignment.Center;
                SVcmd[i].Location = new Point(DataMonitor.Left + DataMonitor.Width - DataMonitor.Columns[4].Width * 5 + 2, DataMonitor.Top + DataMonitor.ColumnHeadersHeight + 3 + DataMonitor.Rows[1].Height * i);
                SVcmd[i].ValueChanged += new EventHandler(Parameter_Change);
                MonitorPanel.Controls.Add(SVcmd[i]);
                SVcmd[i].BringToFront();

                MVgain[i] = new NumericUpDown();
                MVgain[i].Maximum = 100;
                MVgain[i].Name = "MVgain" + i.ToString();
                MVgain[i].Size = new Size(45, 15);
                MVgain[i].BorderStyle = BorderStyle.None;
                MVgain[i].TextAlign = HorizontalAlignment.Center;
                MVgain[i].Location = new Point(DataMonitor.Left + DataMonitor.Width - DataMonitor.Columns[4].Width * 2 + 2, DataMonitor.Top + DataMonitor.ColumnHeadersHeight + 3 + DataMonitor.Rows[1].Height * i);
                MVgain[i].ValueChanged += new EventHandler(Parameter_Change);
                MonitorPanel.Controls.Add(MVgain[i]);
                MVgain[i].BringToFront();

                MVdelay[i] = new NumericUpDown();
                MVdelay[i].Maximum = 100;
                MVdelay[i].Name = "MVdelay" + i.ToString();
                MVdelay[i].Size = new Size(45, 15);
                MVdelay[i].BorderStyle = BorderStyle.None;
                MVdelay[i].TextAlign = HorizontalAlignment.Center;
                MVdelay[i].Location = new Point(DataMonitor.Left + DataMonitor.Width - DataMonitor.Columns[4].Width + 2, DataMonitor.Top + DataMonitor.ColumnHeadersHeight + 3 + DataMonitor.Rows[1].Height * i);
                MVdelay[i].ValueChanged += new EventHandler(Parameter_Change);
                MonitorPanel.Controls.Add(MVdelay[i]);
                MVdelay[i].BringToFront();
            }
            ResumeLayout(false);

            TempMonitorPanel.Top = DataMonitor.Top + DataMonitor.Height + 2;
            PVdifference.Left = DataMonitor.Left + DataMonitor.Columns[0].Width + 1;

            TempMonitor.RowCount = SENSOR_NUM;
            for (i = 0; i < SENSOR_NUM; i++)
            {
                TempMonitor.Rows[i].Cells[MonitorGrid_Ch].Style.BackColor = TempColor[i];
                TempMonitor.Rows[i].Cells[MonitorGrid_Ch].Value = (char)((int)'A' + i);
            }
            TempMonitor.ClearSelection();
            TempMonitor.Width = TempMonitor.Columns[0].Width + TempMonitor.Columns[1].Width + 2;
            TempMonitor.Height = TempMonitor.ColumnHeadersHeight + TempMonitor.Rows[1].Height * SENSOR_NUM;

            ControlPanel.Top = TempMonitorPanel.Top + TempMonitorPanel.Height + 2;

            DisturbanceApply.Enabled = false;

            resetPage();

            REQ_PARAMETERS = false;

            //SyncMode = SYNC.OFF;
        }

        private void initPicBox(ref PictureBox picBox, Panel frame, ref Bitmap bitmap, ref Graphics image)
        {
            picBox.Height = frame.Height;
            picBox.Width = MONITOR_OFFSET * MONITOR_PAGE_NUM + 1;
            bitmap = new Bitmap(picBox.Width, picBox.Height);
            image = Graphics.FromImage(bitmap);
            image.SmoothingMode = SmoothingMode.AntiAlias;
        }

        //-- モニタ描画処理 -----------------------------------------------------------------------
        private void drawMonitorPage()
        {
            int i, page;
            Pen pen = new Pen(Color.Gray);

            for (page = 0; page <= MONITOR_PAGE_NUM - 1; page++)
            {
                if (TimePosition <= MONITOR_WIDTH * Math.Pow(2, page))
                {
                    for (i = 0; i < SENSOR_NUM; i++)
                    {
                        pen.Color = TempColor[i];
                        Image_SVPV.DrawEllipse(pen, (int)(TimePosition / (Math.Pow(2, page))) + page * MONITOR_OFFSET, SVPV_FS_HEIGHT - (int)(((decimal)T[i] * TCp1[i + AXIS_NUM] + TCp0[i + AXIS_NUM]) * SVPV_SCALE), 1, 1);
                    }
                    for (i = 0; i < AXIS_NUM; i++)
                    {
                        pen.Color = DataColor[i];
                        Image_SVPV.DrawEllipse(pen, (int)(TimePosition / (Math.Pow(2, page))) + page * MONITOR_OFFSET, SVPV_FS_HEIGHT - (int)((SV[i] * TCp1[i] + TCp0[i]) * SVPV_SCALE), 1, 1);
                        Image_SVPV.DrawEllipse(pen, (int)(TimePosition / (Math.Pow(2, page))) + page * MONITOR_OFFSET, SVPV_FS_HEIGHT - (int)((PV[i] * TCp1[i] + TCp0[i]) * SVPV_SCALE), 1, 1);
                        Image_MV.DrawEllipse(pen, (int)(TimePosition / (Math.Pow(2, page))) + page * MONITOR_OFFSET, MV_FS_HEIGHT - (int)(MV[i] * MV_SCALE), 1, 1);
                    }
                    pen.Color = Color.DarkOrange;
                    Image_SVPV.DrawEllipse(pen, (int)(TimePosition / (Math.Pow(2, page))) + page * MONITOR_OFFSET, SVPV_FS_HEIGHT - (int)((PVdeg.Max() - PVdeg.Min()) * SVPV_SCALE * 10), 1, 1);
                }
            }

            PictureBoxSVPV.Image = Bitmap_SVPV;
            PictureBoxMV.Image = Bitmap_MV;
        }

        //-- モニタクリア処理 ---------------------------------------------------------------------
        private void clearMonitor()
        {
            drawScale(ref PictureBoxSVPV, ref Bitmap_SVPV, ref Image_SVPV, SVPV_ROW, SVPV_ROW_HEIGHT);
            drawScale(ref PictureBoxMV, ref Bitmap_MV, ref Image_MV, MV_ROW, MV_ROW_HEIGHT);
            dispTimeUnit();
        }

        private void drawScale(ref PictureBox picBox, ref Bitmap bitmap, ref Graphics image, int row, int rowHeight)
        {
            Pen pen = new Pen(Color.Gray);
            int i, j;

            image.Clear(Color.Silver);
            // Y axis
            for (i = 0; i <= row; i++)
                image.DrawLine(pen, 0, i * rowHeight, picBox.Width, i * rowHeight);
            // Time
            for (j = 0; j <= 9; j++)
            {
                for (i = 0; i <= 5; i++)
                    image.DrawLine(pen, i * 120 + j * MONITOR_OFFSET, 0, i * 120 + j * MONITOR_OFFSET, picBox.Height);
            }

            picBox.Image = bitmap;
        }

        //-- モニタリセット処理 -------------------------------------------------------------------
        private void resetPage()
        {
            TimePosition = 0;
            MonitorPageDisp = 0;
            PictureBoxSVPV.Left = 0;
            PictureBoxMV.Left = 0;
            clearMonitor();
        }

        //-- モニタ時間軸ラベル更新処理 -----------------------------------------------------------       
        private void dispTimeUnit()
        {
            for (int i = 1; i <= 5; i++)
            {
                Label_Time[i].Text = ((int)(2 * i * Math.Pow(2, MonitorPageDisp))).ToString();
            }
        }

        //-- Recoed開始処理 -----------------------------------------------------------------------
        private void ButtonRecord_Click(object sender, EventArgs e)
        {
            FileStream fs;
            string data = "";
            int i;

            if (ButtonRecord.BackColor == InActive)
            {
                try
                {
                    SaveFileDialog.Filter = "(*.csv)|*.csv";
                    if (SaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        fs = new FileStream(SaveFileDialog.FileName, FileMode.Create);
                        DataFile = new StreamWriter(fs, Encoding.GetEncoding("shift_jis"));
                        DataFile.WriteLine(AppTitle + " " + Parameters);
                        data = "DateTime,Mode,";
                        for (i = 0; i < AXIS_NUM; i++)
                            data += "SV" + (i + 1).ToString() + "[℃],";
                        for (i = 0; i < AXIS_NUM; i++)
                            data += "PV" + (i + 1).ToString() + "[℃],";
                        for (i = 0; i < AXIS_NUM; i++)
                            data += "MV" + (i + 1).ToString() + "[%],";
                        data += "DV,";
                        for (i = 0; i < AXIS_NUM; i++)
                            data += "K" + (i + 1).ToString() + "[%],";
                        for (i = 0; i < AXIS_NUM; i++)
                            data += "MVkura" + (i + 1).ToString() + "[%],";
                        for (i = 0; i < AXIS_NUM; i++)
                            data += "MVp" + (i + 1).ToString() + "[%],";
                        for (i = 0; i < AXIS_NUM; i++)
                            data += "MVi" + (i + 1).ToString() + "[%],";
                        for (i = 0; i < AXIS_NUM; i++)
                            data += "MVd" + (i + 1).ToString() + "[%],";
                        for (i = 0; i < SENSOR_NUM; i++)
                            data += "T" + (char)((int)'A' + i) + "[℃],";
                        for (i = 0; i < AXIS_NUM; i++)
                            data += "SV" + (i + 1).ToString() + "[dig],";
                        for (i = 0; i < AXIS_NUM; i++)
                            data += "PV" + (i + 1).ToString() + "[dig],";
                        for (i = 0; i < SENSOR_NUM; i++)
                            data += "T" + (char)((int)'A' + i) + "[dig],";
                        data += "Comm";
                        DataFile.WriteLine(data);
                        ButtonRecord.BackColor = Active;
                        resetPage();
                        this.Text = AppTitle + "  " + SaveFileDialog.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (DataFile != null)
                        DataFile.Close();
                }
            }
            else
            {
                if (DataFile != null)
                    DataFile.Close();
                ButtonRecord.BackColor = InActive;
                this.Text = AppTitle;
            }
        }

        //-- パラメータ設定処理 -------------------------------------------------------------------
        private void ButtonSetParameters_Click(object sender, EventArgs e)
        {
            REQ_PARAMETERS = true;
        }

        //-- 制御開始処理 -------------------------------------------------------------------------
        private void RadioButtonControl_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonControl.Checked == true)
            {
                //parameterChangeEnable(false);
                disturbanceControlEnable(false);
                if (DisturbanceAuto.Checked)
                {
                    DisturbStartCounter = (int)DisturbanceStart.Value;
                    DisturbIntervalCounter = 0;
                }
                else
                {
                    DisturbStartCounter = 0;
                    DisturbIntervalCounter = 0;
                }
                REQ_CONTROL_STOP = false;
                REQ_CONTROL_START = true;
                RadioButtonControl.BackColor = Active; 
            }
        }

        //-- 制御停止処理 -------------------------------------------------------------------------
        private void RadioButtonIdle_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonIdle.Checked == true)
            {
                REQ_CONTROL_STOP = true;
                RadioButtonControl.BackColor = InActive;
            }
        }

        private void parameterChangeEnable(bool state)
        {
            ParametersPanel.Enabled = state;
            for (int i = 0; i < Constants.CONTROLLER_NUM; i++) //4->9
            {
                SVcmd[i].Enabled = state;
                MVgain[i].Enabled = state;
                MVdelay[i].Enabled = state;
            }
            disturbanceControlEnable(true);
            DisturbStartCounter = 0;
        }

        //-- コントローラパラメータ設定処理 -------------------------------------------------------
        private void Algorism_CheckedChanged(object sender, EventArgs e)
        {
            AlgorismSelect();
            controlStartDisable();
        }
        private void AlgorismSelect()
        {
            if (RadioButtonManual.Checked)
            {
                RadioButtonManual.BackColor = Active;
                RadioButtonSync.BackColor = InActive;
            }
            else
            {
                RadioButtonManual.BackColor = InActive;
                RadioButtonSync.BackColor = Active;
            }
        }

        private void Parameter_Change(object sender, EventArgs e)
        {
            controlStartDisable();
        }

        private void Config_Changed(object sender, EventArgs e)
        {
            controlStartDisable();
            SetManualMin();
        }
        private void SetManualMin()
        {
            if (ChkMVPol.Checked == true)
                ManualMV.Minimum = -100;
            else { 
                if (ManualMV.Value < 0)
                    ManualMV.Value = 0;
                ManualMV.Minimum = 0;
            }
        }

        private void controlStartDisable()
        {
            RadioButtonControl.Enabled = false;
            LabelController.BackColor = NotReady;
        }

        //-- 外乱設定処理 --------------------------------------------------------------------------
        private void disturbanceControlEnable(bool state)
        {
            DisturbanceVariable.Enabled = state;
            DisturbanceStart.Enabled = state;
            DisturbanceInterval.Enabled = state;
            DisturbanceManual.Enabled = state;
            DisturbanceAuto.Enabled = state;
            if (state)
            {
                DV = 0;
                DisturbanceApply.Enabled = false;
                DisturbanceApply.BackColor = InActive;
            }
            else
            {
                DisturbanceApply.Enabled = DisturbanceManual.Checked;
            }
        }

        private void DisturbanceApply_Click(object sender, EventArgs e)
        {
            if (DisturbanceApply.BackColor == InActive)
            {
                DisturbanceApply.BackColor = Active;
                DV = (int)DisturbanceVariable.Value;
            }
            else
            {
                DisturbanceApply.BackColor = InActive;
                DV = 0;
            }

        }

    }
}
