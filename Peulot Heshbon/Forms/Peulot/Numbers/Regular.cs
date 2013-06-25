using System;
using System.Drawing;
using System.Windows.Forms;
using Peulot_Heshbon.Classes;

namespace Peulot_Heshbon.Forms.Peulot.Numbers
{
    internal partial class Regular : Form
    {
        private Peula peula; // the peula of form
        private int mark = 0; // the total mark
        private Targil targil; // the Targil of form
        private int secend = 0; // counter for secends passed from start
        private System.Random r = new System.Random(); // Random object
        private QuestionType qT; // the question type of form

        public Regular(Peula peula, QuestionType qType)
        {
            InitializeComponent();

            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));

            this.targil = new Targil(qType);
            this.qT = qType;
            this.targil.peula = peula;
            this.peula = peula;

            #region set title of form

            if (peula == Peula.hibur)
                this.Text = Languages.ChosenLanguage.Default["plus"];
            else if (peula == Peula.hisur)
                this.Text = Languages.ChosenLanguage.Default["minus"];
            else if (peula == Peula.kefel)
                this.Text = Languages.ChosenLanguage.Default["kefel"];
            else if (peula == Peula.hiluk)
                this.Text = Languages.ChosenLanguage.Default["hiluk"];
            else if (peula == Peula.random)
                this.Text = Languages.ChosenLanguage.Default["random"];

            #endregion set title of form

            this.lb_time.Text = Languages.ChosenLanguage.Default["time"] + "00:00";
            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            bt_ok.Text = Languages.ChosenLanguage.Default["send"];

            this.Font = Code.Files.PreferrenceFile.GetReadyFont;

            SetNumbers();
        }

        private void SetPeula()
        {
            if (this.targil.peula == Peula.hibur)
            {
                lb_peula.Text = "+";
            }
            else if (this.targil.peula == Peula.hisur)
            {
                lb_peula.Text = "-";
            }
            else if (this.targil.peula == Peula.kefel)
            {
                lb_peula.Text = "*";
            }
            else if (this.targil.peula == Peula.hiluk)
            {
                lb_peula.Text = ":";
            }
        }

        private void SetNumbers()
        {
            this.targil.RandomAll(r, peula);
            string n1, n2;
            if (targil.number1 < 0)
                n1 = "(" + targil.number1 + ")";
            else
                n1 = targil.number1 + "";
            if (targil.number2 < 0)
                n2 = "(" + targil.number2 + ")";
            else
                n2 = targil.number2 + "";
            lb_num1.Text = n1;
            lb_num2.Text = n2;
            SetPeula();
        }

        private string PeulaToString()
        {
            if (this.peula == Peula.hibur)
            {
                return "hibur";
            }
            else if (this.peula == Peula.hisur)
            {
                return "hisur";
            }
            else if (this.peula == Peula.kefel)
            {
                return "kefel_1X1";
            }
            else if (this.peula == Peula.hiluk)
            {
                return "hiluk_sheerit";
            }
            else
            {
                return "random_hiuvi";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ++this.secend;
            string m, s;
            if (secend % 60 >= 10)
                s = (secend % 60).ToString();
            else
                s = "0" + (secend % 60);
            if (secend / 60 >= 10)
                m = (secend / 60).ToString();
            else
                m = "0" + (secend / 60);
            lb_time.Text = Languages.ChosenLanguage.Default["time"] + m + ":" + s;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (progressBar.Value != 100)
            {
                if (targil.CheckAnswer(tb_result) == true)
                {
                    mark += 10;
                }
                SetNumbers();
                progressBar.Value += 10;
                tb_result.Focus();
                tb_result.Text = "";
            }
            else
            {
                timer.Enabled = false;
                Program.ShowRegularMessageBox(Languages.ChosenLanguage.Default["msgBox mark text"] + '\n' + mark, Languages.ChosenLanguage.Default["msgBox mark title"]);
                Code.Files.MarksFile.WriteMark(mark, new QuizType(qT, peula), secend);

                this.Close();
            }
        }
    }
}