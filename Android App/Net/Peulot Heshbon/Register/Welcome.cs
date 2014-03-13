using System;
using System.Drawing;
using System.Windows.Forms;

namespace Peulot_Heshbon.Register
{
    internal class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));
            bt_cancel.Click += delegate { this.Close(); };
            bt_ok.Click += delegate { this.Close(); };

            #region set from language

            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Text = Languages.ChosenLanguage.register["welcome title"];
            this.textBox1.Lines = string.Format(Languages.ChosenLanguage.register["welcome text"], '$').Split('$');
            bt_cancel.Text = Languages.ChosenLanguage.Default["cancel"];
            bt_ok.Text = Languages.ChosenLanguage.Default["next"];

            #endregion set from language
        }

        public static bool ShowForm()
        {
            DialogResult dr = new Welcome().ShowDialog();
            if (dr == DialogResult.OK)
                return true;
            else
                return false;
        }

        #region Designer

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.5F);
            this.textBox1.Location = new System.Drawing.Point(15, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(289, 90);
            this.textBox1.TabIndex = 24;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "בתהליך התקנה זה אתם תתקינו את התוכנה \"פעולות חשבון\".\r\nמטרת התוכנה לימוד תלמידי בי" +
                "ת ספר יסודי חשבון.";
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Location = new System.Drawing.Point(215, 217);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 25;
            this.bt_ok.Text = "הבא >";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(134, 217);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 26;
            this.bt_cancel.Text = "ביטול";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_cancel;
            this.ClientSize = new System.Drawing.Size(316, 262);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.textBox1);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ברוך הבא";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancel;

        #endregion Designer
    }
}