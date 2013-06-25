using System;
using System.Drawing;
using System.Windows.Forms;

namespace Peulot_Heshbon.Register
{
    internal partial class propertiesDefine : Form
    {
        public propertiesDefine()
        {
            InitializeComponent();

            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));

            #region set from language

            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Text = Languages.ChosenLanguage.register["properties title"];
            label1.Text = Languages.ChosenLanguage.register["properties label1"];
            bt_cancel.Text = Languages.ChosenLanguage.Default["cancel"];
            bt_ok.Text = Languages.ChosenLanguage.Default["next"];
            foreach (Control c in Controls)
            {
                try { c.Text = Languages.ChosenLanguage.register["properties1 " + c.Name]; }
                catch { }
            }

            #endregion set from language
        }

        private void rb_folder_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_folder_manual.Checked)
            {
                tb_choosefolder.Visible = true;
                bt_chooseFolder.Visible = true;
            }
            else
            {
                tb_choosefolder.Visible = false;
                bt_chooseFolder.Visible = false;
            }
        }

        private void bt_chooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb_choosefolder.Text = folderBrowser.SelectedPath;
            }
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (rb_folder_auto.Checked)
                Start.properties.FolderForData = @"C:\temp\PeulotHeshbon";
            else
                Start.properties.FolderForData = folderBrowser.SelectedPath;
        }

        public static bool ShowForm()
        {
            DialogResult dr = new propertiesDefine().ShowDialog();
            if (dr == DialogResult.OK)
                return true;
            else
                return false;
        }
    }
}