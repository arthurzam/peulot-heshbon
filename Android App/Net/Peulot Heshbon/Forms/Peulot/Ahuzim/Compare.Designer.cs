namespace Peulot_Heshbon.Forms.Peulot.Ahuzim
{
    partial class Compare
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
            this.lb_time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lb_1_ahuz = new System.Windows.Forms.Label();
            this.lb_1_num = new System.Windows.Forms.Label();
            this.bt_LBR = new System.Windows.Forms.Button();
            this.bt_LER = new System.Windows.Forms.Button();
            this.bt_LSR = new System.Windows.Forms.Button();
            this.lb_2_num = new System.Windows.Forms.Label();
            this.lb_2_ahuz = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_time.Location = new System.Drawing.Point(12, 8);
            this.lb_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(60, 13);
            this.lb_time.TabIndex = 1;
            this.lb_time.Text = "זמן - 00:00";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lb_1_ahuz
            // 
            this.lb_1_ahuz.AutoSize = true;
            this.lb_1_ahuz.Location = new System.Drawing.Point(2, 43);
            this.lb_1_ahuz.Name = "lb_1_ahuz";
            this.lb_1_ahuz.Size = new System.Drawing.Size(27, 13);
            this.lb_1_ahuz.TabIndex = 2;
            this.lb_1_ahuz.Text = "00%";
            // 
            // lb_1_num
            // 
            this.lb_1_num.AutoSize = true;
            this.lb_1_num.Location = new System.Drawing.Point(43, 43);
            this.lb_1_num.Name = "lb_1_num";
            this.lb_1_num.Size = new System.Drawing.Size(41, 13);
            this.lb_1_num.TabIndex = 3;
            this.lb_1_num.Text = "מ-  000";
            // 
            // bt_LBR
            // 
            this.bt_LBR.Location = new System.Drawing.Point(112, 5);
            this.bt_LBR.Name = "bt_LBR";
            this.bt_LBR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_LBR.Size = new System.Drawing.Size(28, 27);
            this.bt_LBR.TabIndex = 4;
            this.bt_LBR.Text = "<";
            this.bt_LBR.UseVisualStyleBackColor = true;
            // 
            // bt_LER
            // 
            this.bt_LER.Location = new System.Drawing.Point(112, 36);
            this.bt_LER.Name = "bt_LER";
            this.bt_LER.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_LER.Size = new System.Drawing.Size(28, 27);
            this.bt_LER.TabIndex = 5;
            this.bt_LER.Text = "=";
            this.bt_LER.UseVisualStyleBackColor = true;
            // 
            // bt_LSR
            // 
            this.bt_LSR.Location = new System.Drawing.Point(112, 69);
            this.bt_LSR.Name = "bt_LSR";
            this.bt_LSR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_LSR.Size = new System.Drawing.Size(28, 27);
            this.bt_LSR.TabIndex = 6;
            this.bt_LSR.Text = ">";
            this.bt_LSR.UseVisualStyleBackColor = true;
            // 
            // lb_2_num
            // 
            this.lb_2_num.AutoSize = true;
            this.lb_2_num.Location = new System.Drawing.Point(203, 43);
            this.lb_2_num.Name = "lb_2_num";
            this.lb_2_num.Size = new System.Drawing.Size(41, 13);
            this.lb_2_num.TabIndex = 8;
            this.lb_2_num.Text = "מ-  000";
            // 
            // lb_2_ahuz
            // 
            this.lb_2_ahuz.AutoSize = true;
            this.lb_2_ahuz.Location = new System.Drawing.Point(162, 43);
            this.lb_2_ahuz.Name = "lb_2_ahuz";
            this.lb_2_ahuz.Size = new System.Drawing.Size(27, 13);
            this.lb_2_ahuz.TabIndex = 7;
            this.lb_2_ahuz.Text = "00%";
            // 
            // progressBar
            // 
            this.progressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar.Location = new System.Drawing.Point(15, 167);
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeftLayout = true;
            this.progressBar.Size = new System.Drawing.Size(239, 22);
            this.progressBar.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_LBR);
            this.panel1.Controls.Add(this.lb_1_ahuz);
            this.panel1.Controls.Add(this.lb_2_num);
            this.panel1.Controls.Add(this.lb_1_num);
            this.panel1.Controls.Add(this.lb_2_ahuz);
            this.panel1.Controls.Add(this.bt_LER);
            this.panel1.Controls.Add(this.bt_LSR);
            this.panel1.Location = new System.Drawing.Point(4, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 111);
            this.panel1.TabIndex = 10;
            // 
            // Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 204);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lb_time);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(277, 243);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(277, 243);
            this.Name = "Compare";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "אחוזים - השוואה";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lb_1_ahuz;
        private System.Windows.Forms.Label lb_1_num;
        private System.Windows.Forms.Button bt_LBR;
        private System.Windows.Forms.Button bt_LER;
        private System.Windows.Forms.Button bt_LSR;
        private System.Windows.Forms.Label lb_2_num;
        private System.Windows.Forms.Label lb_2_ahuz;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panel1;
    }
}