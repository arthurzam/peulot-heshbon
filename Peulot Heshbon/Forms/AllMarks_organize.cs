using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Peulot_Heshbon.Forms
{
    internal partial class AllMarks_organize : Form
    {
        private DataTable dt = new DataTable();
        private DataColumn[] columns = new DataColumn[7];
        private string choose = Languages.ChosenLanguage.form_AllMarks_organize["choose"];
        private string[] DifficultyOptions = new string[3];

        public AllMarks_organize()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;

            DifficultyOptions = new string[] { Languages.ChosenLanguage.form_ChangeDifficulty["easy"],
                                               Languages.ChosenLanguage.form_ChangeDifficulty["medium"],
                                               Languages.ChosenLanguage.form_ChangeDifficulty["hard"]};

            #region Column set

            columns[6] = new DataColumn();
            columns[6].Caption = Languages.ChosenLanguage.form_seeMarks["lb_finishTime"];
            columns[6].ColumnName = Languages.ChosenLanguage.form_seeMarks["lb_finishTime"];
            columns[6].DataType = typeof(string);

            columns[5] = new DataColumn();
            columns[5].Caption = Languages.ChosenLanguage.form_seeMarks["lb_mark"];
            columns[5].ColumnName = Languages.ChosenLanguage.form_seeMarks["lb_mark"];
            columns[5].DataType = typeof(string);

            columns[4] = new DataColumn();
            columns[4].Caption = Languages.ChosenLanguage.form_seeMarks["lb_difficulty"];
            columns[4].ColumnName = Languages.ChosenLanguage.form_seeMarks["lb_difficulty"];
            columns[4].DataType = typeof(string);

            columns[3] = new DataColumn();
            columns[3].Caption = Languages.ChosenLanguage.form_seeMarks["lb_type"];
            columns[3].ColumnName = Languages.ChosenLanguage.form_seeMarks["lb_type"];
            columns[3].DataType = typeof(string);

            columns[2] = new DataColumn();
            columns[2].Caption = Languages.ChosenLanguage.form_seeMarks["lb_Time"];
            columns[2].ColumnName = Languages.ChosenLanguage.form_seeMarks["lb_Time"];
            columns[2].DataType = typeof(string);

            columns[1] = new DataColumn();
            columns[1].Caption = Languages.ChosenLanguage.form_seeMarks["lb_date"];
            columns[1].ColumnName = Languages.ChosenLanguage.form_seeMarks["lb_date"];
            columns[1].DataType = typeof(string);

            columns[0] = new DataColumn();
            columns[0].Caption = Languages.ChosenLanguage.form_seeMarks["lb_name"];
            columns[0].ColumnName = Languages.ChosenLanguage.form_seeMarks["lb_name"];
            columns[0].DataType = typeof(string);

            #endregion Column set

            #region set from language file

            rb_all.RightToLeft = rb_date.RightToLeft = rb_name.RightToLeft = rb_peula.RightToLeft = Languages.ChosenLanguage.dir;

            foreach (Control c in this.Controls)
            {
                try { c.Text = Languages.ChosenLanguage.form_AllMarks_organize[c.Name]; }
                catch { }
                if (c is ComboBox)
                {
                    c.Text = choose;
                    c.RightToLeft = Languages.ChosenLanguage.dir;
                }
            }

            this.Text = Languages.ChosenLanguage.form_AllMarks_organize["title"];
            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.dataGridView1.RightToLeft = Languages.ChosenLanguage.dir;

            #endregion set from language file
        }

        private void AllMarks_organize_Load(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            DataTable main_table = new DataTable();
            main_table.Columns.AddRange(columns);

            foreach (Classes.Mark m in Code.Files.MarksFile.ReadAllMarks())
            {
                main_table.Rows.Add(m.name,
                                    m.DateTime.ToShortDateString(),
                                    m.DateTime.ToShortTimeString(),
                                    m.quizType.ToString(),
                                    DifficultyOptions[(byte) m.quizType.difficulty],
                                    m.mark + "",
                                    m.FinishTime);
            }

            dt = main_table;
            dataGridView1.DataSource = main_table;

            SetWidthOfTable();

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Code.Files.MarksFile.GetAllDates().ToArray());

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(Code.Files.MarksFile.GetAllNames().ToArray());

            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(Code.Files.MarksFile.GetAllPeulot().ToArray());
        }

        /// <summary>
        /// Set columns width
        /// </summary>
        private void SetWidthOfTable()
        {
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 40;
            dataGridView1.Columns[6].Width = 45;
        }

        /// <summary>
        /// evant when the window's size is changed
        /// </summary>
        private void AllMarks_organize_SizeChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Size = new Size(this.Width, this.Size.Height - dataGridView1.Location.Y);
            this.dataGridView1.ScrollBars = ScrollBars.Both;
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_all.Checked)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                AllMarks_organize_Load(sender, e);
                comboBox1.Text = choose;
                comboBox2.Text = choose;
                comboBox3.Text = choose;
            }
            else if (rb_date.Checked)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox2.Text = choose;
                comboBox3.Text = choose;
            }
            else if (rb_name.Checked)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = true;
                comboBox3.Enabled = false;
                comboBox1.Text = choose;
                comboBox3.Text = choose;
            }
            else if (rb_peula.Checked)
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = true;
                comboBox1.Text = choose;
                comboBox2.Text = choose;
            }
        }

        /// <summary>
        /// React on trying to delete a row from the table
        /// </summary>
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (Code.Login.ShowLoginForm(Register.Start.Properties.AplicationLogin.Username, Register.Start.Properties.AplicationLogin.Password))
                Code.Files.MarksFile.RemoveMark(e.Row.Index);
            else
                e.Cancel = true;
        }

        /// <summary>
        /// Select by date
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            DataTable temp = new DataTable();
            temp.Columns.AddRange(columns);

            {
                foreach (Classes.Mark m in Code.Files.MarksFile.ReadAllMarks())
                {
                    if (m.DateTime.ToShortDateString() == comboBox1.Text)
                        temp.Rows.Add(m.name,
                                      m.DateTime.ToShortDateString(),
                                      m.DateTime.ToShortTimeString(),
                                      m.quizType.ToString(),
                                      DifficultyOptions[(byte)m.quizType.difficulty],
                                      m.mark + "",
                                      m.FinishTime);
                }
            }
            this.dataGridView1.DataSource = temp;
            dt = temp;
            temp.Dispose();
            SetWidthOfTable();
        }

        /// <summary>
        /// Select by name
        /// </summary>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            DataTable temp = new DataTable();
            temp.Columns.AddRange(columns);

            {
                foreach (Classes.Mark m in Code.Files.MarksFile.ReadAllMarks())
                {
                    if (m.name == comboBox2.Text)
                        temp.Rows.Add(m.name,
                                      m.DateTime.ToShortDateString(),
                                      m.DateTime.ToShortTimeString(),
                                      m.quizType.ToString(),
                                      DifficultyOptions[(byte)m.quizType.difficulty],
                                      m.mark + "",
                                      m.FinishTime);
                }
            }
            this.dataGridView1.DataSource = temp;
            dt = temp;
            temp.Dispose();
            SetWidthOfTable();
        }

        /// <summary>
        /// select by peula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Columns.Clear();
            DataTable temp = new DataTable();
            temp.Columns.AddRange(columns);

            {
                foreach (Classes.Mark m in Code.Files.MarksFile.ReadAllMarks())
                {
                    if (m.quizType.ToString() == comboBox3.Text)
                        temp.Rows.Add(m.name,
                                      m.DateTime.ToShortDateString(),
                                      m.DateTime.ToShortTimeString(),
                                      m.quizType.ToString(),
                                      DifficultyOptions[(byte)m.quizType.difficulty],
                                      m.mark + "",
                                      m.FinishTime);
                }
            }
            this.dataGridView1.DataSource = temp;
            dt = temp;
            temp.Dispose();
            SetWidthOfTable();
        }
    }
}