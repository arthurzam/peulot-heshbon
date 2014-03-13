namespace Peulot_Heshbon.Register
{
    internal class Finish : System.Windows.Forms.Form
    {
        public Finish()
        {
            InitializeComponent();

            button1.Click += delegate { this.Close(); };
            this.Icon = new System.Drawing.Icon(Properties.Resources.App_Icon, new System.Drawing.Size(32, 32));

            #region set from language

            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Text = Languages.ChosenLanguage.register["finish title"];

            textBox1.Lines = string.Format(Languages.ChosenLanguage.register["finish text"], '$', "arthurzam@gmail.com").Split('$');
            button1.Text = Languages.ChosenLanguage.Default["finish"];

            #endregion set from language
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            //
            // textBox1
            //
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(268, 114);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "תודה שהתקנתם את התוכנה \"פעולות חשבון\".\r\n\r\nפרטים אם נתקלתם בבעיה (ניתן למצוא אותם " +
                "גם בתוכנה בקטגוריה \"אודות\"):\r\nדואר אלקטרוני : arthurzam@gmail.com\r\n\r\nכדי להשתמש " +
                "בתוכנה, הפעילו אותה מחדש.\r\nבהצלחה!";

            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(189, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "סיום";
            this.button1.UseVisualStyleBackColor = true;

            //
            // Finish
            //
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 179);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 213);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 213);
            this.Name = "Finish";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "סיום";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

        #endregion Designer
    }
}