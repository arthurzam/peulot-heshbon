using System;
using System.Drawing;
using System.Windows.Forms;

namespace Peulot_Heshbon.Register
{
    internal partial class propertiesDefine2 : Form
    {
        internal bool IsOk = false;

        public propertiesDefine2()
        {
            InitializeComponent();

            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));
            bt_ok.Enabled = false;
            tb_login_username.TextChanged += delegate { bt_ok.Enabled = (tb_login_password.Text != "" && tb_login_username.Text != ""); };
            tb_login_password.TextChanged += delegate { bt_ok.Enabled = (tb_login_password.Text != "" && tb_login_username.Text != ""); };

            bt_cancel.Click += delegate { this.Close(); };
            #region set from language

            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Text = Languages.ChosenLanguage.register["properties title"];
            label1.Text = Languages.ChosenLanguage.register["properties label1"];
            bt_cancel.Text = Languages.ChosenLanguage.Default["cancel"];
            bt_ok.Text = Languages.ChosenLanguage.Default["next"];
            label4.Text = string.Format(Languages.ChosenLanguage.register["properties2 label4"], '\n');
            cb_oneRememberedName.Text = Languages.ChosenLanguage.register["properties2 cb_oneRememberedName"];
            label6.Text = Languages.ChosenLanguage.form_login["lb_password"];
            label5.Text = Languages.ChosenLanguage.form_login["lb_username"];
            label2.Text = Languages.ChosenLanguage.form_askName["label2"];
            label3.Text = Languages.ChosenLanguage.form_askName["label3"];

            #endregion set from language
        }

        private void cb_oneRememberedName_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = cb_oneRememberedName.Checked;
            tb_name_f.Visible = cb_oneRememberedName.Checked;
            label3.Visible = cb_oneRememberedName.Checked;
            tb_name_l.Visible = cb_oneRememberedName.Checked;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            Start.properties.RememberName = cb_oneRememberedName.Checked;
            if (cb_oneRememberedName.Checked)
            {
                Start.properties.name.FirstName = tb_name_f.Text;
                Start.properties.name.LastName = tb_name_l.Text;
            }
            else
            {
                Start.properties.name = Peulot_Heshbon.Classes.PersonName.Empty;
            }
            Start.properties.AplicationLogin.Username = tb_login_username.Text;
            Start.properties.AplicationLogin.Password = tb_login_password.Text;
        }

        public static bool ShowForm()
        {
            if (new propertiesDefine2().ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }
    }
}