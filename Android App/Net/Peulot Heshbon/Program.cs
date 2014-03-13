using System;
using System.IO;
using System.Windows.Forms;

namespace Peulot_Heshbon
{
    internal static class Program
    {
        private static System.Collections.Generic.List<string> list = new System.Collections.Generic.List<string>();

        /// <summary>
        /// the current user name
        /// </summary>
        public static Peulot_Heshbon.Classes.PersonName name;

        /// <summary>
        /// the path to properties file
        /// </summary>
        public static string PropertiesPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\PeulotHeshbon\properties.pdb";

        /// <summary>
        /// The path to folder where the assembly is located
        /// </summary>
        public static readonly string ExePath = Application.StartupPath;

        /// <summary>
        /// the Main application. Don't call
        /// </summary>
        [STAThread]
        private static void Main()
        {
            #region Form Build

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            #endregion Form Build

            // checkes if the computer has the register / settings file
            // if true, then start register process
            // if false, then start normaly
            if (!Register.Start.IsRegistered(PropertiesPath))
            {
                StartRegisterProcess();
            }
            else
            {
                if (File.Exists(Program.ExePath + @"\Languages.dll"))
                {
                    #region normal start

                    Register.Start.Set(PropertiesPath);
                    CreateFiles();

                    Languages.Convertor.ReadConvertedLanguageFile();
                    if(File.Exists(Code.Files.PreferrenceFile.TheFile)) Code.Files.PreferrenceFile.Set();

                    if (!Register.Start.Properties.RememberName)
                    {
                        Peulot_Heshbon.Classes.PersonName pn = new Peulot_Heshbon.Classes.PersonName();
                        Code.AskName.ShowForm(ref pn);
                        name = pn;
                    }
                    else
                        name = Register.Start.Properties.name;
                    Application.Run(new main());

                    foreach (string s in list)
                        Console.WriteLine(s);

                    #endregion normal start
                }
                else
                {
                    Languages.Zip.CreateFile(Program.ExePath + @"\Languages.dll");
                    if (Register.Start.ChooseLanguage() != DialogResult.Cancel)
                    {
                        File.SetAttributes(Program.PropertiesPath, FileAttributes.Normal);
                        Peulot_Heshbon.Classes.Properties.WriteFile(Program.PropertiesPath, Register.Start.Properties);
                        File.SetAttributes(Program.PropertiesPath, FileAttributes.Hidden | FileAttributes.ReadOnly);
                        Application.Restart();
                    }
                }
            }
        }

        /// <summary>
        /// Create needed files for program.
        /// </summary>
        private static void CreateFiles()
        {
            // if the folder is the default, then check if exist
            if (Register.Start.Properties.FolderForData == @"C:\temp\PeulotHeshbon" && !Directory.Exists(@"C:\temp\PeulotHeshbon"))
                Directory.CreateDirectory(@"C:\temp\PeulotHeshbon");

            // checks if the marks file exists
            if (!File.Exists(Code.Files.MarksFile.TheFile))
                File.Create(Code.Files.MarksFile.TheFile).Close();

            // set atributes for marks file
            File.SetAttributes(Code.Files.MarksFile.TheFile, FileAttributes.ReadOnly);
        }

        private static void StartRegisterProcess()
        {
            if (Register.Start.start())
            {
                if (File.Exists(PropertiesPath))
                {
                    File.SetAttributes(PropertiesPath, FileAttributes.Normal);
                    File.Delete(PropertiesPath);
                }
                DirectoryInfo di = Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\PeulotHeshbon");
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                File.Create(PropertiesPath).Close();
                Peulot_Heshbon.Classes.Properties.WriteFile(PropertiesPath, Register.Start.Properties);
                File.SetAttributes(PropertiesPath, FileAttributes.Hidden | FileAttributes.ReadOnly);

                Application.Restart();
            }
        }

        /// <summary>
        /// Make a OpenFileDialog
        /// </summary>
        /// <param name="filter">file filter</param>
        /// <param name="title">dialog title</param>
        /// <returns>the path</returns>
        public static string SelectFile(string filter, string title = "")
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = filter;
                ofd.Multiselect = false;
                ofd.Title = title;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return ofd.FileName;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Get the max from array
        /// </summary>
        /// <param name="numbers">the numbers</param>
        /// <returns>the max</returns>
        public static double GetMax(params double[] numbers)
        {
            double max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                if (numbers[i] > max) max = numbers[i];
            return max;
        }

        public static DialogResult ShowRegularMessageBox(string text, string title = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            if (Languages.ChosenLanguage.dirLayout)
                return MessageBox.Show(text, title, buttons, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            else
                return MessageBox.Show(text, title, buttons, icon, MessageBoxDefaultButton.Button1);
        }

        public static void WriteLog(string log)
        {
            list.Add(log);
        }
    }
}