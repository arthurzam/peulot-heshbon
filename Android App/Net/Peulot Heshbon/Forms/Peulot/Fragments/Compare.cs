using System;
using System.Windows.Forms;
using Peulot_Heshbon.Classes;
using Draw = System.Drawing;

namespace Peulot_Heshbon.Forms.Peulot.Fragments
{
    internal partial class Compare : Form
    {
        private int mark = 0; // the total mark
        private int secend = 0; // counter for secends passed from start
        private System.Random r = new System.Random(); // Random object
        private Shever num1 = new Shever(), num2 = new Shever();

        public Compare()
        {
            InitializeComponent();

            this.lb_time.Text = Languages.ChosenLanguage.Default["time"] + "00:00";
            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Icon = new Draw.Icon(Properties.Resources.App_Icon, new Draw.Size(32, 32));
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;
            this.Text = Languages.ChosenLanguage.Default["compare"] + " " + Languages.ChosenLanguage.form_main["tabPage_shever"]; ;

            bt_LBR.Click += delegate { Check(0); };
            bt_LER.Click += delegate { Check(1); };
            bt_LSR.Click += delegate { Check(2); };

            SetNumbers();
        }

        private void SetNumbers()
        {
            num1.RandomNumbers(r);
            num2.RandomNumbers(r);
            num1.Mana = num2.Mana = 0;
            num1.ToString(lb_1_mana, lb_1_mone, lb_1_mahane);
            num2.ToString(lb_2_mana, lb_2_mone, lb_2_mahane);
            Invalidate();
        }

        private void Check(byte option)
        {
            if (progressBar.Value != 100)
            {
                if (num1 > num2 && option == 0)
                    mark += 10;
                else if (num1 == num2 && option == 1)
                    mark += 10;
                else if (num1 < num2 && option == 2)
                    mark += 10;
                SetNumbers();
                progressBar.Value += 10;
            }
            else
            {
                timer.Enabled = false;
                Program.ShowRegularMessageBox(Languages.ChosenLanguage.Default["msgBox mark text"] + '\n' + mark, Languages.ChosenLanguage.Default["msgBox mark title"]);
                Code.Files.MarksFile.WriteMark(mark, new QuizType(QuestionType.Shever, "compare"), secend);
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

        private void Compare_Paint(object sender, PaintEventArgs e)
        {
            Draw.Graphics plate = e.Graphics;
            using (Draw.Pen pen = new Draw.Pen(Draw.Color.Black))
            {
                plate.DrawLine(pen, lb_1_mone.Location.X, (lb_1_mone.Location.Y + lb_1_mone.Size.Height + lb_1_mahane.Location.Y) / 2,
                    lb_1_mone.Location.X + lb_1_mone.Size.Width, (lb_1_mone.Location.Y + lb_1_mone.Size.Height + lb_1_mahane.Location.Y) / 2);    // num 1
                plate.DrawLine(pen, lb_2_mone.Location.X, (lb_2_mone.Location.Y + lb_2_mone.Size.Height + lb_2_mahane.Location.Y) / 2,
                    lb_2_mone.Location.X + lb_2_mone.Size.Width, (lb_2_mone.Location.Y + lb_2_mone.Size.Height + lb_2_mahane.Location.Y) / 2);    // num 2
            }
        }
    }
}
