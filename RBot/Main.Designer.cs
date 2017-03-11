namespace RBot
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_show_qs = new System.Windows.Forms.Label();
            this.btn_qs = new System.Windows.Forms.Button();
            this.label_click_limit_qs = new System.Windows.Forms.Label();
            this.label_latency_max_qs = new System.Windows.Forms.Label();
            this.label_latency_min_qs = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_click_limit_qs = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_latency_max_qs = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_latency_min_qs = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_show_sc = new System.Windows.Forms.Label();
            this.btn_sc = new System.Windows.Forms.Button();
            this.label_click_limit_sc = new System.Windows.Forms.Label();
            this.label_latency_max_sc = new System.Windows.Forms.Label();
            this.label_latency_min_sc = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_click_limit_sc = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_latency_max_sc = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_latency_min_sc = new System.Windows.Forms.TextBox();
            this.btn_start_all = new System.Windows.Forms.Button();
            this.timer_rc = new System.Windows.Forms.Timer(this.components);
            this.timer_qs = new System.Windows.Forms.Timer(this.components);
            this.timer_sc = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_show_rc);
            this.groupBox1.Controls.Add(this.btn_rc);
            this.groupBox1.Controls.Add(this.label_click_limit_rc);
            this.groupBox1.Controls.Add(this.label_latency_max_rc);
            this.groupBox1.Controls.Add(this.label_latency_min_rc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_click_limit_rc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_latency_max_rc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_latency_min_rc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 157);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random Clicker";
            // 
            // label_show_rc
            // 
            this.label_show_rc.AutoSize = true;
            this.label_show_rc.Location = new System.Drawing.Point(9, 126);
            this.label_show_rc.Name = "label_show_rc";
            this.label_show_rc.Size = new System.Drawing.Size(188, 13);
            this.label_show_rc.TabIndex = 28;
            this.label_show_rc.Text = "Last Latency : 1150  Click Count : 177";
            // 
            // btn_rc
            // 
            this.btn_rc.Location = new System.Drawing.Point(6, 96);
            this.btn_rc.Name = "btn_rc";
            this.btn_rc.Size = new System.Drawing.Size(273, 23);
            this.btn_rc.TabIndex = 27;
            this.btn_rc.Text = "Start Clicking : Stopped";
            this.btn_rc.UseVisualStyleBackColor = true;
            this.btn_rc.Click += new System.EventHandler(this.btn_rc_Click);
            // 
            // label_click_limit_rc
            // 
            this.label_click_limit_rc.AutoSize = true;
            this.label_click_limit_rc.Location = new System.Drawing.Point(202, 79);
            this.label_click_limit_rc.Name = "label_click_limit_rc";
            this.label_click_limit_rc.Size = new System.Drawing.Size(31, 13);
            this.label_click_limit_rc.TabIndex = 26;
            this.label_click_limit_rc.Text = "1150";
            // 
            // label_latency_max_rc
            // 
            this.label_latency_max_rc.AutoSize = true;
            this.label_latency_max_rc.Location = new System.Drawing.Point(103, 79);
            this.label_latency_max_rc.Name = "label_latency_max_rc";
            this.label_latency_max_rc.Size = new System.Drawing.Size(31, 13);
            this.label_latency_max_rc.TabIndex = 25;
            this.label_latency_max_rc.Text = "1150";
            // 
            // label_latency_min_rc
            // 
            this.label_latency_min_rc.AutoSize = true;
            this.label_latency_min_rc.Location = new System.Drawing.Point(9, 79);
            this.label_latency_min_rc.Name = "label_latency_min_rc";
            this.label_latency_min_rc.Size = new System.Drawing.Size(31, 13);
            this.label_latency_min_rc.TabIndex = 24;
            this.label_latency_min_rc.Text = "1150";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Click Limit";
            // 
            // txt_click_limit_rc
            // 
            this.txt_click_limit_rc.Location = new System.Drawing.Point(202, 52);
            this.txt_click_limit_rc.Name = "txt_click_limit_rc";
            this.txt_click_limit_rc.Size = new System.Drawing.Size(75, 20);
            this.txt_click_limit_rc.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Max Latency";
            // 
            // txt_latency_max_rc
            // 
            this.txt_latency_max_rc.Location = new System.Drawing.Point(103, 52);
            this.txt_latency_max_rc.Name = "txt_latency_max_rc";
            this.txt_latency_max_rc.Size = new System.Drawing.Size(75, 20);
            this.txt_latency_max_rc.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Min Latency";
            // 
            // txt_latency_min_rc
            // 
            this.txt_latency_min_rc.Location = new System.Drawing.Point(6, 52);
            this.txt_latency_min_rc.Name = "txt_latency_min_rc";
            this.txt_latency_min_rc.Size = new System.Drawing.Size(75, 20);
            this.txt_latency_min_rc.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_show_qs);
            this.groupBox2.Controls.Add(this.btn_qs);
            this.groupBox2.Controls.Add(this.label_click_limit_qs);
            this.groupBox2.Controls.Add(this.label_latency_max_qs);
            this.groupBox2.Controls.Add(this.label_latency_min_qs);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_click_limit_qs);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_latency_max_qs);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_latency_min_qs);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 157);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quick Slot 2";
            // 
            // label_show_qs
            // 
            this.label_show_qs.AutoSize = true;
            this.label_show_qs.Location = new System.Drawing.Point(9, 126);
            this.label_show_qs.Name = "label_show_qs";
            this.label_show_qs.Size = new System.Drawing.Size(188, 13);
            this.label_show_qs.TabIndex = 28;
            this.label_show_qs.Text = "Last Latency : 1150  Click Count : 177";
            // 
            // btn_qs
            // 
            this.btn_qs.Location = new System.Drawing.Point(6, 96);
            this.btn_qs.Name = "btn_qs";
            this.btn_qs.Size = new System.Drawing.Size(273, 23);
            this.btn_qs.TabIndex = 27;
            this.btn_qs.Text = "Start Quick Slot : Stopped";
            this.btn_qs.UseVisualStyleBackColor = true;
            this.btn_qs.Click += new System.EventHandler(this.btn_qs_Click);
            // 
            // label_click_limit_qs
            // 
            this.label_click_limit_qs.AutoSize = true;
            this.label_click_limit_qs.Location = new System.Drawing.Point(202, 79);
            this.label_click_limit_qs.Name = "label_click_limit_qs";
            this.label_click_limit_qs.Size = new System.Drawing.Size(31, 13);
            this.label_click_limit_qs.TabIndex = 26;
            this.label_click_limit_qs.Text = "1150";
            // 
            // label_latency_max_qs
            // 
            this.label_latency_max_qs.AutoSize = true;
            this.label_latency_max_qs.Location = new System.Drawing.Point(103, 79);
            this.label_latency_max_qs.Name = "label_latency_max_qs";
            this.label_latency_max_qs.Size = new System.Drawing.Size(31, 13);
            this.label_latency_max_qs.TabIndex = 25;
            this.label_latency_max_qs.Text = "1150";
            // 
            // label_latency_min_qs
            // 
            this.label_latency_min_qs.AutoSize = true;
            this.label_latency_min_qs.Location = new System.Drawing.Point(9, 79);
            this.label_latency_min_qs.Name = "label_latency_min_qs";
            this.label_latency_min_qs.Size = new System.Drawing.Size(31, 13);
            this.label_latency_min_qs.TabIndex = 24;
            this.label_latency_min_qs.Text = "1150";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Click Limit";
            // 
            // txt_click_limit_qs
            // 
            this.txt_click_limit_qs.Location = new System.Drawing.Point(202, 52);
            this.txt_click_limit_qs.Name = "txt_click_limit_qs";
            this.txt_click_limit_qs.Size = new System.Drawing.Size(75, 20);
            this.txt_click_limit_qs.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(103, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Max Latency";
            // 
            // txt_latency_max_qs
            // 
            this.txt_latency_max_qs.Location = new System.Drawing.Point(103, 52);
            this.txt_latency_max_qs.Name = "txt_latency_max_qs";
            this.txt_latency_max_qs.Size = new System.Drawing.Size(75, 20);
            this.txt_latency_max_qs.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Min Latency";
            // 
            // txt_latency_min_qs
            // 
            this.txt_latency_min_qs.Location = new System.Drawing.Point(6, 52);
            this.txt_latency_min_qs.Name = "txt_latency_min_qs";
            this.txt_latency_min_qs.Size = new System.Drawing.Size(75, 20);
            this.txt_latency_min_qs.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_show_sc);
            this.groupBox3.Controls.Add(this.btn_sc);
            this.groupBox3.Controls.Add(this.label_click_limit_sc);
            this.groupBox3.Controls.Add(this.label_latency_max_sc);
            this.groupBox3.Controls.Add(this.label_latency_min_sc);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txt_click_limit_sc);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txt_latency_max_sc);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txt_latency_min_sc);
            this.groupBox3.Location = new System.Drawing.Point(12, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 157);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Space Clicker";
            // 
            // label_show_sc
            // 
            this.label_show_sc.AutoSize = true;
            this.label_show_sc.Location = new System.Drawing.Point(9, 126);
            this.label_show_sc.Name = "label_show_sc";
            this.label_show_sc.Size = new System.Drawing.Size(188, 13);
            this.label_show_sc.TabIndex = 28;
            this.label_show_sc.Text = "Last Latency : 1150  Click Count : 177";
            // 
            // btn_sc
            // 
            this.btn_sc.Location = new System.Drawing.Point(6, 96);
            this.btn_sc.Name = "btn_sc";
            this.btn_sc.Size = new System.Drawing.Size(273, 23);
            this.btn_sc.TabIndex = 27;
            this.btn_sc.Text = "Start Space Clicking : Stopped";
            this.btn_sc.UseVisualStyleBackColor = true;
            this.btn_sc.Click += new System.EventHandler(this.btn_sc_Click);
            // 
            // label_click_limit_sc
            // 
            this.label_click_limit_sc.AutoSize = true;
            this.label_click_limit_sc.Location = new System.Drawing.Point(202, 79);
            this.label_click_limit_sc.Name = "label_click_limit_sc";
            this.label_click_limit_sc.Size = new System.Drawing.Size(31, 13);
            this.label_click_limit_sc.TabIndex = 26;
            this.label_click_limit_sc.Text = "1150";
            // 
            // label_latency_max_sc
            // 
            this.label_latency_max_sc.AutoSize = true;
            this.label_latency_max_sc.Location = new System.Drawing.Point(103, 79);
            this.label_latency_max_sc.Name = "label_latency_max_sc";
            this.label_latency_max_sc.Size = new System.Drawing.Size(31, 13);
            this.label_latency_max_sc.TabIndex = 25;
            this.label_latency_max_sc.Text = "1150";
            // 
            // label_latency_min_sc
            // 
            this.label_latency_min_sc.AutoSize = true;
            this.label_latency_min_sc.Location = new System.Drawing.Point(9, 79);
            this.label_latency_min_sc.Name = "label_latency_min_sc";
            this.label_latency_min_sc.Size = new System.Drawing.Size(31, 13);
            this.label_latency_min_sc.TabIndex = 24;
            this.label_latency_min_sc.Text = "1150";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(202, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Click Limit";
            // 
            // txt_click_limit_sc
            // 
            this.txt_click_limit_sc.Location = new System.Drawing.Point(202, 52);
            this.txt_click_limit_sc.Name = "txt_click_limit_sc";
            this.txt_click_limit_sc.Size = new System.Drawing.Size(75, 20);
            this.txt_click_limit_sc.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(103, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Max Latency";
            // 
            // txt_latency_max_sc
            // 
            this.txt_latency_max_sc.Location = new System.Drawing.Point(103, 52);
            this.txt_latency_max_sc.Name = "txt_latency_max_sc";
            this.txt_latency_max_sc.Size = new System.Drawing.Size(75, 20);
            this.txt_latency_max_sc.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Min Latency";
            // 
            // txt_latency_min_sc
            // 
            this.txt_latency_min_sc.Location = new System.Drawing.Point(6, 52);
            this.txt_latency_min_sc.Name = "txt_latency_min_sc";
            this.txt_latency_min_sc.Size = new System.Drawing.Size(75, 20);
            this.txt_latency_min_sc.TabIndex = 18;
            // 
            // btn_start_all
            // 
            this.btn_start_all.Location = new System.Drawing.Point(12, 501);
            this.btn_start_all.Name = "btn_start_all";
            this.btn_start_all.Size = new System.Drawing.Size(285, 23);
            this.btn_start_all.TabIndex = 28;
            this.btn_start_all.Text = "Start Everything : Stopped";
            this.btn_start_all.UseVisualStyleBackColor = true;
            this.btn_start_all.Click += new System.EventHandler(this.btn_start_all_Click);
            // 
            // timer_rc
            // 
            this.timer_rc.Interval = 2000;
            this.timer_rc.Tick += new System.EventHandler(this.timer_rc_Tick);
            // 
            // timer_qs
            // 
            this.timer_qs.Interval = 2000;
            this.timer_qs.Tick += new System.EventHandler(this.timer_qs_Tick);
            // 
            // timer_sc
            // 
            this.timer_sc.Interval = 2000;
            this.timer_sc.Tick += new System.EventHandler(this.timer_sc_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 536);
            this.Controls.Add(this.btn_start_all);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "RBot";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_show_qs;
        private System.Windows.Forms.Button btn_qs;
        private System.Windows.Forms.Label label_click_limit_qs;
        private System.Windows.Forms.Label label_latency_max_qs;
        private System.Windows.Forms.Label label_latency_min_qs;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_click_limit_qs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_latency_max_qs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_latency_min_qs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_show_sc;
        private System.Windows.Forms.Button btn_sc;
        private System.Windows.Forms.Label label_click_limit_sc;
        private System.Windows.Forms.Label label_latency_max_sc;
        private System.Windows.Forms.Label label_latency_min_sc;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_click_limit_sc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_latency_max_sc;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_latency_min_sc;
        private System.Windows.Forms.Button btn_start_all;
        private System.Windows.Forms.Timer timer_rc;
        private System.Windows.Forms.Timer timer_qs;
        private System.Windows.Forms.Timer timer_sc;

    }
}

