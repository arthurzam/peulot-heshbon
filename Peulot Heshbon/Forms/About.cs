using System.Drawing;

namespace Peulot_Heshbon.Forms
{
    internal class About : System.Windows.Forms.Form
    {
        private System.Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

        public About()
        {
            InitializeComponent();

            this.Text = Languages.ChosenLanguage.form_about["title"];
            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));
            bt_ok.Click += delegate { Close(); };
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;

            lb_copyrights.Text = Languages.ChosenLanguage.form_about["lb_copyrights"];
            lb_productName.Text = Languages.ChosenLanguage.form_about["lb_productName"];
            lb_text.Text = Languages.ChosenLanguage.form_about["lb_text"];
            bt_ok.Text = Languages.ChosenLanguage.Default["close"];
            textBox1.Lines = new string[] { Languages.ChosenLanguage.form_about["textBox_line 1"], "",
                                            Languages.ChosenLanguage.form_about["textBox_line 2"], "",
                                            Languages.ChosenLanguage.form_about["textBox_line 3"], "",
                                            Languages.ChosenLanguage.form_about["textBox_line 4"]};
            lb_version.Text = Languages.ChosenLanguage.form_about["lb_version"] + version.Major + "." + version.Minor + (version.Build != 0 ? "." + version.Build : "");

            #region set the window size

            int width = System.Math.Max((int)Program.GetMax(lb_copyrights.Width, lb_productName.Width, lb_text.Width, lb_version.Width) + 22, 345);
            this.Size = new Size(width, Size.Height);
            this.MaximumSize = new Size(width, Size.Height);
            this.MinimumSize = new Size(width, Size.Height);
            textBox1.Width = Size.Width - 50;
            bt_ok.Location = new Point(Size.Width / 2 - bt_ok.Size.Width / 2, bt_ok.Location.Y);

            #endregion set the window size
        }

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lb_productName = new System.Windows.Forms.Label();
            this.lb_version = new System.Windows.Forms.Label();
            this.lb_copyrights = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_text = new System.Windows.Forms.Label();
            this.bt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lb_productName
            //
            this.lb_productName.AutoSize = true;
            this.lb_productName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lb_productName.Location = new System.Drawing.Point(11, 20);
            this.lb_productName.Name = "lb_productName";
            this.lb_productName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_productName.Size = new System.Drawing.Size(177, 19);
            this.lb_productName.TabIndex = 0;
            this.lb_productName.Text = "שם המוצר : פעולות חשבון";
            //
            // lb_version
            //
            this.lb_version.AutoSize = true;
            this.lb_version.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lb_version.Location = new System.Drawing.Point(12, 52);
            this.lb_version.Name = "lb_version";
            this.lb_version.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_version.Size = new System.Drawing.Size(80, 19);
            this.lb_version.TabIndex = 1;
            this.lb_version.Text = "גרסה : 1.0";
            //
            // lb_copyrights
            //
            this.lb_copyrights.AutoSize = true;
            this.lb_copyrights.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lb_copyrights.Location = new System.Drawing.Point(12, 85);
            this.lb_copyrights.Name = "lb_copyrights";
            this.lb_copyrights.Size = new System.Drawing.Size(274, 19);
            this.lb_copyrights.TabIndex = 2;
            this.lb_copyrights.Text = "זכויות שמורות לארתור זמרין, יוצר התוכנה";
            //
            // textBox1
            //
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.5F);
            this.textBox1.Location = new System.Drawing.Point(15, 141);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(305, 141);
            this.textBox1.TabIndex = 23;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "אאאאא";
            //
            // lb_text
            //
            this.lb_text.AutoSize = true;
            this.lb_text.Font = new System.Drawing.Font("Arial", 12F);
            this.lb_text.Location = new System.Drawing.Point(13, 120);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(95, 18);
            this.lb_text.TabIndex = 24;
            this.lb_text.Text = "תיאור התוכנה:";
            //
            // bt_ok
            //
            this.bt_ok.Location = new System.Drawing.Point(128, 304);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 25;
            this.bt_ok.Text = "סגור";
            this.bt_ok.UseVisualStyleBackColor = true;
            //
            // About
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 339);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_copyrights);
            this.Controls.Add(this.lb_version);
            this.Controls.Add(this.lb_productName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(353, 373);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(353, 373);
            this.Name = "About";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "אודות";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion Windows Form Designer generated code

        private System.Windows.Forms.Label lb_productName;
        private System.Windows.Forms.Label lb_version;
        private System.Windows.Forms.Label lb_copyrights;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Button bt_ok;
    }
}