namespace Peulot_Heshbon.Forms.Peulot.Numbers
{
    partial class Regular
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
            this.lb_num1 = new System.Windows.Forms.Label();
            this.lb_peula = new System.Windows.Forms.Label();
            this.lb_num2 = new System.Windows.Forms.Label();
            this.lb_text_1 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(25, 9);
            this.lb_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(80, 18);
            this.lb_time.TabIndex = 0;
            this.lb_time.Text = "זמן - 00:00";
            // 
            // lb_num1
            // 
            this.lb_num1.AutoSize = true;
            this.lb_num1.Location = new System.Drawing.Point(12, 15);
            this.lb_num1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_num1.Name = "lb_num1";
            this.lb_num1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_num1.Size = new System.Drawing.Size(26, 18);
            this.lb_num1.TabIndex = 1;
            this.lb_num1.Text = "00";
            // 
            // lb_peula
            // 
            this.lb_peula.AutoSize = true;
            this.lb_peula.Location = new System.Drawing.Point(66, 15);
            this.lb_peula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_peula.Name = "lb_peula";
            this.lb_peula.Size = new System.Drawing.Size(17, 18);
            this.lb_peula.TabIndex = 2;
            this.lb_peula.Text = "#";
            // 
            // lb_num2
            // 
            this.lb_num2.AutoSize = true;
            this.lb_num2.Location = new System.Drawing.Point(116, 15);
            this.lb_num2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_num2.Name = "lb_num2";
            this.lb_num2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_num2.Size = new System.Drawing.Size(26, 18);
            this.lb_num2.TabIndex = 3;
            this.lb_num2.Text = "00";
            // 
            // lb_text_1
            // 
            this.lb_text_1.AutoSize = true;
            this.lb_text_1.Location = new System.Drawing.Point(188, 15);
            this.lb_text_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_text_1.Name = "lb_text_1";
            this.lb_text_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_text_1.Size = new System.Drawing.Size(17, 18);
            this.lb_text_1.TabIndex = 4;
            this.lb_text_1.Text = "=";
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(28, 146);
            this.tb_result.Margin = new System.Windows.Forms.Padding(4);
            this.tb_result.Name = "tb_result";
            this.tb_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_result.Size = new System.Drawing.Size(190, 26);
            this.tb_result.TabIndex = 5;
            this.tb_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(28, 192);
            this.bt_ok.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(192, 39);
            this.bt_ok.TabIndex = 6;
            this.bt_ok.Text = "שלח";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(28, 260);
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeftLayout = true;
            this.progressBar.Size = new System.Drawing.Size(192, 22);
            this.progressBar.TabIndex = 7;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_num2);
            this.panel1.Controls.Add(this.lb_num1);
            this.panel1.Controls.Add(this.lb_peula);
            this.panel1.Controls.Add(this.lb_text_1);
            this.panel1.Location = new System.Drawing.Point(17, 83);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(216, 45);
            this.panel1.TabIndex = 8;
            // 
            // Regular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 294);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.lb_time);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(253, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(253, 328);
            this.Name = "Regular";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "###";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_num1;
        private System.Windows.Forms.Label lb_peula;
        private System.Windows.Forms.Label lb_num2;
        private System.Windows.Forms.Label lb_text_1;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
    }
}