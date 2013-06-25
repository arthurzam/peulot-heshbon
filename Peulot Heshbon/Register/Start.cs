using System.IO;
using Form = System.Windows.Forms;

namespace Peulot_Heshbon.Register
{
    /// <summary>
    /// static class for starting the Registration Process
    /// </summary>
    internal static class Start
    {
        internal static Peulot_Heshbon.Classes.Properties properties = new Peulot_Heshbon.Classes.Properties();

        /// <summary>
        /// shows all forms to set the properties
        /// </summary>
        /// <returns></returns>
        public static bool start()
        {
            if (ChooseLanguage() == Form.DialogResult.Cancel)
                return false;
            else Languages.Convertor.ReadConvertedLanguageFile();
            if (!Welcome.ShowForm())
                return false;
            if (!propertiesDefine.ShowForm())
                return false;
            if (!propertiesDefine2.ShowForm())
                return false;
            new Finish().ShowDialog();
            return true;
        }

        /// <summary>
        /// returns the Arthur.Register.Properties object
        /// </summary>
        public static Peulot_Heshbon.Classes.Properties Properties
        {
            get { return properties; }
        }

        /// <summary>
        /// checks if the property file is good
        /// </summary>
        /// <param name="path">the file path</param>
        /// <returns>true if good, or false.</returns>
        public static bool IsRegistered(string path)
        {
            try
            {
                if (!File.Exists(path))
                    return false;
                Peulot_Heshbon.Classes.Properties.ReadFile(path);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// sets the properties by file from path
        /// </summary>
        /// <param name="path">the file path</param>
        public static void Set(string path)
        {
            properties = Peulot_Heshbon.Classes.Properties.ReadFile(path);
        }

        /// <summary>
        /// Shows a form for choosing the language file from all other files.
        /// </summary>
        /// <returns>the DialogResult of this Form</returns>
        public static Form.DialogResult ChooseLanguage()
        {
            Directory.CreateDirectory(Program.ExePath + @"\temp");
            Languages.Zip.ExtractAll(Program.ExePath + @"\Languages.dll", Program.ExePath + @"\temp");

            Form.Form form = new Form.Form();

            Form.ComboBox list_languages = new Form.ComboBox();
            Form.Label lb_text = new System.Windows.Forms.Label();
            Form.Button bt_add = new System.Windows.Forms.Button();
            Form.Button bt_ok = new System.Windows.Forms.Button();

            list_languages.Location = new System.Drawing.Point(16, 48);
            list_languages.Size = new System.Drawing.Size(266, 21);
            list_languages.TabIndex = 0;
            {
                string[] files = Directory.GetFiles(Program.ExePath + @"\temp");
                if (files.Length > 0)
                    list_languages.Text = Path.GetFileNameWithoutExtension(files[0]);
                System.Array.Sort(files);
                foreach (string a in files)
                    if (!list_languages.Items.Contains(new Form.ListViewItem(Path.GetFileNameWithoutExtension(a))))
                        list_languages.Items.Add(Path.GetFileNameWithoutExtension(a));
            }

            lb_text.AutoSize = true;
            lb_text.Location = new System.Drawing.Point(13, 13);
            lb_text.Size = new System.Drawing.Size(92, 13);
            lb_text.TabIndex = 1;
            lb_text.Text = "choose language:";
            bt_add.Location = new System.Drawing.Point(169, 94);
            bt_add.Size = new System.Drawing.Size(113, 23);
            bt_add.TabIndex = 2;
            bt_add.Text = "Add Language to list";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += delegate
            {
                string path = Program.SelectFile("XML files (*.xml)|*.xml|All files (*.*)|*.*","Open");
                if (path != null)
                {
                    string textInZip = Languages.Convertor.getLanguageText(path);
                    Languages.Convertor.ConvertToLanguageFile(path, Program.ExePath + @"\" + textInZip + ".xml");
                    Languages.Zip.AddFile(Program.ExePath + @"\" + textInZip + ".xml", textInZip + ".xml");
                    if (!list_languages.Items.Contains(Path.GetFileNameWithoutExtension(textInZip)))
                        list_languages.Items.Add(Path.GetFileNameWithoutExtension(textInZip));
                    Languages.Convertor.ChosenLanguage_FilePath = Program.ExePath + @"\temp\" + textInZip + ".xml";
                    list_languages.SelectedIndex = 0;
                    File.Delete(Program.ExePath + @"\" + textInZip + ".xml");
                }
            };

            bt_ok.Location = new System.Drawing.Point(80, 142);
            bt_ok.Size = new System.Drawing.Size(109, 35);
            bt_ok.TabIndex = 3;
            bt_ok.Text = "OK";
            bt_ok.UseVisualStyleBackColor = true;
            bt_ok.Click += delegate
            {
                form.DialogResult = Form.DialogResult.OK;
                properties.chosenLanguage = list_languages.Text;
                form.Close();
            };

            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = Form.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(303, 255);
            form.MinimumSize = new System.Drawing.Size(303, 255);
            form.MaximumSize = new System.Drawing.Size(303, 255);
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.Controls.AddRange(new Form.Control[] { list_languages, lb_text, bt_add, bt_ok });
            form.Icon = new System.Drawing.Icon(Peulot_Heshbon.Properties.Resources.App_Icon, new System.Drawing.Size(32, 32));
            form.Text = "Choose Language";
            form.ResumeLayout(false);
            form.PerformLayout();
            form.DialogResult = Form.DialogResult.Cancel;

            list_languages.Focus();

            Form.DialogResult dg = form.ShowDialog();
            Directory.Delete(Program.ExePath + @"\temp", true);

            return dg;
        }
    }
}