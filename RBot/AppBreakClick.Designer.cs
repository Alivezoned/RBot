namespace RBot
{
    partial class AppBreakClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppBreakClick));
            this.label_show_rc = new System.Windows.Forms.Label();
            this.btn_rc = new System.Windows.Forms.Button();
            this.label_click_limit_rc = new System.Windows.Forms.Label();
            this.label_latency_max_rc = new System.Windows.Forms.Label();
            this.label_latency_min_rc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_click_limit_rc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_latency_max_rc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_latency_min_rc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_min_delay = new System.Windows.Forms.TextBox();
            this.label_show_anti_ban = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_antiban = new System.Windows.Forms.Button();
            this.txt_max_delay = new System.Windows.Forms.TextBox();
            this.label_after_clicks = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_max_delay = new System.Windows.Forms.Label();
            this.txt_after_clicks = new System.Windows.Forms.TextBox();
            this.label_min_delay = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer_rc = new System.Windows.Forms.Timer(this.components);
            this.timer_break = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_show_rc
            // 
            this.label_show_rc.AutoSize = true;
            this.label_show_rc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_show_rc.Location = new System.Drawing.Point(9, 120);
            this.label_show_rc.Name = "label_show_rc";
            this.label_show_rc.Size = new System.Drawing.Size(188, 13);
            this.label_show_rc.TabIndex = 39;
            this.label_show_rc.Text = "Last Latency : 1150  Click Count : 177";
            // 
            // btn_rc
            // 
            this.btn_rc.BackColor = System.Drawing.Color.Gray;
            this.btn_rc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rc.Location = new System.Drawing.Point(6, 90);
            this.btn_rc.Name = "btn_rc";
            this.btn_rc.Size = new System.Drawing.Size(273, 23);
            this.btn_rc.TabIndex = 38;
            this.btn_rc.Text = "Start Clicking : Stopped";
            this.btn_rc.UseVisualStyleBackColor = false;
            this.btn_rc.Click += new System.EventHandler(this.btn_rc_Click);
            // 
            // label_click_limit_rc
            // 
            this.label_click_limit_rc.AutoSize = true;
            this.label_click_limit_rc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_click_limit_rc.Location = new System.Drawing.Point(202, 73);
            this.label_click_limit_rc.Name = "label_click_limit_rc";
            this.label_click_limit_rc.Size = new System.Drawing.Size(31, 13);
            this.label_click_limit_rc.TabIndex = 37;
            this.label_click_limit_rc.Text = "1150";
            // 
            // label_latency_max_rc
            // 
            this.label_latency_max_rc.AutoSize = true;
            this.label_latency_max_rc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_latency_max_rc.Location = new System.Drawing.Point(103, 73);
            this.label_latency_max_rc.Name = "label_latency_max_rc";
            this.label_latency_max_rc.Size = new System.Drawing.Size(31, 13);
            this.label_latency_max_rc.TabIndex = 36;
            this.label_latency_max_rc.Text = "1150";
            // 
            // label_latency_min_rc
            // 
            this.label_latency_min_rc.AutoSize = true;
            this.label_latency_min_rc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_latency_min_rc.Location = new System.Drawing.Point(9, 73);
            this.label_latency_min_rc.Name = "label_latency_min_rc";
            this.label_latency_min_rc.Size = new System.Drawing.Size(31, 13);
            this.label_latency_min_rc.TabIndex = 35;
            this.label_latency_min_rc.Text = "1150";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(202, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Click Limit";
            // 
            // txt_click_limit_rc
            // 
            this.txt_click_limit_rc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_click_limit_rc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_click_limit_rc.Location = new System.Drawing.Point(202, 46);
            this.txt_click_limit_rc.Name = "txt_click_limit_rc";
            this.txt_click_limit_rc.Size = new System.Drawing.Size(75, 20);
            this.txt_click_limit_rc.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(103, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Max Latency";
            // 
            // txt_latency_max_rc
            // 
            this.txt_latency_max_rc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_latency_max_rc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_latency_max_rc.Location = new System.Drawing.Point(103, 46);
            this.txt_latency_max_rc.Name = "txt_latency_max_rc";
            this.txt_latency_max_rc.Size = new System.Drawing.Size(75, 20);
            this.txt_latency_max_rc.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Min Latency";
            // 
            // txt_latency_min_rc
            // 
            this.txt_latency_min_rc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_latency_min_rc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_latency_min_rc.Location = new System.Drawing.Point(6, 46);
            this.txt_latency_min_rc.Name = "txt_latency_min_rc";
            this.txt_latency_min_rc.Size = new System.Drawing.Size(75, 20);
            this.txt_latency_min_rc.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_latency_min_rc);
            this.groupBox1.Controls.Add(this.label_show_rc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_rc);
            this.groupBox1.Controls.Add(this.txt_latency_max_rc);
            this.groupBox1.Controls.Add(this.label_click_limit_rc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_latency_max_rc);
            this.groupBox1.Controls.Add(this.txt_click_limit_rc);
            this.groupBox1.Controls.Add(this.label_latency_min_rc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 148);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random Clicker";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_min_delay);
            this.groupBox2.Controls.Add(this.label_show_anti_ban);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_antiban);
            this.groupBox2.Controls.Add(this.txt_max_delay);
            this.groupBox2.Controls.Add(this.label_after_clicks);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label_max_delay);
            this.groupBox2.Controls.Add(this.txt_after_clicks);
            this.groupBox2.Controls.Add(this.label_min_delay);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 144);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Break (Anti Ban)";
            // 
            // txt_min_delay
            // 
            this.txt_min_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_min_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_min_delay.Location = new System.Drawing.Point(6, 45);
            this.txt_min_delay.Name = "txt_min_delay";
            this.txt_min_delay.Size = new System.Drawing.Size(75, 20);
            this.txt_min_delay.TabIndex = 40;
            // 
            // label_show_anti_ban
            // 
            this.label_show_anti_ban.AutoSize = true;
            this.label_show_anti_ban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_show_anti_ban.Location = new System.Drawing.Point(9, 119);
            this.label_show_anti_ban.Name = "label_show_anti_ban";
            this.label_show_anti_ban.Size = new System.Drawing.Size(188, 13);
            this.label_show_anti_ban.TabIndex = 50;
            this.label_show_anti_ban.Text = "Last Latency : 1150  Click Count : 177";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Min Delay (s)";
            // 
            // btn_antiban
            // 
            this.btn_antiban.BackColor = System.Drawing.Color.Gray;
            this.btn_antiban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_antiban.Location = new System.Drawing.Point(6, 89);
            this.btn_antiban.Name = "btn_antiban";
            this.btn_antiban.Size = new System.Drawing.Size(273, 23);
            this.btn_antiban.TabIndex = 49;
            this.btn_antiban.Text = "AntiBan : Stopped";
            this.btn_antiban.UseVisualStyleBackColor = false;
            this.btn_antiban.Click += new System.EventHandler(this.btn_antiban_Click);
            // 
            // txt_max_delay
            // 
            this.txt_max_delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_max_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_max_delay.Location = new System.Drawing.Point(103, 45);
            this.txt_max_delay.Name = "txt_max_delay";
            this.txt_max_delay.Size = new System.Drawing.Size(75, 20);
            this.txt_max_delay.TabIndex = 42;
            // 
            // label_after_clicks
            // 
            this.label_after_clicks.AutoSize = true;
            this.label_after_clicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_after_clicks.Location = new System.Drawing.Point(202, 72);
            this.label_after_clicks.Name = "label_after_clicks";
            this.label_after_clicks.Size = new System.Drawing.Size(31, 13);
            this.label_after_clicks.TabIndex = 48;
            this.label_after_clicks.Text = "1150";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(103, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Max Delay (s)";
            // 
            // label_max_delay
            // 
            this.label_max_delay.AutoSize = true;
            this.label_max_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_max_delay.Location = new System.Drawing.Point(103, 72);
            this.label_max_delay.Name = "label_max_delay";
            this.label_max_delay.Size = new System.Drawing.Size(31, 13);
            this.label_max_delay.TabIndex = 47;
            this.label_max_delay.Text = "1150";
            // 
            // txt_after_clicks
            // 
            this.txt_after_clicks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_after_clicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_after_clicks.Location = new System.Drawing.Point(202, 45);
            this.txt_after_clicks.Name = "txt_after_clicks";
            this.txt_after_clicks.Size = new System.Drawing.Size(75, 20);
            this.txt_after_clicks.TabIndex = 44;
            // 
            // label_min_delay
            // 
            this.label_min_delay.AutoSize = true;
            this.label_min_delay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_min_delay.Location = new System.Drawing.Point(9, 72);
            this.label_min_delay.Name = "label_min_delay";
            this.label_min_delay.Size = new System.Drawing.Size(31, 13);
            this.label_min_delay.TabIndex = 46;
            this.label_min_delay.Text = "1150";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(202, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "After Clicks";
            // 
            // timer_rc
            // 
            this.timer_rc.Enabled = true;
            this.timer_rc.Tick += new System.EventHandler(this.timer_rc_Tick);
            // 
            // timer_break
            // 
            this.timer_break.Enabled = true;
            this.timer_break.Tick += new System.EventHandler(this.timer_break_Tick);
            // 
            // AppBreakClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 318);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppBreakClick";
            this.Text = "AppBreakClick";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_show_rc;
        private System.Windows.Forms.Button btn_rc;
        private System.Windows.Forms.Label label_click_limit_rc;
        private System.Windows.Forms.Label label_latency_max_rc;
        private System.Windows.Forms.Label label_latency_min_rc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_click_limit_rc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_latency_max_rc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_latency_min_rc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_min_delay;
        private System.Windows.Forms.Label label_show_anti_ban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_antiban;
        private System.Windows.Forms.TextBox txt_max_delay;
        private System.Windows.Forms.Label label_after_clicks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_max_delay;
        private System.Windows.Forms.TextBox txt_after_clicks;
        private System.Windows.Forms.Label label_min_delay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer_rc;
        private System.Windows.Forms.Timer timer_break;
    }
}