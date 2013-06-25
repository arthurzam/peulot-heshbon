using System;
using System.Windows.Forms;
using Peulot_Heshbon.Classes;
using Draw = System.Drawing;

namespace Peulot_Heshbon.Forms.Peulot.Numbers
{
    internal partial class AbleDivide : Form
    {
        private int mark = 0; // the total mark
        private int secend = 0; // counter for secends passed from start
        private System.Random r = new System.Random(); // Random object
        private int num1 = 0, num2 = 0;

        public AbleDivide()
        {
            InitializeComponent();
            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Icon = new Draw.Icon(Properties.Resources.App_Icon, new Draw.Size(32, 32));
            this.Text = Languages.ChosenLanguage.peula_numbers["AbleDivide title"];
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;

            bt_no.Text = Languages.ChosenLanguage.Default["no"];
            bt_yes.Text = Languages.ChosenLanguage.Default["yes"];

            bt_yes.Click += delegate { Check(true); };
            bt_no.Click += delegate { Check(false); };
            SetNumbers();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ++this.secend;
            string m, s;

            if (secend % 60 >= 10) s = (secend % 60).ToString();
            else s = "0" + (secend % 60);

            if (secend / 60 >= 10) m = (secend / 60).ToString();
            else m = "0" + (secend / 60);

            lb_time.Text = Languages.ChosenLanguage.Default["time"] + m + ":" + s;
        }

        private void SetNumbers()
        {
            //int temp = (r.Next(0,2) == 0?

            int[] num2options = new int[] { 2, 3, 5, 6, 9, 10, 4, 12, 15, 18, 20 };

            num2 = (Code.ChangeDifficulty.Difficulty == Difficulty.Easy ? num2options[r.Next(0, 6)] : num2options[r.Next(0, 11)]);
            num1 = (r.Next(0, 3) == 1 ? r.Next(1, 101) : num2 * r.Next(4, 16));
            lb_text.Text = num1 + " " + Languages.ChosenLanguage.peula_numbers["AbleDivide divideable"] + num2 + " ?";
        }

        private void Check(bool IsYes)
        {
            if (progressBar.Value != 100)
            {
                if (num1 / num2 * num2 == num1 && IsYes)
                    mark += 10;
                else if (num1 / num2 * num2 != num1 && !IsYes)
                    mark += 10;
                SetNumbers();
                progressBar.Value += 10;
            }
            else
            {
                timer.Enabled = false;
                Program.ShowRegularMessageBox(Languages.ChosenLanguage.Default["msgBox mark text"] + '\n' + mark, Languages.ChosenLanguage.Default["msgBox mark title"]);
                Code.Files.MarksFile.WriteMark(mark, new QuizType(QuestionType.Hiuvi, "AbleDivide"), secend);
                this.Close();
            }
        }
    }
}