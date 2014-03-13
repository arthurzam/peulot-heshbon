namespace Peulot_Heshbon.Classes
{
    /// <summary>
    /// A class for working with the quiz type
    /// </summary>
    internal struct QuizType
    {
        public QuestionType QuestionSort;
        public string Type;
        public Difficulty difficulty;

        public QuizType(QuestionType QuestionSort, string Type)
        {
            this.QuestionSort = QuestionSort;
            this.Type = Type;
            difficulty = Code.ChangeDifficulty.Difficulty;
        }

        public QuizType(QuestionType QuestionSort, Peula Type)
        {
            this.QuestionSort = QuestionSort;
            this.Type = System.Enum.GetNames(typeof(Peula))[(byte)Type];
            difficulty = Code.ChangeDifficulty.Difficulty;
        }

        public byte ConvertTypeToByte()
        {
            int result = 0;
            if (QuestionSort == QuestionType.Hiuvi || QuestionSort == QuestionType.Mehuvan || QuestionSort == QuestionType.Shever || QuestionSort == QuestionType.Ahuzim)
            {
                int res = 10 * ((byte)QuestionSort + 1);

                if (Type == "hibur") res += 0;
                else if (Type == "hisur") res += 1;
                else if (Type == "kefel") res += 2;
                else if (Type == "hiluk") res += 3;
                else if (Type == "random") res += 4;
                else if (Type == "compare") res += 5;
                else if (Type == "AbleDivide") res += 6;

                result += res;
            }
            result += 100 * (byte)Code.ChangeDifficulty.Difficulty;
            return (byte)result;
        }

        public void ConvertByteToType(byte num)
        {
            difficulty = (Difficulty)(num / 100);
            num %= 100;

            // if it is from Sort of Hiuvi / Mehuvan / Shever
            if (num < 50)
            {
                QuestionSort = (QuestionType)(num / 10 - 1);
                Type = System.Enum.GetNames(typeof(Peula))[num % 10];
            }

            else
            {
                QuestionSort = QuestionType.Other;
                Type = "???";
            }
        }

        public override string ToString()
        {
            if (QuestionSort == QuestionType.Hiuvi && Type == "AbleDivide")
                return Languages.ChosenLanguage.peula_numbers["AbleDivide title"];
            if (QuestionSort == QuestionType.Hiuvi || QuestionSort == QuestionType.Mehuvan || QuestionSort == QuestionType.Shever || QuestionSort == QuestionType.Ahuzim)
            {
                string res = "";

                if (Type == "hibur") res += Languages.ChosenLanguage.Default["plus"];
                else if (Type == "hisur") res += Languages.ChosenLanguage.Default["minus"];
                else if (Type == "kefel") res += Languages.ChosenLanguage.Default["kefel"];
                else if (Type == "hiluk") res += Languages.ChosenLanguage.Default["hiluk"];
                else if (Type == "random") res += Languages.ChosenLanguage.Default["random"];
                else if (Type == "compare") res += Languages.ChosenLanguage.Default["compare"];

                res += " - ";

                if (QuestionSort == QuestionType.Hiuvi) res += Languages.ChosenLanguage.form_main["tabPage_hiuvi"];
                else if (QuestionSort == QuestionType.Mehuvan) res += Languages.ChosenLanguage.form_main["tabPage_mehuvanim"];
                else if (QuestionSort == QuestionType.Shever) res += Languages.ChosenLanguage.form_main["tabPage_shever"];
                else if (QuestionSort == QuestionType.Ahuzim) res += Languages.ChosenLanguage.form_main["tabPage_ahuzim"];

                return res;
            }
            return "???";
        }
    }
}