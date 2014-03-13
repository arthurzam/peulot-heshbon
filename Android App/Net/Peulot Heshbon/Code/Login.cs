using System;
using System.Drawing;
using System.Windows.Forms;

namespace Peulot_Heshbon.Code
{
    internal partial class Login : Form
    {
        private Peulot_Heshbon.Classes.Login l;
        private bool IsOk = false, rem = false;
        private int numberOfTries = 8;

        public Login()
        {
            InitializeComponent();
            this.login = Peulot_Heshbon.Classes.Login.Empty;
            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Text = Languages.ChosenLanguage.form_login["title"];
            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;

            cb_remember.Text = Languages.ChosenLanguage.form_login["cb_remember"];
            bt_submit.Text = Languages.ChosenLanguage.form_login["bt_submit"];
            lb_password.Text = Languages.ChosenLanguage.form_login["lb_password"];
            lb_username.Text = Languages.ChosenLanguage.form_login["lb_username"];
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            rem = cb_remember.Checked;
            if (numberOfTries != 0)
            {
                if (tb_password.Text == login.Password && tb_username.Text == login.Username)
                {
                    IsOk = true;
                    this.Close();
                }
                else
                {
                    Program.ShowRegularMessageBox(String.Format(Languages.ChosenLanguage.form_login["error1_text"], '\n', " " + numberOfTries + " "),
                        Languages.ChosenLanguage.form_login["error1_title"], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numberOfTries--;
                }
            }
            else
            {
                Program.ShowRegularMessageBox(Languages.ChosenLanguage.form_login["error2_text"], Languages.ChosenLanguage.form_login["error2_title"],
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.FindForm().Close();
            }
        }

        public bool IsLogedIn
        {
            get { return IsOk; }
        }

        public bool Remember
        {
            get { return rem; }
        }

        public Peulot_Heshbon.Classes.Login login
        {
            get { return l; }
            set { this.l = value; }
        }

        public bool AskToSave
        {
            get { return cb_remember.Checked; }
            set { this.cb_remember.Checked = value; }
        }

        #region Method for Login Form

        public static bool IsLodeInRememmbered = false;

        /// <summary>
        /// Shows login form if not logged
        /// </summary>
        /// <param name="username">the login username</param>
        /// <param name="pass">the login password</param>
        /// <returns>if continue or not</returns>
        public static bool ShowLoginForm(string username, string pass)
        {
            if (!IsLodeInRememmbered)
            {
                Login l = new Login();
                l.login = new Peulot_Heshbon.Classes.Login(username, pass);

                l.ShowDialog();
                if (l.IsLogedIn)
                    IsLodeInRememmbered = l.Remember;
                return l.IsLogedIn;
            }
            else
            {
                return true;
            }
        }

        #endregion Method for Login Form

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
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.cb_remember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();

            //
            // lb_username
            //
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(12, 20);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(89, 18);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "שם משתמש:";

            //
            // lb_password
            //
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(12, 57);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(53, 18);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "סיסמה:";

            //
            // tb_username
            //
            this.tb_username.Location = new System.Drawing.Point(134, 17);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(122, 26);
            this.tb_username.TabIndex = 2;

            //
            // tb_password
            //
            this.tb_password.Location = new System.Drawing.Point(134, 54);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(122, 26);
            this.tb_password.TabIndex = 3;

            //
            // bt_submit
            //
            this.bt_submit.Location = new System.Drawing.Point(88, 119);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(97, 35);
            this.bt_submit.TabIndex = 4;
            this.bt_submit.Text = "התחבר";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);

            //
            // cb_remember
            //
            this.cb_remember.AutoSize = true;
            this.cb_remember.Location = new System.Drawing.Point(15, 92);
            this.cb_remember.Name = "cb_remember";
            this.cb_remember.Size = new System.Drawing.Size(77, 17);
            this.cb_remember.TabIndex = 5;
            this.cb_remember.Text = "זכור אותי";
            this.cb_remember.UseVisualStyleBackColor = true;

            //
            // LoginControl
            //
            this.ClientSize = new System.Drawing.Size(268, 166);
            this.Controls.Add(this.cb_remember);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginControl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.CheckBox cb_remember;

        #endregion designer
    }
}