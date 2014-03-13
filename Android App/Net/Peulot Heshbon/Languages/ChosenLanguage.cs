using System.Collections.Generic;

namespace Peulot_Heshbon.Languages
{
    /// <summary>
    /// This class has all the string Dictionaries that were read from the language file.
    /// </summary>
    internal static class ChosenLanguage
    {
        public static System.Windows.Forms.RightToLeft dir;

        public static Dictionary<string, string> Default = new Dictionary<string, string>();
        public static Dictionary<string, string> form_about = new Dictionary<string, string>();
        public static Dictionary<string, string> form_AllMarks_organize = new Dictionary<string, string>();
        public static Dictionary<string, string> form_askName = new Dictionary<string, string>();
        public static Dictionary<string, string> form_ChangeDifficulty = new Dictionary<string, string>();
        public static Dictionary<string, string> form_ChangeFont = new Dictionary<string, string>();
        public static Dictionary<string, string> form_contact = new Dictionary<string, string>();
        public static Dictionary<string, string> form_login = new Dictionary<string, string>();
        public static Dictionary<string, string> form_main = new Dictionary<string, string>();
        public static Dictionary<string, string> form_seeMarks = new Dictionary<string, string>();
        public static Dictionary<string, string> register = new Dictionary<string, string>();
        public static Dictionary<string, string> peula_numbers = new Dictionary<string, string>();

        /// <summary>
        /// For the Form's property - RightToLeftLayout
        /// </summary>
        public static bool dirLayout
        {
            get
            {
                return (dir == System.Windows.Forms.RightToLeft.Yes ? true : false);
            }
        }

        /// <summary>
        /// Clears all the string Dictionary
        /// </summary>
        public static void ClearAll()
        {
            Default.Clear();
            form_about.Clear();
            form_AllMarks_organize.Clear();
            form_askName.Clear();
            form_main.Clear();
            form_seeMarks.Clear();
            form_contact.Clear();
            form_login.Clear();
            form_ChangeDifficulty.Clear();
            form_ChangeFont.Clear();
            register.Clear();
            peula_numbers.Clear();
        }
    }
}