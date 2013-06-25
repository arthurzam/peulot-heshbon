using System;
using System.Windows.Forms;
using Peulot_Heshbon.Classes;
using Draw = System.Drawing;

namespace Peulot_Heshbon.Forms.Peulot.Fragments
{
    internal partial class RegularShever : Form
    {
        private const int QuestionsNumber = 10;

        private Peula peula, tempPeula; // the peula of form
        private int mark = 0; // the total mark
        private int secend = 0; // counter for secends passed from start
        private System.Random r = new System.Random(); // Random object
        private Shever num1 = new Shever(), num2 = new Shever();

        public RegularShever(Peula peula)
        {
            InitializeComponent();
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
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;
            this.Icon = new Draw.Icon(Properties.Resources.App_Icon, new Draw.Size(32, 32));
            bt_ok.Text = Languages.ChosenLanguage.Default["send"];

            SetNumbers();
        }

        private void SetPeula()
        {
            if (peula == Peula.random)
                tempPeula = (Peula)r.Next(0, 4);
            else
                tempPeula = peula;

            if (this.tempPeula == Peula.hibur)
            {
                lb_peula.Text = "+";
            }
            else if (this.tempPeula == Peula.hisur)
            {
                lb_peula.Text = "-";
            }
            else if (this.tempPeula == Peula.kefel)
            {
                lb_peula.Text = "*";
            }
            else if (this.tempPeula == Peula.hiluk)
            {
                lb_peula.Text = ":";
            }
        }

        private void SetNumbers()
        {
            SetPeula();
            num1.RandomNumbers(r);
            num2.RandomNumbers(r);
            if (Code.ChangeDifficulty.Difficulty == Difficulty.Easy)
            {
                if (tempPeula == Peula.hibur || tempPeula == Peula.hisur)
                    num2.RandomNumbers(r, num1.Mahane);
                num1.Mana = num2.Mana = 0;
                if (tempPeula == Peula.hisur && num1.ToDouble() < num2.ToDouble())
                {
                    Shever temp = num1;
                    num1 = num2;
                    num2 = temp;
                }
            }
            else if (Code.ChangeDifficulty.Difficulty == Difficulty.Medium)
            {
                if (tempPeula == Peula.hiluk || tempPeula == Peula.kefel)
                    num1.Mana = num2.Mana = 0;
            }
            num1.ToString(lb_1_mana, lb_1_mone, lb_1_mahane);
            num2.ToString(lb_2_mana, lb_2_mone, lb_2_mahane);
            Invalidate();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            if (progressBar.Value != 100)
            {
                Shever temp = Shever.ReturnShever(tb_mana, tb_mone, tb_mahane);

                int ma = mark;

                if (tempPeula == Peula.hibur && num1.ToDouble() + num2.ToDouble() == temp.ToDouble())
                    mark += 100 / QuestionsNumber;
                else if (tempPeula == Peula.hisur && num1.ToDouble() - num2.ToDouble() == temp.ToDouble())
                    mark += 100 / QuestionsNumber;
                else if (tempPeula == Peula.kefel && num1.ToDouble() * num2.ToDouble() == temp.ToDouble())
                    mark += 100 / QuestionsNumber;
                else if (tempPeula == Peula.hiluk && num1.ToDouble() / num2.ToDouble() == temp.ToDouble())
                    mark += 100 / QuestionsNumber;

                Text = (ma + (100 / QuestionsNumber) == mark).ToString();

                temp = null;
                SetNumbers();
                progressBar.Value += 100 / QuestionsNumber;
                tb_mana.Focus();
                tb_mana.Text = "";
                tb_mahane.Text = "";
                tb_mone.Text = "";
            }
            else
            {
                timer.Enabled = false;
                Program.ShowRegularMessageBox(Languages.ChosenLanguage.Default["msgBox mark text"] + '\n' + mark, Languages.ChosenLanguage.Default["msgBox mark title"]);
                Code.Files.MarksFile.WriteMark(mark, new QuizType(QuestionType.Shever, peula), secend);
                this.Close();
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

        private void RegularShever_Paint(object sender, PaintEventArgs e)
        {
            Draw.Graphics plate = e.Graphics;
            using (Draw.Pen pen = new Draw.Pen(Draw.Color.Black))
            {
                plate.DrawLine(pen, lb_1_mone.Location.X, (lb_1_mone.Location.Y + lb_1_mone.Size.Height + lb_1_mahane.Location.Y) / 2,
                    lb_1_mone.Location.X + lb_1_mone.Size.Width, (lb_1_mone.Location.Y + lb_1_mone.Size.Height + lb_1_mahane.Location.Y) / 2);    // num 1
                plate.DrawLine(pen, lb_2_mone.Location.X, (lb_2_mone.Location.Y + lb_2_mone.Size.Height + lb_2_mahane.Location.Y) / 2,
                    lb_2_mone.Location.X + lb_2_mone.Size.Width, (lb_2_mone.Location.Y + lb_2_mone.Size.Height + lb_2_mahane.Location.Y) / 2);    // num 2
                plate.DrawLine(pen, tb_mone.Location.X, (tb_mone.Location.Y + tb_mone.Size.Height + tb_mahane.Location.Y) / 2,
                    tb_mone.Location.X + tb_mone.Size.Width, (tb_mone.Location.Y + tb_mone.Size.Height + tb_mahane.Location.Y) / 2);  // result
            }
        }
    }
}