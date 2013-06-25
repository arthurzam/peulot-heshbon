namespace Peulot_Heshbon.Forms.Peulot.Fragments
{
    internal partial class Compare
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lb_1_mana = new System.Windows.Forms.Label();
            this.lb_1_mone = new System.Windows.Forms.Label();
            this.lb_1_mahane = new System.Windows.Forms.Label();
            this.lb_2_mahane = new System.Windows.Forms.Label();
            this.lb_2_mone = new System.Windows.Forms.Label();
            this.lb_2_mana = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_LBR = new System.Windows.Forms.Button();
            this.bt_LER = new System.Windows.Forms.Button();
            this.bt_LSR = new System.Windows.Forms.Button();
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
            this.progressBar.Location = new System.Drawing.Point(22, 169);
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeftLayout = true;
            this.progressBar.Size = new System.Drawing.Size(214, 22);
            this.progressBar.TabIndex = 14;
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
            this.lb_1_mana.Location = new System.Drawing.Point(12, 41);
            this.lb_1_mana.Name = "lb_1_mana";
            this.lb_1_mana.Size = new System.Drawing.Size(26, 18);
            this.lb_1_mana.TabIndex = 18;
            this.lb_1_mana.Text = "00";
            this.lb_1_mana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_1_mone
            // 
            this.lb_1_mone.AutoSize = true;
            this.lb_1_mone.Location = new System.Drawing.Point(40, 20);
            this.lb_1_mone.Name = "lb_1_mone";
            this.lb_1_mone.Size = new System.Drawing.Size(26, 18);
            this.lb_1_mone.TabIndex = 19;
            this.lb_1_mone.Text = "00";
            this.lb_1_mone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_1_mahane
            // 
            this.lb_1_mahane.AutoSize = true;
            this.lb_1_mahane.Location = new System.Drawing.Point(40, 59);
            this.lb_1_mahane.Name = "lb_1_mahane";
            this.lb_1_mahane.Size = new System.Drawing.Size(26, 18);
            this.lb_1_mahane.TabIndex = 20;
            this.lb_1_mahane.Text = "00";
            this.lb_1_mahane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_2_mahane
            // 
            this.lb_2_mahane.AutoSize = true;
            this.lb_2_mahane.Location = new System.Drawing.Point(183, 60);
            this.lb_2_mahane.Name = "lb_2_mahane";
            this.lb_2_mahane.Size = new System.Drawing.Size(26, 18);
            this.lb_2_mahane.TabIndex = 23;
            this.lb_2_mahane.Text = "00";
            this.lb_2_mahane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_2_mone
            // 
            this.lb_2_mone.AutoSize = true;
            this.lb_2_mone.Location = new System.Drawing.Point(183, 21);
            this.lb_2_mone.Name = "lb_2_mone";
            this.lb_2_mone.Size = new System.Drawing.Size(26, 18);
            this.lb_2_mone.TabIndex = 22;
            this.lb_2_mone.Text = "00";
            this.lb_2_mone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_2_mana
            // 
            this.lb_2_mana.AutoSize = true;
            this.lb_2_mana.Location = new System.Drawing.Point(150, 42);
            this.lb_2_mana.Name = "lb_2_mana";
            this.lb_2_mana.Size = new System.Drawing.Size(26, 18);
            this.lb_2_mana.TabIndex = 21;
            this.lb_2_mana.Text = "00";
            this.lb_2_mana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_LBR);
            this.panel1.Controls.Add(this.bt_LER);
            this.panel1.Controls.Add(this.lb_2_mahane);
            this.panel1.Controls.Add(this.bt_LSR);
            this.panel1.Controls.Add(this.lb_2_mone);
            this.panel1.Controls.Add(this.lb_2_mana);
            this.panel1.Controls.Add(this.lb_1_mahane);
            this.panel1.Controls.Add(this.lb_1_mone);
            this.panel1.Controls.Add(this.lb_1_mana);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 103);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Compare_Paint);
            // 
            // bt_LBR
            // 
            this.bt_LBR.Location = new System.Drawing.Point(101, 3);
            this.bt_LBR.Name = "bt_LBR";
            this.bt_LBR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_LBR.Size = new System.Drawing.Size(28, 27);
            this.bt_LBR.TabIndex = 25;
            this.bt_LBR.Text = ">";
            this.bt_LBR.UseVisualStyleBackColor = true;
            // 
            // bt_LER
            // 
            this.bt_LER.Location = new System.Drawing.Point(101, 34);
            this.bt_LER.Name = "bt_LER";
            this.bt_LER.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_LER.Size = new System.Drawing.Size(28, 27);
            this.bt_LER.TabIndex = 26;
            this.bt_LER.Text = "=";
            this.bt_LER.UseVisualStyleBackColor = true;
            // 
            // bt_LSR
            // 
            this.bt_LSR.Location = new System.Drawing.Point(101, 67);
            this.bt_LSR.Name = "bt_LSR";
            this.bt_LSR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_LSR.Size = new System.Drawing.Size(28, 27);
            this.bt_LSR.TabIndex = 27;
            this.bt_LSR.Text = "<";
            this.bt_LSR.UseVisualStyleBackColor = true;
            // 
            // Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 206);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lb_time);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Compare";
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
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lb_1_mana;
        private System.Windows.Forms.Label lb_1_mone;
        private System.Windows.Forms.Label lb_1_mahane;
        private System.Windows.Forms.Label lb_2_mahane;
        private System.Windows.Forms.Label lb_2_mone;
        private System.Windows.Forms.Label lb_2_mana;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_LBR;
        private System.Windows.Forms.Button bt_LER;
        private System.Windows.Forms.Button bt_LSR;
    }
}