namespace Peulot_Heshbon.Classes
{
    /// <summary>
    /// class for saving the properties of mark
    /// </summary>
    internal class Mark
    {
        public System.DateTime DateTime;
        public QuizType quizType;
        public int mark;
        public string name;
        public int secendsToFinish;

        public Mark() { }

        /// <summary>
        /// gets the string in format mm:ss for the time to finish
        /// </summary>
        public string FinishTime
        {
            get
            {
                string m, s;
                {
                    int i = secendsToFinish;
                    if (i % 60 >= 10)
                        s = (i % 60).ToString();
                    else
                        s = "0" + (i % 60);
                    if (i / 60 >= 10)
                        m = (i / 60).ToString();
                    else
                        m = "0" + (i / 60);
                }
                return m + ":" + s;
            }
        }
    }
}