namespace Peulot_Heshbon.Forms
{
    internal partial class AllMarks_organize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_date = new System.Windows.Forms.RadioButton();
            this.rb_name = new System.Windows.Forms.RadioButton();
            this.rb_peula = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.rb_all = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(570, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(86, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "בחר";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "סנן לפי:";
            // 
            // rb_date
            // 
            this.rb_date.AutoSize = true;
            this.rb_date.Location = new System.Drawing.Point(102, 33);
            this.rb_date.Name = "rb_date";
            this.rb_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_date.Size = new System.Drawing.Size(80, 17);
            this.rb_date.TabIndex = 3;
            this.rb_date.Text = "לפי תאריך";
            this.rb_date.UseVisualStyleBackColor = true;
            this.rb_date.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rb_name
            // 
            this.rb_name.AutoSize = true;
            this.rb_name.Location = new System.Drawing.Point(218, 33);
            this.rb_name.Name = "rb_name";
            this.rb_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_name.Size = new System.Drawing.Size(66, 17);
            this.rb_name.TabIndex = 4;
            this.rb_name.Text = "לפי שם:";
            this.rb_name.UseVisualStyleBackColor = true;
            this.rb_name.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rb_peula
            // 
            this.rb_peula.AutoSize = true;
            this.rb_peula.Location = new System.Drawing.Point(328, 33);
            this.rb_peula.Name = "rb_peula";
            this.rb_peula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_peula.Size = new System.Drawing.Size(83, 17);
            this.rb_peula.TabIndex = 5;
            this.rb_peula.Text = "לפי פעולה:";
            this.rb_peula.UseVisualStyleBackColor = true;
            this.rb_peula.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(218, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox2.Size = new System.Drawing.Size(86, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "בחר";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(328, 56);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox3.Size = new System.Drawing.Size(152, 21);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.Text = "בחר";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Checked = true;
            this.rb_all.Location = new System.Drawing.Point(12, 33);
            this.rb_all.Name = "rb_all";
            this.rb_all.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_all.Size = new System.Drawing.Size(69, 17);
            this.rb_all.TabIndex = 8;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "הצג הכל";
            this.rb_all.UseVisualStyleBackColor = true;
            this.rb_all.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // AllMarks_organize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 383);
            this.Controls.Add(this.rb_all);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_peula);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rb_name);
            this.Controls.Add(this.rb_date);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllMarks_organize";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "כל הציונים בטבלה";
            this.Load += new System.EventHandler(this.AllMarks_organize_Load);
            this.SizeChanged += new System.EventHandler(this.AllMarks_organize_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_date;
        private System.Windows.Forms.RadioButton rb_name;
        private System.Windows.Forms.RadioButton rb_peula;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RadioButton rb_all;
    }
}