using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Peulot_Heshbon
{
    internal partial class main : Form
    {
        private Peulot_Heshbon.Classes.QuestionType queType = Classes.QuestionType.Hiuvi;

        public main()
        {
            InitializeComponent();
            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));
            this.Font = menu.Font = Code.Files.PreferrenceFile.GetReadyFont;

            this.Paint += delegate
            {
                button13.Enabled = (Code.ChangeDifficulty.Difficulty == Classes.Difficulty.Easy);
                button16.Enabled = (Code.ChangeDifficulty.Difficulty != Classes.Difficulty.Hard);
            };

            this.tabControl_pages.SelectedIndexChanged += delegate { this.queType = (Peulot_Heshbon.Classes.QuestionType)tabControl_pages.SelectedIndex; };
            this.menu_file_exit.Click += delegate { this.Close(); };
            this.menu_file_language.Click += delegate
            {
                if (Register.Start.ChooseLanguage() != DialogResult.Cancel)
                {
                    File.SetAttributes(Program.PropertiesPath, FileAttributes.Normal);
                    Peulot_Heshbon.Classes.Properties.WriteFile(Program.PropertiesPath, Register.Start.Properties);
                    File.SetAttributes(Program.PropertiesPath, FileAttributes.Hidden | FileAttributes.ReadOnly);
                    Application.Restart();
                }
            };

            menu_file_changeDifficulty.Click += delegate { ShowForm(new Code.ChangeDifficulty()); };
            menu_file_changeFont.Click += delegate
            {
                ShowForm(new Code.ChooseFont());
                this.Font = menu.Font = Code.Files.PreferrenceFile.GetReadyFont;
            };

            #region set text for everything from <languages>.xml

            #region form text / dir

            this.Text = Languages.ChosenLanguage.form_main["title"];
            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;

            #endregion form text / dir

            #region menu

            foreach (ToolStripItem item in menu.Items)
                if (!(item is ToolStripSeparator))
                {
                    item.Text = Languages.ChosenLanguage.form_main[item.Name];
                    if (((ToolStripMenuItem)item).HasDropDownItems)
                        foreach (ToolStripItem i in ((ToolStripMenuItem)item).DropDownItems)
                            if (!(i is ToolStripSeparator))
                            {
                                try { i.Text = Languages.ChosenLanguage.form_main[i.Name]; }
                                catch { }
                            }
                }

            #endregion menu

            #region tab page

            foreach (TabPage tab in tabControl_pages.Controls)
                tab.Text = Languages.ChosenLanguage.form_main[tab.Name];

            #endregion tab page

            #region open window buttons

            button1.Text = Languages.ChosenLanguage.form_main["watch all individual"];
            button3.Text = Languages.ChosenLanguage.form_main["watch all table"];

            button9.Text = button5.Text = bt_hibur.Text = Languages.ChosenLanguage.Default["plus"];

            button4.Text = button2.Text = bt_minus.Text = Languages.ChosenLanguage.Default["minus"];

            button11.Text = button7.Text = bt_kefel.Text = Languages.ChosenLanguage.Default["kefel"];

            button12.Text = button8.Text = bt_hiluk.Text = Languages.ChosenLanguage.Default["hiluk"];

            button10.Text = button6.Text = bt_randomPeula.Text = Languages.ChosenLanguage.Default["random"];

            button16.Text = Languages.ChosenLanguage.peula_numbers["AbleDivide title"];

            bt_ahuz_hashvaa.Text = button13.Text = Languages.ChosenLanguage.Default["compare"];

            #endregion open window buttons

            #endregion set text for everything from <languages>.xml

            #region set button click event

            bt_ahuz_hashvaa.Click += delegate { ShowForm(new Forms.Peulot.Ahuzim.Compare()); };
            button16.Click += delegate { ShowForm(new Forms.Peulot.Numbers.AbleDivide()); };

            #region watch results

            button1.Click += delegate { ShowForm(new Forms.SeeMarks()); };
            button3.Click += delegate { ShowForm(new Forms.AllMarks_organize()); };

            #endregion watch results

            #region about submenu

            menu_about_about.Click += delegate { ShowForm(new Forms.About()); };
            menu_about_contact.Click += delegate { ShowForm(new Forms.Contact()); };

            #endregion about submenu

            #endregion set button click event
        }

        #region Hiuvi / Mehuvan / Shever (tab) Buttons

        private void bt_hibur_Click(object sender, EventArgs e)
        {
            if (queType == Classes.QuestionType.Shever)
                ShowForm(new Peulot_Heshbon.Forms.Peulot.Fragments.RegularShever(Classes.Peula.hibur));
            else
                ShowForm(new Peulot_Heshbon.Forms.Peulot.Numbers.Regular(Classes.Peula.hibur, queType));
        }

        private void bt_minus_Click(object sender, EventArgs e)
        {
            if (queType == Classes.QuestionType.Shever)
                ShowForm(new Peulot_Heshbon.Forms.Peulot.Fragments.RegularShever(Classes.Peula.hisur));
            else
                ShowForm(new Peulot_Heshbon.Forms.Peulot.Numbers.Regular(Classes.Peula.hisur, queType));
        }

        private void bt_kefel_Click(object sender, EventArgs e)
        {
            if (queType == Classes.QuestionType.Shever)
                ShowForm(new Peulot_Heshbon.Forms.Peulot.Fragments.RegularShever(Classes.Peula.kefel));
            else
                ShowForm(new Peulot_Heshbon.Forms.Peulot.Numbers.Regular(Classes.Peula.kefel, queType));
        }

        private void bt_hiluk_Click(object sender, EventArgs e)
        {
            if (queType == Classes.QuestionType.Shever)
                ShowForm(new Peulot_Heshbon.Forms.Peulot.Fragments.RegularShever(Classes.Peula.hiluk));
            else
                ShowForm(new Peulot_Heshbon.Forms.Peulot.Numbers.Regular(Classes.Peula.hiluk, queType));
        }

        private void bt_randomPeula_Click(object sender, EventArgs e)
        {
            if (queType == Classes.QuestionType.Shever)
                ShowForm(new Peulot_Heshbon.Forms.Peulot.Fragments.RegularShever(Classes.Peula.random));
            else
                ShowForm(new Peulot_Heshbon.Forms.Peulot.Numbers.Regular(Classes.Peula.random, queType));
        }

        private void bt_compare_Click(object sender, EventArgs e)
        {
            if (queType == Classes.QuestionType.Shever)
                ShowForm(new Peulot_Heshbon.Forms.Peulot.Fragments.Compare());
        }

        #endregion Hiuvi / Mehuvan / Shever (tab) Buttons

        #region menu

        #region File submenu

        /// <summary>
        /// reaction for click on menu -> file -> change name
        /// </summary>
        private void menu_file_name_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Peulot_Heshbon.Classes.PersonName pn = new Peulot_Heshbon.Classes.PersonName();
            Code.AskName.ShowForm(ref pn);
            Program.name = pn;
            this.Enabled = true;
        }

        /// <summary>
        /// reaction for click on menu -> file -> save
        /// </summary>
        /// <remarks>
        /// it shows a "save file dialog", and chooses the save type by the extention
        /// </remarks>
        private void menu_file_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Filter = "text file (*.txt)|*.txt|Excel File 97-2003 Worksheet (*.xls)|*.xls";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK && sfd.FileName != "")
            {
                if (Path.GetExtension(sfd.FileName) == ".txt")
                {
                    #region txt File

                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.WriteLine("date_time_type_mark_name_time");
                    sw.WriteLine("===========================");
                    foreach (Classes.Mark mark in Code.Files.MarksFile.ReadAllMarks())
                    {
                        sw.WriteLine(mark.DateTime.ToShortDateString() + '_' + mark.DateTime.ToLongTimeString() + '_' + mark.quizType.ToString() + '_'
                            + mark.mark + '_' + mark.name + "_" + mark.secendsToFinish);
                    }
                    sw.Close();

                    #endregion txt File
                }
                else if (Path.GetExtension(sfd.FileName) == ".xls")
                {
                    #region excel File

                    ExcelLibrary.SpreadSheet.Workbook workbook = new ExcelLibrary.SpreadSheet.Workbook();
                    ExcelLibrary.SpreadSheet.Worksheet worksheet = new ExcelLibrary.SpreadSheet.Worksheet("ציונים");

                    { // writes columns
                        string[] columnsName = new string[] { "שם פרטי", "שם משפחה", "תאריך", "שעה", "סוג הבוחן", "ציון", "משך הבחינה" };
                        for (int i = 0; i < columnsName.Length; i++)
                        {
                            worksheet.Cells[0, i] = new ExcelLibrary.SpreadSheet.Cell(columnsName[i]);
                        }
                    }

                    { // writes all marks
                        List<Classes.Mark> list = Code.Files.MarksFile.ReadAllMarks();
                        for (int i = 0; i < list.Count; i++)
                        {
                            Classes.Mark m = list[i];
                            Peulot_Heshbon.Classes.PersonName pn = Peulot_Heshbon.Classes.PersonName.Parse(m.name.Replace(' ', '_'));
                            worksheet.Cells[i + 1, 0] = new ExcelLibrary.SpreadSheet.Cell(pn.FirstName); // first name
                            worksheet.Cells[i + 1, 1] = new ExcelLibrary.SpreadSheet.Cell(pn.LastName); // first name
                            worksheet.Cells[i + 1, 2] = new ExcelLibrary.SpreadSheet.Cell(m.DateTime.ToShortDateString()); // date
                            worksheet.Cells[i + 1, 3] = new ExcelLibrary.SpreadSheet.Cell(m.DateTime.ToShortTimeString()); // date
                            worksheet.Cells[i + 1, 4] = new ExcelLibrary.SpreadSheet.Cell(m.quizType.ToString()); // type
                            worksheet.Cells[i + 1, 5] = new ExcelLibrary.SpreadSheet.Cell(m.mark); // mark
                            worksheet.Cells[i + 1, 6] = new ExcelLibrary.SpreadSheet.Cell(m.secendsToFinish); // duaranceTime
                        }
                    }
                    workbook.Worksheets.Add(worksheet);
                    workbook.Save(sfd.FileName);

                    #endregion excel File
                }
            }
        }

        #endregion File submenu

        #region Clear submenu

        /// <summary>
        /// reaction for click on menu -> clear -> clear marks.dat
        /// </summary>
        private void menu_clear_marks_Click(object sender, EventArgs e)
        {
            if (Code.Login.ShowLoginForm(Register.Start.Properties.AplicationLogin.Username, Register.Start.Properties.AplicationLogin.Password))
                Code.Files.MarksFile.ClearFile();
        }

        /// <summary>
        /// reaction for click on menu -> clear -> clear settings
        /// </summary>
        private void menu_clear_settings_Click(object sender, EventArgs e)
        {
            if (Code.Login.ShowLoginForm(Register.Start.Properties.AplicationLogin.Username, Register.Start.Properties.AplicationLogin.Password))
            {
                File.SetAttributes(Program.PropertiesPath, FileAttributes.Normal);
                File.Delete(Program.PropertiesPath);
                this.Close();
                Application.Restart();
            }
        }

        /// <summary>
        /// removes al program data from computer: marks file and properies file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_clear_clearAllData_Click(object sender, EventArgs e)
        {
            if (Code.Login.ShowLoginForm(Register.Start.Properties.AplicationLogin.Username, Register.Start.Properties.AplicationLogin.Password))
            {
                File.SetAttributes(Code.Files.MarksFile.TheFile, FileAttributes.Normal);
                File.Delete(Code.Files.MarksFile.TheFile);

                File.SetAttributes(Program.PropertiesPath, FileAttributes.Normal);
                File.Delete(Program.PropertiesPath);

                this.Close();

                Application.Restart();
            }
        }

        #endregion Clear submenu

        #endregion menu

        private void ShowForm(Form form)
        {
            this.Enabled = false;
            form.ShowDialog();
            this.Enabled = true;
        }
    }
}