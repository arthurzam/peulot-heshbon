using System.IO;
using System.Text;

namespace Peulot_Heshbon.Classes
{
    /// <summary>
    /// class for the properties
    /// </summary>
    internal class Properties
    {
        public string FolderForData;
        public bool RememberName;
        public PersonName name;
        public Login AplicationLogin;
        public string chosenLanguage;

        /// <summary>
        /// basic constructor
        /// </summary>
        public Properties() { }

        /// <summary>
        /// creates FileStream using the path, and than reads Binary the file.
        /// </summary>
        /// <param name="path">the file path</param>
        /// <returns>Properties object which contains all properties from the file</returns>
        public static Properties ReadFile(string path)
        {
            Properties b = new Properties();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs, Encoding.UTF8);
            b.FolderForData = br.ReadString();
            b.RememberName = br.ReadBoolean();
            b.name = new PersonName(br.ReadString(), br.ReadString());
            b.AplicationLogin = new Login(br.ReadString(), br.ReadString());
            b.chosenLanguage = br.ReadString();
            br.Close();
            fs.Close();
            return b;
        }

        /// <summary>
        /// creates FileStream using the path, and than writes Binary the file.
        /// </summary>
        /// <param name="path">the file path</param>
        /// <param name="p">Properties object using which will be written the file</param>
        /// <returns>if everything goes good, returns true. else where returns false.</returns>
        public static bool WriteFile(string path, Properties p)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
                bw.Write(p.FolderForData);
                bw.Write(p.RememberName);
                { // writes the name
                    bw.Write(p.name.FirstName);
                    bw.Write(p.name.LastName);
                }
                { // writes the ApplicationLogin
                    bw.Write(p.AplicationLogin.Username);
                    bw.Write(p.AplicationLogin.Password);
                }
                bw.Write(p.chosenLanguage);
                bw.Close();
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}