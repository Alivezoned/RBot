using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RBot
{
    public partial class AppBreakClick : Form
    {
        private Boolean Run_RandomClicker;

        private int Count_RC;
        private int ClickLimit_RandomClicker;

        private int Latency_Min_RC;
        private int Latency_Max_RC;

        //------------------------------------
        private Boolean Run_AntiBan;

        // Current Click Count
        private int ClickCount;
        private int AfterClicks;

        private int MinDelay;
        private int MaxDelay;

        private int BreakSeconds;
        private int MaxBreakSeconds;

        //------------------------------------
        Random Random;
        MouseClick MouseClick;

        public AppBreakClick()
        {
            InitializeComponent();

            Run_RandomClicker = false;

            ClickLimit_RandomClicker = 1;
            Count_RC = 0;
            //--------------------------
            Run_AntiBan = false;

            AfterClicks = 5;
            ClickCount = 0;

            MinDelay = 1000;
            MaxDelay = 3000;

            BreakSeconds = 0;
            MaxBreakSeconds = 10;
            //--------------------------
            Random = new Random();
            MouseClick = new MouseClick();
            this.BackColor = Color.FromArgb(35, 35, 35);

            this.TopLevel = true;
            this.TopMost = true;

            // Anti-Ban Break Timer Function Runs Every 1 Second
            timer_break.Interval = 1000;
        }

        // Anti Ban Timer!
        private void timer_break_Tick(object sender, EventArgs e)
        {
            if (Run_AntiBan)
            {
                if (Count_RC >= ClickCount)
                {
                    Break();

                    btn_antiban.Text = "Anti-Ban : Running";
                }
            }
            else
            {
                btn_antiban.Text = "Anti-Ban : Stopped";
            }
        }

        // Anti Ban Button!
        private void btn_antiban_Click(object sender, EventArgs e)
        {
            if (Run_AntiBan)
            {
                Run_AntiBan = false;
                btn_antiban.Text = "Anti-Ban : Stopped";

            }
            else
            {
                Run_AntiBan = true;
                
                MinDelay = Convert(txt_min_delay);
                MaxDelay = Convert(txt_max_delay);

                Delay();

                UpdateLabels();

                btn_antiban.Text = "Anti-Ban : Running";
            }
        }

        #region Anti Ban Functions

        private void Delay()
        {
            int minAfterClick = Convert(txt_after_clicks);
            int maxAfterClick = minAfterClick + 10;

            AfterClicks = Random.Next(minAfterClick, maxAfterClick);

            // Click Count After which to initiate Anti Ban
            ClickCount = Count_RC + AfterClicks;

            // Maximum Break to take in seconds
            MaxBreakSeconds = Random.Next(MinDelay, MaxDelay);

            UpdateLabels();
        }

        private void Break()
        {
            if (BreakSeconds >= MaxBreakSeconds)
            {
                Run_RandomClicker = true;
                BreakSeconds = 0;
                Delay();

                label_show_anti_ban.Text = "MaxBreakSec: "+MaxBreakSeconds
                    +" | FinalClickCount: "+ClickCount
                    +"";
            }
            else
            {
                BreakSeconds++;
                Run_RandomClicker = false;

                UpdateLabels();

                int CountDown = MaxBreakSeconds - BreakSeconds;
                label_show_anti_ban.Text = "Taking Break : "+CountDown;
            }
        }

        private void UpdateLabels()
        {
            label_after_clicks.Text = AfterClicks.ToString();
            label_min_delay.Text = MinDelay.ToString();
            label_max_delay.Text = MaxDelay.ToString();
        }

        #endregion
        //--------------------------------------------------------------

        // Random Click Timer!
        private void timer_rc_Tick(object sender, EventArgs e)
        {
            if (Run_RandomClicker)
            {
                // If Click Count is <= Click Limit
                if (Count_RC <= ClickLimit_RandomClicker)
                {
                    // New Random Interval
                    int interval = Random.Next(Latency_Min_RC, Latency_Max_RC);

                    // Perform Mouse Click
                    MouseClick.Click();

                    // Show Min Latency and Max Latency
                    label_latency_min_rc.Text = "" + Latency_Min_RC;
                    label_latency_max_rc.Text = "" + Latency_Max_RC;

                    // Display Last Latency and Click Count
                    label_click_limit_rc.Text = "" + ClickLimit_RandomClicker;
                    label_show_rc.Text = "Last Latency :" + interval + " Click Count : " + Count_RC;

                    // Add Every click performed to the counter
                    Count_RC += 1;
                    timer_rc.Interval = interval;
                    
                    btn_rc.Text = "Start Clicking : Running";
                }
                else
                {
                    btn_rc.Text = "Start Clicking : Stopped";
                    Run_RandomClicker = false;
                }
            }
            else
            {
                btn_rc.Text = "Start Clicking: Stopped";
            }
        }

        // Random Click Button!
        private void btn_rc_Click(object sender, EventArgs e)
        {
            if (Run_RandomClicker)
            {
                Run_RandomClicker = false;
                btn_rc.Text = "Start Clicking : Stopped";
            }
            else
            {
                // Click Count Set to 0
                Count_RC = 0;

                // Setting Click Limit
                ClickLimit_RandomClicker = Convert(txt_click_limit_rc);

                // Setting Min and Max Latency
                Latency_Min_RC = Convert(txt_latency_min_rc);
                Latency_Max_RC = Convert(txt_latency_max_rc);

                // Random Interval between Min and Max Latency
                int interval = Random.Next(Latency_Min_RC, Latency_Max_RC);
                timer_rc.Interval = interval;

                Run_RandomClicker = true;
                btn_rc.Text = "Start Clicking : Running";
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
    }
}
