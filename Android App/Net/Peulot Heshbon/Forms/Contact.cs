using System.Drawing;

namespace Peulot_Heshbon.Forms
{
    internal partial class Contact : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;

        public Contact()
        {
            InitializeComponent();

            this.textBox1.Lines = string.Format(Languages.ChosenLanguage.form_contact["text"], '$', Data.Email).Split('$');
            this.Text = Languages.ChosenLanguage.form_contact["title"];
            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));
            this.bt_ok.Text = Languages.ChosenLanguage.Default["close"];
            this.bt_ok.Click += delegate { this.Close(); };
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;
        }

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
            this.bt_ok = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(172, 128);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 26;
            this.bt_ok.Text = "סגור";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.5F);
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(377, 95);
            this.textBox1.TabIndex = 27;
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 168);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_ok);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Contact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "יצירת קשר";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button bt_ok;
    }
}