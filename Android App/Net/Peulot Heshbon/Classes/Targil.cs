using System;

namespace Peulot_Heshbon.Classes
{
    /// <summary>
    /// a class for working with targilim
    /// </summary>
    internal class Targil
    {
        public int number1;
        public Peula peula;
        public int number2;
        public int answer;
        private int qType = 1;

        /// <summary>
        /// basic constructor
        /// </summary>
        /// <param name="QType">the question type to the targil : Hiuvi or Mehuvan</param>
        public Targil(QuestionType QType)
        {
            if (QType == QuestionType.Mehuvan)
                this.qType = -1;
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="num1">the first number</param>
        /// <param name="p">the peula</param>
        /// <param name="num2">the secend number</param>
        /// <param name="QType">the question type to the targil : Hiuvi or Mehuvan</param>
        public Targil(int num1, Peula p, int num2, QuestionType QType)
        {
            number1 = num1;
            number2 = num2;
            peula = p;
            if (p == Peula.hibur)
                answer = num1 + num2;
            else if (p == Peula.hisur)
                answer = num1 - num2;
            else if (p == Peula.kefel)
                answer = num1 * num2;
            else if (p == Peula.hiluk)
                answer = num1 / num2;
            if (QType == QuestionType.Mehuvan)
                this.qType = -1;
        }

        /// <summary>
        /// Function for setting numbers
        /// </summary>
        /// <param name="num1">first number</param>
        /// <param name="num2">secend number</param>
        public void Set(int num1, int num2)
        {
            Set(num1, peula, num2);
        }

        /// <summary>
        /// Function for setting the targil
        /// </summary>
        /// <param name="num1">first number</param>
        /// <param name="p">the peula</param>
        /// <param name="num2">secend number</param>
        public void Set(int num1, Peula p, int num2)
        {
            number1 = num1;
            number2 = num2;
            peula = p;
            if (p == Peula.hibur)
                answer = num1 + num2;
            else if (p == Peula.hisur)
                answer = num1 - num2;
            else if (p == Peula.kefel)
                answer = num1 * num2;
            else if (p == Peula.hiluk)
                answer = num1 / num2;
        }

        /// <summary>
        /// checks if the answer is correct acording to the targil
        /// </summary>
        /// <param name="a">the answer</param>
        /// <returns>true if correct, or false.</returns>
        public bool CheckAnswer(int a)
        {
            if (a == answer)
                return true;
            else
                return false;
        }

        /// <summary>
        /// checks if the string contains the right answer acording to the targil
        /// </summary>
        /// <param name="a">the string</param>
        /// <returns>true if correct, or false.</returns>
        public bool CheckAnswer(string a)
        {
            int a1;
            if (int.TryParse(a, out a1))
                return CheckAnswer(a1);
            else
                return false;
        }

        /// <summary>
        /// checks if the string from textbox is containing the right answer
        /// </summary>
        /// <param name="a">the textbox</param>
        /// <returns>true if correct, or false.</returns>
        public bool CheckAnswer(System.Windows.Forms.TextBox a)
        {
            return CheckAnswer(a.Text);
        }

        /// <summary>
        /// Randoms the targil
        /// </summary>
        /// <param name="r">the random object</param>
        /// <param name="p">the peula</param>
        public void RandomAll(Random r, Peula p)
        {
            if (p == Peula.hibur)
            {
                int x = 50 * ((byte)Code.ChangeDifficulty.Difficulty + 2);
                if (qType == 1)
                    Set(r.Next(1, x), p, r.Next(1, x));
                else
                    Set(r.Next(-x - 1, x), p, r.Next(-x - 1, x));
            }

            else if (p == Peula.hisur)
            {
                if (qType == 1)
                {
                    int num1 = r.Next(1, 50 * ((byte)Code.ChangeDifficulty.Difficulty + 2));
                    int num2 = r.Next(1, num1);
                    Set(num1, p, num2);
                }
                else
                {
                    int num1 = r.Next(-50 * ((byte)Code.ChangeDifficulty.Difficulty + 1), 50 * ((byte)Code.ChangeDifficulty.Difficulty + 2));
                    int num2 = r.Next(-50 * ((byte)Code.ChangeDifficulty.Difficulty + 2), num1);
                    Set(num1, p, num2);
                }
            }

            else if (p == Peula.kefel)
            {
                int x = 10 * ((byte)Code.ChangeDifficulty.Difficulty + 1);
                if (qType == 1)
                    Set(r.Next(1, x + 1), p, r.Next(1, x + 1));
                else
                    Set(r.Next(-x, x + 1), p, r.Next(-x, x + 1));
            }

            else if (p == Peula.hiluk)
            {
                int x = 5 * ((byte)Code.ChangeDifficulty.Difficulty + 2);
                if (qType == 1)
                {
                    int num2 = r.Next(1, x + 1);
                    int num1 = r.Next(1, x + 1) * num2;
                    Set(num1, p, num2);
                }
                else
                {
                    int num2 = (r.Next(0, 2) == 0 ? -1 : 1) * r.Next(1, x + 1);
                    int num1 = r.Next(-x, x + 1) * num2;
                    Set(num1, p, num2);
                }
            }
            else
            {
                RandomAll(r, (Peula)r.Next(0, 4));
            }
        }

        public override string ToString()
        {
            return string.Format("({0}&{1}&{2}&{3})", number1, (byte)peula, number2, (int)qType);
        }

        public string ToSpecialString()
        {
            string peu = "";
            if (peula == Peula.hibur) peu = "+";
            else if (peula == Peula.hisur) peu = "-";
            else if (peula == Peula.kefel) peu = "*";
            else if (peula == Peula.hiluk) peu = "/";
            return string.Format("{0} {1} {2}", number1, peu, number2);
        }

        public static Targil Parse(string txt)
        {
            try
            {
                Targil t = new Targil(0);
                txt.Replace("(", "");
                txt.Replace(")", "");

                string[] ar = txt.Split('&');
                t.number1 = int.Parse(ar[0]);
                t.number2 = int.Parse(ar[2]);
                t.peula = (Peula)byte.Parse(ar[1]);
                t.qType = int.Parse(ar[3]);

                return t;
            }
            catch { return new Targil(0); }
        }
    }
}