using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Peulot_Heshbon.Languages
{
    internal class Convertor
    {
        #region set the string id

        public static readonly string[] IDS = new string[] { "application name", "close", "cancel", "next", "finish", "of", "send", "yes", "no",
            "plus", "minus", "kefel", "hiluk", "random", "compare", "time", "msgBox mark title", "msgBox mark text", "title", "menu_file",
            "menu_file_name", "menu_file_save", "menu_file_exit", "menu_file_language", "menu_file_changeDifficulty","menu_file_changeFont", "menu_clear", "menu_clear_settings",
            "menu_clear_clearAllData", "menu_clear_marks", "menu_about", "menu_about_contact", "menu_about_about", "tabPage_hiuvi", "tabPage_mehuvanim",
            "tabPage_shever", "tabPage_ahuzim", "tabPage_watchResults", "watch all individual", "watch all table", "title", "label3", "label2", "button1",
            "missing", "title", "lb_username", "lb_password", "bt_submit", "cb_remember", "error1_title", "error1_text", "error2_text", "error2_title",
            "title", "lb_name", "lb_date", "lb_Time", "lb_type", "lb_mark", "lb_finishTime", "lb_difficulty", "bt_prev", "bt_next", "bt_remove",
            "error title", "error empty file", "title", "lb_productName", "lb_version", "lb_copyrights", "lb_text", "textBox_line 1", "textBox_line 2",
            "textBox_line 3", "textBox_line 4", "title", "label1", "rb_all", "rb_date", "rb_name", "rb_peula", "choose", "title", "text","title", "lb_text", "easy", "medium", "hard",
            "title","lb_text","lb_font","lb_size", "welcome title", "welcome text", "properties title", "properties label1", "properties1 label2",
            "properties1 rb_folder_auto", "properties1 rb_folder_manual", "properties1 bt_chooseFolder", "properties2 cb_oneRememberedName", 
            "properties2 label4", "finish title", "finish text", "AbleDivide title", "AbleDivide divideable" };

        #endregion set the string id

        private static readonly string[] Groups = new string[] { "default", "form[@id='main']", "form[@id='ask name']", "form[@id='login']",
                                                                 "form[@id='SeeMarks']", "form[@id='About']", "form[@id='AllMarks_organize']",
                                                                 "form[@id='contact']", "form[@id='ChangeDifficulty']", "form[@id='ChangeFont']",
                                                                 "form[@id='register']", "peula[@id='numbers']"};

        public static string ChosenLanguage_FilePath = Program.ExePath + @"\temp\" + Register.Start.Properties.chosenLanguage + @".xml";

        public static void ConvertToLanguageFile(string pathF, string pathT)
        {
            FileStream fs = new FileStream(pathT, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs, System.Text.Encoding.UTF8);

            ushort IDCheck = 0;
            XmlDocument doc = new XmlDocument();
            StreamReader sr = new StreamReader(pathF, System.Text.Encoding.UTF8);

            doc.Load(sr);

            bw.Write(doc.SelectSingleNode("/language/dir").InnerText == "rtl" ? true : false);
            for (byte i = 0; i < Groups.Length; i++)
            {
                KeyValuePair<string, string>[] temp = ReadStringGroup(doc, Groups[i]);
                for (int j = 0; j < temp.Length; j++)
                {
                    if (IDS[IDCheck] != temp[j].Key)
                    {

                        System.Windows.Forms.MessageBox.Show("Bad language file");
                        throw new IOException(Groups[i] + ";" + IDS[IDCheck] + "; is missing");
                    }
                    bw.Write(temp[j].Value);
                    IDCheck++;
                }
                bw.Write("endl");
            }
            sr.Close();
            bw.Close();
            fs.Close();
        }

        private static void PrintIDS(XmlDocument doc)
        {
            StreamWriter sw = new StreamWriter(Program.ExePath + @"\Keys.txt");
            for (byte i = 0; i < Groups.Length; i++)
            {
                KeyValuePair<string, string>[] temp = ReadStringGroup(doc, Groups[i]);
                for (int j = 0; j < temp.Length; j++)
                {
                    try
                    {
                        sw.Write("\"" + temp[j].Key + "\", ");
                    }
                    catch { throw new System.Exception(j + ""); }
                }
            }
            sw.Close();
        }

        private static void PutInDictionary(string value, string key, byte dic)
        {
            if (dic == 0) ChosenLanguage.Default.Add(key, value);
            else if (dic == 1) ChosenLanguage.form_main.Add(key, value);
            else if (dic == 2) ChosenLanguage.form_askName.Add(key, value);
            else if (dic == 3) ChosenLanguage.form_login.Add(key, value);
            else if (dic == 4) ChosenLanguage.form_seeMarks.Add(key, value);
            else if (dic == 5) ChosenLanguage.form_about.Add(key, value);
            else if (dic == 6) ChosenLanguage.form_AllMarks_organize.Add(key, value);
            else if (dic == 7) ChosenLanguage.form_contact.Add(key, value);
            else if (dic == 8) ChosenLanguage.form_ChangeDifficulty.Add(key, value);
            else if (dic == 9) ChosenLanguage.form_ChangeFont.Add(key, value);
            else if (dic == 10) ChosenLanguage.register.Add(key, value);
            else if (dic == 11) ChosenLanguage.peula_numbers.Add(key, value);
        }

        public static void ReadConvertedLanguageFile()
        {
            Directory.CreateDirectory(Program.ExePath + @"\temp");
            Zip.ExtractFile(Program.ExePath + @"\Languages.dll", Program.ExePath + @"\temp", Register.Start.Properties.chosenLanguage + @".xml");

            FileStream fs = new FileStream(ChosenLanguage_FilePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs, System.Text.Encoding.UTF8);

            ChosenLanguage.dir = (br.ReadBoolean() ? System.Windows.Forms.RightToLeft.Yes : System.Windows.Forms.RightToLeft.No);

            byte curentDic = 0;
            byte ID = 0;
            while (fs.Length != fs.Position)
            {
                string str = "";
                while ((str = br.ReadString()) != "endl")
                {
                    PutInDictionary(str, IDS[ID], curentDic);
                    ID++;
                }
                curentDic++;
            }
            br.Close();
            fs.Close();

            Directory.Delete(Program.ExePath + @"\temp", true);
        }

        private static KeyValuePair<string, string>[] ReadStringGroup(XmlDocument doc, string groupID)
        {
            string GRID = groupID;
            XmlNodeList group = doc.SelectNodes("/language/" + GRID + "/string");
            KeyValuePair<string, string>[] res = new KeyValuePair<string, string>[group.Count];
            for (int i = 0; i < group.Count; i++)
                res[i] = new KeyValuePair<string, string>(group[i].Attributes["id"].InnerText, group[i].InnerText);
            return res;
        }

        /// <summary>
        /// Gets the right text from the language file.
        /// </summary>
        /// <param name="path">the path to language file</param>
        /// <returns>the roght text</returns>
        public static string getLanguageText(string path)
        {
            if (!File.Exists(path)) return null;
            XmlDocument doc = new XmlDocument();
            StreamReader sr = new StreamReader(path);
            doc.Load(sr);
            string lan = doc.SelectSingleNode("/language/stringInEnglish").InnerText;
            string con = doc.SelectSingleNode("/language/country").InnerText;
            string result = lan + " - " + con;
            sr.Close();
            sr.Dispose();
            return result;
        }
    }
}