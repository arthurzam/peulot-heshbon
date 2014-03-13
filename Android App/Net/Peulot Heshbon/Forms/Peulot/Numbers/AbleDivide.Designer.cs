namespace Peulot_Heshbon.Forms.Peulot.Numbers
{
    internal partial class AbleDivide
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_text = new System.Windows.Forms.Label();
            this.bt_yes = new System.Windows.Forms.Button();
            this.bt_no = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb_time.Location = new System.Drawing.Point(18, 9);
            this.lb_time.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(80, 18);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "זמן - 00:00";
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Location = new System.Drawing.Point(39, 58);
            this.lb_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(121, 18);
            this.lb_text.TabIndex = 3;
            this.lb_text.Text = "00 מתחלק ב-00?";
            // 
            // bt_yes
            // 
            this.bt_yes.Location = new System.Drawing.Point(42, 97);
            this.bt_yes.Name = "bt_yes";
            this.bt_yes.Size = new System.Drawing.Size(101, 31);
            this.bt_yes.TabIndex = 4;
            this.bt_yes.Text = "כן";
            this.bt_yes.UseVisualStyleBackColor = true;
            // 
            // bt_no
            // 
            this.bt_no.Location = new System.Drawing.Point(169, 97);
            this.bt_no.Name = "bt_no";
            this.bt_no.Size = new System.Drawing.Size(101, 31);
            this.bt_no.TabIndex = 5;
            this.bt_no.Text = "לא";
            this.bt_no.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar.Location = new System.Drawing.Point(21, 164);
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeftLayout = true;
            this.progressBar.Size = new System.Drawing.Size(249, 22);
            this.progressBar.TabIndex = 15;
            // 
            // AbleDivide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 201);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bt_no);
            this.Controls.Add(this.bt_yes);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.lb_time);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AbleDivide";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "###";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Button bt_yes;
        private System.Windows.Forms.Button bt_no;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}