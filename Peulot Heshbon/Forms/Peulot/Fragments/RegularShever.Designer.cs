namespace Peulot_Heshbon.Forms.Peulot.Fragments
{
    internal partial class RegularShever
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bt_ok = new System.Windows.Forms.Button();
            this.lb_text_1 = new System.Windows.Forms.Label();
            this.lb_peula = new System.Windows.Forms.Label();
            this.tb_mahane = new System.Windows.Forms.TextBox();
            this.tb_mone = new System.Windows.Forms.TextBox();
            this.tb_mana = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lb_1_mana = new System.Windows.Forms.Label();
            this.lb_1_mone = new System.Windows.Forms.Label();
            this.lb_1_mahane = new System.Windows.Forms.Label();
            this.lb_2_mahane = new System.Windows.Forms.Label();
            this.lb_2_mone = new System.Windows.Forms.Label();
            this.lb_2_mana = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_time.Location = new System.Drawing.Point(19, 9);
            this.lb_time.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(80, 18);
            this.lb_time.TabIndex = 1;
            this.lb_time.Text = "זמן - 00:00";
            // 
            // progressBar
            // 
            this.progressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar.Location = new System.Drawing.Point(22, 291);
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeftLayout = true;
            this.progressBar.Size = new System.Drawing.Size(214, 22);
            this.progressBar.TabIndex = 14;
            // 
            // bt_ok
            // 
            this.bt_ok.Font = new System.Drawing.Font("Arial", 12F);
            this.bt_ok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_ok.Location = new System.Drawing.Point(22, 245);
            this.bt_ok.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(214, 39);
            this.bt_ok.TabIndex = 13;
            this.bt_ok.Text = "שלח";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // lb_text_1
            // 
            this.lb_text_1.AutoSize = true;
            this.lb_text_1.Font = new System.Drawing.Font("Arial", 12F);
            this.lb_text_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_text_1.Location = new System.Drawing.Point(200, 28);
            this.lb_text_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_text_1.Name = "lb_text_1";
            this.lb_text_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_text_1.Size = new System.Drawing.Size(17, 18);
            this.lb_text_1.TabIndex = 11;
            this.lb_text_1.Text = "=";
            // 
            // lb_peula
            // 
            this.lb_peula.AutoSize = true;
            this.lb_peula.Font = new System.Drawing.Font("Arial", 12F);
            this.lb_peula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_peula.Location = new System.Drawing.Point(88, 28);
            this.lb_peula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_peula.Name = "lb_peula";
            this.lb_peula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_peula.Size = new System.Drawing.Size(17, 18);
            this.lb_peula.TabIndex = 9;
            this.lb_peula.Text = "#";
            // 
            // tb_mahane
            // 
            this.tb_mahane.Location = new System.Drawing.Point(111, 148);
            this.tb_mahane.Name = "tb_mahane";
            this.tb_mahane.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_mahane.Size = new System.Drawing.Size(33, 26);
            this.tb_mahane.TabIndex = 17;
            // 
            // tb_mone
            // 
            this.tb_mone.Location = new System.Drawing.Point(111, 95);
            this.tb_mone.Name = "tb_mone";
            this.tb_mone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_mone.Size = new System.Drawing.Size(33, 26);
            this.tb_mone.TabIndex = 16;
            // 
            // tb_mana
            // 
            this.tb_mana.Location = new System.Drawing.Point(72, 120);
            this.tb_mana.Name = "tb_mana";
            this.tb_mana.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_mana.Size = new System.Drawing.Size(33, 26);
            this.tb_mana.TabIndex = 15;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lb_1_mana
            // 
            this.lb_1_mana.AutoSize = true;
            this.lb_1_mana.Location = new System.Drawing.Point(3, 28);
            this.lb_1_mana.Name = "lb_1_mana";
            this.lb_1_mana.Size = new System.Drawing.Size(26, 18);
            this.lb_1_mana.TabIndex = 18;
            this.lb_1_mana.Text = "00";
            this.lb_1_mana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_1_mone
            // 
            this.lb_1_mone.AutoSize = true;
            this.lb_1_mone.Location = new System.Drawing.Point(31, 7);
            this.lb_1_mone.Name = "lb_1_mone";
            this.lb_1_mone.Size = new System.Drawing.Size(26, 18);
            this.lb_1_mone.TabIndex = 19;
            this.lb_1_mone.Text = "00";
            this.lb_1_mone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_1_mahane
            // 
            this.lb_1_mahane.AutoSize = true;
            this.lb_1_mahane.Location = new System.Drawing.Point(31, 46);
            this.lb_1_mahane.Name = "lb_1_mahane";
            this.lb_1_mahane.Size = new System.Drawing.Size(26, 18);
            this.lb_1_mahane.TabIndex = 20;
            this.lb_1_mahane.Text = "00";
            this.lb_1_mahane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_2_mahane
            // 
            this.lb_2_mahane.AutoSize = true;
            this.lb_2_mahane.Location = new System.Drawing.Point(152, 46);
            this.lb_2_mahane.Name = "lb_2_mahane";
            this.lb_2_mahane.Size = new System.Drawing.Size(26, 18);
            this.lb_2_mahane.TabIndex = 23;
            this.lb_2_mahane.Text = "00";
            this.lb_2_mahane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_2_mone
            // 
            this.lb_2_mone.AutoSize = true;
            this.lb_2_mone.Location = new System.Drawing.Point(152, 7);
            this.lb_2_mone.Name = "lb_2_mone";
            this.lb_2_mone.Size = new System.Drawing.Size(26, 18);
            this.lb_2_mone.TabIndex = 22;
            this.lb_2_mone.Text = "00";
            this.lb_2_mone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_2_mana
            // 
            this.lb_2_mana.AutoSize = true;
            this.lb_2_mana.Location = new System.Drawing.Point(119, 28);
            this.lb_2_mana.Name = "lb_2_mana";
            this.lb_2_mana.Size = new System.Drawing.Size(26, 18);
            this.lb_2_mana.TabIndex = 21;
            this.lb_2_mana.Text = "00";
            this.lb_2_mana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_mone);
            this.panel1.Controls.Add(this.lb_2_mahane);
            this.panel1.Controls.Add(this.lb_peula);
            this.panel1.Controls.Add(this.lb_2_mone);
            this.panel1.Controls.Add(this.lb_text_1);
            this.panel1.Controls.Add(this.lb_2_mana);
            this.panel1.Controls.Add(this.tb_mana);
            this.panel1.Controls.Add(this.lb_1_mahane);
            this.panel1.Controls.Add(this.tb_mahane);
            this.panel1.Controls.Add(this.lb_1_mone);
            this.panel1.Controls.Add(this.lb_1_mana);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 177);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.RegularShever_Paint);
            // 
            // RegularShever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.lb_time);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(264, 365);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(264, 365);
            this.Name = "RegularShever";
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Label lb_text_1;
        private System.Windows.Forms.Label lb_peula;
        private System.Windows.Forms.TextBox tb_mahane;
        private System.Windows.Forms.TextBox tb_mone;
        private System.Windows.Forms.TextBox tb_mana;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lb_1_mana;
        private System.Windows.Forms.Label lb_1_mone;
        private System.Windows.Forms.Label lb_1_mahane;
        private System.Windows.Forms.Label lb_2_mahane;
        private System.Windows.Forms.Label lb_2_mone;
        private System.Windows.Forms.Label lb_2_mana;
        private System.Windows.Forms.Panel panel1;
    }
}