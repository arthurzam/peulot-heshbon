namespace Peulot_Heshbon.Classes
{
    /// <summary>
    /// A class for functions with fragments
    /// </summary>
    internal class Shever
    {
        /// <summary>
        /// The down number of the fragment
        /// </summary>
        public int Mahane = 1;

        /// <summary>
        /// The full number
        /// </summary>
        public int Mana = 0;

        /// <summary>
        /// The up number of the fragment
        /// </summary>
        public int Mone = 0;

        /// <summary>
        /// basic constractor
        /// </summary>
        public Shever() { }

        /// <summary>
        /// constractor for full set
        /// </summary>
        /// <param name="Mana">The full number</param>
        /// <param name="Mone">The up number of the fragment</param>
        /// <param name="Mahane">The down number of the fragment</param>
        public Shever(int Mana, int Mone, int Mahane)
        {
            this.Mana = Mana;
            if (Mahane != 0)
            {
                this.Mahane = Mahane;
                this.Mone = Mone;
            }
            else
            {
                this.Mahane = 1;
                this.Mone = Mone;
            }
        }

        /// <summary>
        /// calculate the fragment minus fragment
        /// </summary>
        /// <param name="a">First fragment</param>
        /// <param name="b">Secend fragment</param>
        public static Shever operator -(Shever a, Shever b)
        {
            Shever c = new Shever();
            c.Mana = a.Mana - b.Mana;
            c.Mahane = a.Mahane * b.Mahane;
            c.Mone = a.Mone * b.Mahane - a.Mahane * b.Mone;
            if (c.Mone > c.Mahane)
            {
                int temp = c.Mone;
                c.Mone = c.Mone % c.Mahane;
                c.Mana += c.Mone / c.Mahane;
            }
            if (c.Mone < 0)
            {
                c.Mana -= 1;
                c.Mone += c.Mahane;
            }
            return c;
        }

        /// <summary>
        /// check if both fragments are not equal
        /// </summary>
        public static bool operator !=(Shever a, Shever b)
        {
            return !(a == b);
        }

        /// <summary>
        /// check if both fragments are not equal
        /// </summary>
        public static bool operator !=(double a, Shever b)
        {
            return !(a == b);
        }

        /// <summary>
        /// calculate the fragment multiple fragment
        /// </summary>
        /// <param name="a">First fragment</param>
        /// <param name="b">Secend fragment</param>
        public static Shever operator *(Shever a, Shever b)
        {
            Shever c = new Shever();
            c.Mahane = a.Mahane * b.Mahane;
            c.Mone = (a.Mana * a.Mahane + a.Mone) * (b.Mana * b.Mahane + b.Mone);
            if (c.Mone > c.Mahane)
            {
                int temp = c.Mone;
                c.Mone = c.Mone % c.Mahane;
                c.Mana += c.Mone / c.Mahane;
            }
            return c;
        }

        /// <summary>
        /// calculate the fragment divide fragment
        /// </summary>
        /// <param name="a">First fragment</param>
        /// <param name="b">Secend fragment</param>
        public static Shever operator /(Shever a, Shever b)
        {
            return a * !b;
        }

        /// <summary>
        /// calculate the fragment plus fragment
        /// </summary>
        /// <param name="a">First fragment</param>
        /// <param name="b">Secend fragment</param>
        public static double operator +(Shever a, Shever b)
        {
            Shever c = new Shever();
            c.Mana = a.Mana + b.Mana;
            c.Mahane = a.Mahane * b.Mahane;
            c.Mone = a.Mone * b.Mahane + a.Mahane * b.Mone;
            c.Tsimtsum();

            if (a.ToDouble() + b.ToDouble() != c.ToDouble())
            {
                throw new System.Exception("problem with parsing to double : " + a.ToString() + "@" + b.ToString() + "@" + c.ToString());
            }
            return c.ToDouble();
        }

        /// <summary>
        /// check if secend bigger than first
        /// </summary>
        /// <param name="a">First fragment</param>
        /// <param name="b">Secend fragment</param>
        public static bool operator <(Shever a, Shever b)
        {
            return a.ToDouble() < b.ToDouble();
        }

        /// <summary>
        /// check if both equal
        /// </summary>
        /// <param name="a">First fragment</param>
        /// <param name="b">Secend fragment</param>
        public static bool operator ==(Shever a, Shever b)
        {
            if (a.ToDouble() == b.ToDouble())
                return true;
            else
                return false;
        }

        /// <summary>
        /// check if both equal
        /// </summary>
        /// <param name="a">First double</param>
        /// <param name="b">Secend fragment</param>
        public static bool operator ==(double a, Shever b)
        {
            if (a == b.ToDouble())
                return true;
            else
                return false;
        }

        /// <summary>
        /// check if first bigger than secend
        /// </summary>
        /// <param name="a">First fragment</param>
        /// <param name="b">Secend fragment</param>
        public static bool operator >(Shever a, Shever b)
        {
            return a.ToDouble() > b.ToDouble();
        }

        public static Shever operator !(Shever a)
        {
            Shever b = new Shever();
            b.Mana = 0;
            b.Mone = a.Mahane;
            b.Mahane = a.Mana * a.Mahane + a.Mone;
            b.Tsimtsum();
            return b;
        }

        /// <summary>
        /// Parse the fragment from string
        /// </summary>
        /// <remarks>
        /// If string not proper -> returns Empty fragment
        /// </remarks>
        public static Shever Parse(string str)
        {
            try
            {
                Shever shever = new Shever();

                str.Replace("(", "");
                str.Replace(")", "");

                string[] ar = str.Split('&');
                shever.Mana = int.Parse(ar[0]);
                shever.Mone = int.Parse(ar[1]);
                shever.Mahane = int.Parse(ar[2]);

                return shever;
            }
            catch
            {
                return new Shever();
            }
        }

        /// <summary>
        /// Returns a fragment from 3 textboxes
        /// </summary>
        /// <remarks>
        /// If string not proper -> returns Empty fragment
        /// </remarks>
        public static Shever ReturnShever(System.Windows.Forms.TextBox tb_mana, System.Windows.Forms.TextBox tb_mone, System.Windows.Forms.TextBox tb_mahane)
        {
            try
            {
                if (tb_mana.Text == "") tb_mana.Text = "0";
                if (tb_mone.Text == "") tb_mone.Text = "0";
                if (tb_mahane.Text == "") tb_mahane.Text = "1";
                int a = int.Parse(tb_mana.Text), b = int.Parse(tb_mone.Text), c = int.Parse(tb_mahane.Text);
                return new Shever(a, b, c);
            }
            catch
            {
                return new Shever();
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Shever))
                return false;
            if (((Shever)obj).ToDouble() == ToDouble())
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return Mana.GetHashCode() + Mone.GetHashCode() + Mahane.GetHashCode();
        }

        /// <summary>
        /// Set all numbers randomly
        /// </summary>
        /// <param name="r">the random object</param>
        /// <param name="mahane">set the mahane or just random if empty</param>
        public void RandomNumbers(System.Random r, int mahane = -1)
        {
            this.Mana = r.Next(0, 11);
            if (mahane == -1)
                this.Mahane = r.Next(2, 11);
            else
                this.Mahane = mahane;
            this.Mone = r.Next(1, Mahane + 1);
        }

        /// <summary>
        /// Convert fragment to regular double
        /// </summary>
        public double ToDouble()
        {
            double d1 = System.Math.Round(Mana + (double)Mone / Mahane, 6);
            double d2 = System.Math.Round((double)(Mahane * Mana + Mone) / Mahane, 6);
            if (d1 != d2)
                throw new System.Exception("problem with parsing to double : " + ToString());
            return d1;
        }

        /// <summary>
        /// Set all textbox's text from the fragment
        /// </summary>
        public void ToString(System.Windows.Forms.Label mana, System.Windows.Forms.Label mone, System.Windows.Forms.Label mahane)
        {
            if (Mana != 0)
                mana.Text = Mana + "";
            else
                mana.Text = "";
            mone.Text = Mone + "";
            mahane.Text = Mahane + "";
        }

        public override string ToString()
        {
            return "(" + Mana + '&' + Mone + '&' + Mahane + ")";
        }

        public void Tsimtsum()
        {
            Shever temp = this;
            Program.WriteLog(string.Format("started tsimtsum of ({0},{1},{2})", Mana, Mone, Mahane));
            if (Mone > Mahane)
            {
                this.Mana += Mone / Mahane;
                this.Mone = Mone % Mahane;
            }
            for (int i = 2; i < Mahane; i++)
                if (Mone % i == 0 && Mahane % i == 0)
                {
                    this.Mone /= i;
                    this.Mahane /= i;
                }
            Program.WriteLog(string.Format("result of tsimtsum of ({0},{1},{2})", Mana, Mone, Mahane));
            if (temp.ToDouble() != ToDouble())
                throw new System.Exception();
        }
    }
}