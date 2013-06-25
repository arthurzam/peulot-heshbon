namespace Peulot_Heshbon.Code
{
    partial class ChooseFont
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
            this.lb_text = new System.Windows.Forms.Label();
            this.lb_font = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_size = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Location = new System.Drawing.Point(12, 13);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(56, 13);
            this.lb_text.TabIndex = 0;
            this.lb_text.Text = "בחר גופן:";
            // 
            // lb_font
            // 
            this.lb_font.AutoSize = true;
            this.lb_font.Location = new System.Drawing.Point(33, 41);
            this.lb_font.Name = "lb_font";
            this.lb_font.Size = new System.Drawing.Size(36, 13);
            this.lb_font.TabIndex = 1;
            this.lb_font.Text = "גופן: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // lb_size
            // 
            this.lb_size.AutoSize = true;
            this.lb_size.Location = new System.Drawing.Point(33, 84);
            this.lb_size.Name = "lb_size";
            this.lb_size.Size = new System.Drawing.Size(38, 13);
            this.lb_size.TabIndex = 3;
            this.lb_size.Text = "גודל: ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(104, 131);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(99, 23);
            this.bt_ok.TabIndex = 5;
            this.bt_ok.Text = "button1";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // ChooseFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 166);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lb_size);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_font);
            this.Controls.Add(this.lb_text);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseFont";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ChooseFont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Label lb_font;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_size;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button bt_ok;
    }
}