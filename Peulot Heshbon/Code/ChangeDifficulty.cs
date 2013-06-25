namespace Peulot_Heshbon.Code
{
    internal partial class ChangeDifficulty : System.Windows.Forms.Form
    {
        public ChangeDifficulty()
        {
            InitializeComponent();

            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Icon = new System.Drawing.Icon(Properties.Resources.App_Icon, new System.Drawing.Size(32, 32));
            this.Text = Languages.ChosenLanguage.form_ChangeDifficulty["title"];
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;


            ddp_dif.Items.AddRange(new string[] { Languages.ChosenLanguage.form_ChangeDifficulty["easy"],
                                                  Languages.ChosenLanguage.form_ChangeDifficulty["medium"],
                                                  Languages.ChosenLanguage.form_ChangeDifficulty["hard"]});
            ddp_dif.SelectedIndex = (byte)Difficulty;

            bt_ok.Text = Languages.ChosenLanguage.Default["send"];
            lb_text.Text = Languages.ChosenLanguage.form_ChangeDifficulty["lb_text"];

            bt_ok.Click += delegate
            {
                Difficulty = (Classes.Difficulty)(byte)ddp_dif.SelectedIndex;
                this.Close();
            };
        }

        public static Classes.Difficulty Difficulty
        {
            set
            {
                Code.Files.PreferrenceFile.difficulty = value;
                Code.Files.PreferrenceFile.Update();
            }
            get
            {
                return Code.Files.PreferrenceFile.difficulty;
            }
        }

        #region designer

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
            this.lb_text = new System.Windows.Forms.Label();
            this.ddp_dif = new System.Windows.Forms.ComboBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Location = new System.Drawing.Point(12, 13);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(35, 13);
            this.lb_text.TabIndex = 0;
            this.lb_text.Text = "label1";
            // 
            // ddp_dif
            // 
            this.ddp_dif.FormattingEnabled = true;
            this.ddp_dif.Location = new System.Drawing.Point(16, 40);
            this.ddp_dif.Name = "ddp_dif";
            this.ddp_dif.Size = new System.Drawing.Size(121, 21);
            this.ddp_dif.TabIndex = 1;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(16, 67);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(121, 23);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "button1";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // ChangeDifficulty
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 102);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.ddp_dif);
            this.Controls.Add(this.lb_text);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeDifficulty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "שנה קושי";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.ComboBox ddp_dif;
        private System.Windows.Forms.Button bt_ok;

        #endregion designer
    }
}