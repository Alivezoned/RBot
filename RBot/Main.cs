using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace RBot
{
    public partial class Main : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private void BringToFront(Process pTemp)
        {
            SetForegroundWindow(pTemp.MainWindowHandle);
        }
        //-------------------------------------------------
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")] //Set the active window
        public static extern IntPtr SetActiveWindow(IntPtr hWnd);

        //[DllImport("user32.dll")] //sends a windows message to the specified window
        //public static extern int SendMessage(IntPtr hWnd, int Msg, uint wParam, int lParam);


        //public const ushort WM_KEYDOWN = 0x0100;
        //public const ushort WM_KEYUP = 0x0101;

        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern uint SendInput(uint numberOfInputs, INPUT[] inputs, int sizeOfInputStructure);

        //----------------------------------------------------

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        private const int KEYEVENT_QUICKPRESET = 51; //Main Key (Numerical 1)
        private const int KEYEVENT_SPACEBAR = 0x20; //Main Key (Spacebar)

        //If specified, the key is being released. If not specified, the key is being depressed.
        private const uint KEYEVENTF_KEYUP = 0x0002;

        //If specified, the scan code was preceded by a prefix byte having the value 0xE0 (224
        private const uint KEYEVENTF_EXTENDEDKEY = 0x0001; //0x0001

        private Boolean Run_RandomClicker;
        private Boolean Run_QuickSlot;
        private Boolean Run_SpaceClicker;

        private Boolean Run_All;

        private int ClickLimit_RandomClicker;
        private int ClickLimit_QuickSlot;
        private int ClickLimit_SpaceClicker;

        private int Count_RC;
        private int Count_QS;
        private int Count_SC;

        private int Latency_Min_RC;
        private int Latency_Max_RC;

        private int Latency_Min_QS;
        private int Latency_Max_QS;

        private int Latency_Min_SC;
        private int Latency_Max_SC;

        Random Random;

        MouseClick MouseClick;

        public Main()
        {
            InitializeComponent();

            Run_RandomClicker = false;
            Run_QuickSlot = false;
            Run_SpaceClicker = false;

            ClickLimit_RandomClicker = 1;
            ClickLimit_QuickSlot = 1;
            ClickLimit_SpaceClicker = 1;

            Count_RC = 0;
            Count_QS = 0;
            Count_SC = 0;

            timer_rc.Start();
            timer_qs.Start();
            timer_sc.Start();

            Random = new Random();

            MouseClick = new MouseClick();

            this.TopLevel = true;
            this.TopMost = true;
        }

        //public void SendKey(ushort key, IntPtr hWnd)
        //{
        //    SetActiveWindow(hWnd);
        //    SendMessage(hWnd, WM_KEYDOWN, key, 1);
        //    SendMessage(hWnd, WM_KEYUP, key, 1);
        //}

        public String GetActiveProcessFileName()
        {
            IntPtr hwnd = GetForegroundWindow();
            uint pid;
            GetWindowThreadProcessId(hwnd, out pid);
            Process p = Process.GetProcessById((int)pid);
            String yo = p.MainModule.FileName.ToString();

            return yo;
        }
        
        /// <summary>
        /// Random Clicker Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_rc_Tick(object sender, EventArgs e)
        {
            if (Run_RandomClicker)
            {
                if (Count_RC <= ClickLimit_RandomClicker)
                {
                    int interval = Random.Next(Latency_Min_RC, Latency_Max_RC);

                    MouseClick.Click();

                    label_latency_min_rc.Text = "" + Latency_Min_RC;
                    label_latency_max_rc.Text = "" + Latency_Max_RC;

                    label_click_limit_rc.Text = "" + ClickLimit_RandomClicker;
                    label_show_rc.Text = "Last Latency :" + interval + " Click Count : " + Count_RC;

                    Count_RC += 1;
                    timer_rc.Interval = interval;
                }
                else
                {
                    btn_rc.Text = "Start Clicking : Stopped";
                    Run_RandomClicker = false;
                }
            }
        }

        /// <summary>
        /// Quick Slot Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_qs_Tick(object sender, EventArgs e)
        {
            if (Run_QuickSlot)
            {
                if (Count_QS <= ClickLimit_QuickSlot)
                {
                    //BringToFront(Process.GetCurrentProcess());

                    //Process[] process = Process.GetProcessesByName("rs2client.exe");

                    //foreach (Process p in process)
                    //{
                    //    BringToFront(p);
                    //}

                    int interval = Random.Next(Latency_Min_QS, Latency_Max_QS);

                    int KeyName = KeyInterop.VirtualKeyFromKey(Key.D1);

                    String f = GetActiveProcessFileName();

                    if (!f.Contains("ot"))
                    {
                        keybd_event((byte)KeyName, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
                    }

                    label_latency_min_qs.Text = "" + Latency_Min_QS;
                    label_latency_max_qs.Text = "" + Latency_Max_QS;

                    label_click_limit_qs.Text = "" + ClickLimit_QuickSlot;
                    label_show_qs.Text = "Last Latency :" + interval + " Click Count : " + Count_QS;

                    Count_QS += 1;
                    timer_qs.Interval = interval;
                }
                else
                {
                    btn_qs.Text = "Start Quick Slot : Stopped";
                    Run_QuickSlot = false;
                }
            }
        }

        /// <summary>
        /// Space Clicker Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_sc_Tick(object sender, EventArgs e)
        {
            if (Run_SpaceClicker)
            {
                if (Count_SC <= ClickLimit_SpaceClicker)
                {
                    int interval = Random.Next(Latency_Min_SC, Latency_Max_SC);

                    int KeyName = 0x20;

                    String f = GetActiveProcessFileName();

                    if (!f.Contains("Bot"))
                    {
                        keybd_event((byte)KeyName, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
                    }
                    
                    label_latency_min_sc.Text = "" + Latency_Min_SC;
                    label_latency_max_sc.Text = "" + Latency_Max_SC;

                    label_click_limit_sc.Text = "" + ClickLimit_SpaceClicker;
                    label_show_sc.Text = "Last Latency :" + interval + " Click Count : " + Count_SC;

                    Count_SC += 1;
                    timer_sc.Interval = interval;
                }
                else
                {
                    btn_sc.Text = "Start Space Clicking : Stopped";
                    Run_SpaceClicker = false;
                }
            }
        }

        /// <summary>
        /// Button Random Clicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_rc_Click(object sender, EventArgs e)
        {
            if (Run_RandomClicker)
            {
                Run_RandomClicker = false;
                btn_rc.Text = "Start Clicking : Stopped";
            }
            else
            {
                Count_RC = 0;
                ClickLimit_RandomClicker = Convert(txt_click_limit_rc);

                Latency_Min_RC = Convert(txt_latency_min_rc);
                Latency_Max_RC = Convert(txt_latency_max_rc);

                int interval = Random.Next(Latency_Min_RC, Latency_Max_RC);
                timer_rc.Interval = interval;

                Run_RandomClicker = true;
                btn_rc.Text = "Start Clicking : Running";
            }
        }

        /// <summary>
        /// Button Quick Slot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_qs_Click(object sender, EventArgs e)
        {
            if (Run_QuickSlot)
            {
                Run_QuickSlot = false;
                btn_qs.Text = "Start Quick Slot : Stopped";
            }
            else
            {
                Count_QS = 0;
                ClickLimit_QuickSlot = Convert(txt_click_limit_qs);

                Latency_Min_QS = Convert(txt_latency_min_qs);
                Latency_Max_QS = Convert(txt_latency_max_qs);

                int interval = Random.Next(Latency_Min_QS, Latency_Max_QS);
                timer_qs.Interval = interval;

                Run_QuickSlot = true;
                btn_qs.Text = "Start Quick Slot : Running";
            }
        }

        /// <summary>
        /// Button Space Clicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sc_Click(object sender, EventArgs e)
        {
            if (!Run_SpaceClicker)
            {
                Count_SC = 0;
                ClickLimit_SpaceClicker = Convert(txt_click_limit_sc);

                Latency_Min_SC = Convert(txt_latency_min_sc);
                Latency_Max_SC = Convert(txt_latency_max_sc);

                int interval = Random.Next(Latency_Min_SC, Latency_Max_SC);
                timer_sc.Interval = interval;

                Run_SpaceClicker = true;
                btn_sc.Text = "Start Space Clicking : Running";
            }
            else
            {
                Run_SpaceClicker = false;
                btn_sc.Text = "Start Space Clicking : Stopped";
            }
        }

        private int Convert(TextBox textBox)
        {
            int final = 0;

            try
            {
                String text = textBox.Text.ToString().Trim();
                final = int.Parse(text);
            }
            catch (Exception ex)
            {
                final = 100;
            }

            return final;
        }

        private void btn_start_all_Click(object sender, EventArgs e)
        {
            Run_RandomClicker = false;
            btn_qs.Text = "Start Quick Slot : Stopped 3";

            Run_QuickSlot = false;
            btn_qs.Text = "Start Quick Slot : Stopped 3";

            Run_SpaceClicker = false;
            btn_sc.Text = "Start Space Clicking : Stopped 3";

            //Run_All = false;
            //btn_start_all.Text = "Start Everything : Stopped";
        }

        public void KeyDown(Keys vKey)
        {
            keybd_event((byte)vKey, 0, 0, 0);
        }

        public void KeyUp(Keys vKey)
        {
            keybd_event((byte)vKey, 0, KEYEVENTF_KEYUP, 0);
        }
    }
}
