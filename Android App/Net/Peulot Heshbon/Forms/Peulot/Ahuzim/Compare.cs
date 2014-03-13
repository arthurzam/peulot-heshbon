using System;
using System.Windows.Forms;
using Draw = System.Drawing;

namespace Peulot_Heshbon.Forms.Peulot.Ahuzim
{
    internal partial class Compare : Form
    {
        /// <summary>
        /// A struct for calculating the yahas between tow ahuzim
        /// </summary>
        internal struct Part
        {
            public int num, ahuz;

            public static bool operator ==(Part a, Part b)
            {
                if (a.ahuz * a.num / 100 == b.num * b.ahuz / 100)
                    return true;
                else
                    return false;
            }

            public static bool operator !=(Part a, Part b)
            {
                return !(a == b);
            }

            public static bool operator >(Part a, Part b)
            {
                if (a.ahuz * a.num / 100 > b.num * b.ahuz / 100)
                    return true;
                else
                    return false;
            }

            public static bool operator <(Part a, Part b)
            {
                if (a.ahuz * a.num / 100 < b.num * b.ahuz / 100)
                    return true;
                else
                    return false;
            }

            public void Random(Random r)
            {
                this.num = r.Next(50 * ((int)Code.ChangeDifficulty.Difficulty + 2));
                this.ahuz = r.Next(1, 21) * 5;
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        internal enum Yahas
        {
            /// <summary>
            /// Left is bigger than Right
            /// </summary>
            LBR = 0,

            /// <summary>
            /// Left is equal to Right
            /// </summary>
            LER = 1,

            /// <summary>
            /// Left is smaller than Right
            /// </summary>
            LSR = 2
        }

        private Part part1, part2;
        private Random r = new Random();
        private int mark;
        private int secend;

        public Compare()
        {
            InitializeComponent();

            bt_LBR.Click += delegate { Check(Yahas.LBR); };
            bt_LER.Click += delegate { Check(Yahas.LER); };
            bt_LSR.Click += delegate { Check(Yahas.LSR); };
            lb_time.Text = Languages.ChosenLanguage.Default["time"] + "00:00";

            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Text = Languages.ChosenLanguage.Default["compare"] + " " + Languages.ChosenLanguage.form_main["tabPage_ahuzim"];
            this.Icon = new Draw.Icon(Properties.Resources.App_Icon, new Draw.Size(32, 32));
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;

            // The purpose of this check is to switch places the ahuz and num labels of each side
            // if the form is rightToLeft.
            if (RightToLeft == System.Windows.Forms.RightToLeft.Yes)
            {
                Draw.Point temp = lb_1_ahuz.Location;
                lb_1_ahuz.Location = lb_1_num.Location;
                lb_1_num.Location = temp;
                temp = lb_2_ahuz.Location;
                lb_2_ahuz.Location = lb_2_num.Location;
                lb_2_num.Location = temp;
            }

            if (!this.RightToLeftLayout)
            {

            }

            SetNumbers();
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

        private void SetNumbers()
        {
            part1.Random(r);
            part2.Random(r);

            string of = Languages.ChosenLanguage.Default["of"];
            lb_1_ahuz.Text = part1.ahuz + "%";
            lb_1_num.Text = of + part1.num;
            lb_2_ahuz.Text = part2.ahuz + "%";
            lb_2_num.Text = of + part2.num;
        }

        private void Check(Yahas yahas)
        {
            if (progressBar.Value + 10 != 110)
            {
                this.Text = "true";
                if (part1 < part2 && yahas == Yahas.LBR)
                    mark += 10;
                else if (part1 == part2 && yahas == Yahas.LER)
                    mark += 10;
                else if (part1 > part2 && yahas == Yahas.LSR)
                    mark += 10;
                else
                    this.Text = "false";
                SetNumbers();
                progressBar.Value += 10;
            }
            else
            {
                timer.Enabled = false;
                Program.ShowRegularMessageBox(Languages.ChosenLanguage.Default["msgBox mark text"] + '\n' + mark, Languages.ChosenLanguage.Default["msgBox mark title"]);
                Code.Files.MarksFile.WriteMark(mark, new Classes.QuizType(Classes.QuestionType.Ahuzim,"compare"), secend);
                this.Close();
            }
        }
    }
}