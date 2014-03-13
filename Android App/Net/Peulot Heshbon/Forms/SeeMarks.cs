using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Peulot_Heshbon.Forms
{
    internal partial class SeeMarks : Form
    {
        private System.Collections.Generic.List<Classes.Mark> markList;
        private int WatchingNow = 0;

        public SeeMarks()
        {
            InitializeComponent();
            markList = Code.Files.MarksFile.ReadAllMarks();

            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            Text = Languages.ChosenLanguage.form_seeMarks["title"];
            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;

            foreach (Control c in Controls)
            {
                try { c.Text = Languages.ChosenLanguage.form_seeMarks[c.Name]; }
                catch { }
            }
        }

        private void button1_Click(object sender, EventArgs e) // next
        {
            WatchingNow++;
            SetText();
        }

        private void button2_Click(object sender, EventArgs e) // prev
        {
            WatchingNow--;
            SetText();
        }

        private void button3_Click(object sender, EventArgs e) // remove
        {
            if (Code.Login.ShowLoginForm(Register.Start.Properties.AplicationLogin.Username, Register.Start.Properties.AplicationLogin.Password))
            {
                Code.Files.MarksFile.RemoveMark(WatchingNow);
                
                markList.Remove(markList[WatchingNow]);
                if (bt_prev.Visible != false)
                    button2_Click(sender, e);
                if (WatchingNow > 0) WatchingNow--;
                SetText();
            }
        }

        private void SeeMarks_Load(object sender, EventArgs e)
        {
            SetText();
        }

        private void SetText()
        {
            if (markList.Count == 0)
            {
                Program.ShowRegularMessageBox(Languages.ChosenLanguage.form_seeMarks["error empty file"] + "!", Languages.ChosenLanguage.form_seeMarks["error title"],
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            // first row
            if (WatchingNow == 0)
                bt_prev.Visible = false;
            else
                bt_prev.Visible = true;

            // last row
            if (WatchingNow == markList.Count - 1)
                bt_next.Visible = false;
            else
                bt_next.Visible = true;

            try
            {
                // date
                label5.Text = markList[WatchingNow].DateTime.ToShortDateString();

                // time
                label6.Text = markList[WatchingNow].DateTime.ToShortTimeString();

                // type
                label7.Text = markList[WatchingNow].quizType.ToString();
                label8.Text = markList[WatchingNow].mark.ToString();

                // name
                if (markList[WatchingNow].name != "unknown")
                {
                    label10.Text = markList[WatchingNow].name;
                    label10.Visible = true;
                    lb_name.Visible = true;
                }
                else
                {
                    label10.Visible = false;
                    lb_name.Visible = false;
                }
                label11.Text = markList[WatchingNow].FinishTime;
                {
                    string[] options = new string[] { Languages.ChosenLanguage.form_ChangeDifficulty["easy"],
                                                      Languages.ChosenLanguage.form_ChangeDifficulty["medium"],
                                                      Languages.ChosenLanguage.form_ChangeDifficulty["hard"]};
                    label1.Text = options[(byte)markList[WatchingNow].quizType.difficulty]; 
                }
            }
            catch (Exception)
            {
                Program.ShowRegularMessageBox(Languages.ChosenLanguage.form_seeMarks["error empty file"] + "!", Languages.ChosenLanguage.form_seeMarks["error title"],
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SeeMarks_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}