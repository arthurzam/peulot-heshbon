namespace Peulot_Heshbon.Register
{
    internal partial class propertiesDefine
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_folder_auto = new System.Windows.Forms.RadioButton();
            this.rb_folder_manual = new System.Windows.Forms.RadioButton();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tb_choosefolder = new System.Windows.Forms.TextBox();
            this.bt_chooseFolder = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "כעט תוכל לבחור את התוספות הנוספות:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "התוכנה תשמור את הקבצים שלה:";
            // 
            // rb_folder_auto
            // 
            this.rb_folder_auto.AutoSize = true;
            this.rb_folder_auto.Checked = true;
            this.rb_folder_auto.Location = new System.Drawing.Point(50, 93);
            this.rb_folder_auto.Name = "rb_folder_auto";
            this.rb_folder_auto.Size = new System.Drawing.Size(155, 17);
            this.rb_folder_auto.TabIndex = 2;
            this.rb_folder_auto.TabStop = true;
            this.rb_folder_auto.Text = "במקום האוטומטי (מומלץ)";
            this.rb_folder_auto.UseVisualStyleBackColor = true;
            this.rb_folder_auto.CheckedChanged += new System.EventHandler(this.rb_folder_CheckedChanged);
            // 
            // rb_folder_manual
            // 
            this.rb_folder_manual.AutoSize = true;
            this.rb_folder_manual.Location = new System.Drawing.Point(50, 116);
            this.rb_folder_manual.Name = "rb_folder_manual";
            this.rb_folder_manual.Size = new System.Drawing.Size(214, 17);
            this.rb_folder_manual.TabIndex = 3;
            this.rb_folder_manual.TabStop = true;
            this.rb_folder_manual.Text = "אבחר בעצמי את התיקייה (לא מומלץ)";
            this.rb_folder_manual.UseVisualStyleBackColor = true;
            this.rb_folder_manual.CheckedChanged += new System.EventHandler(this.rb_folder_CheckedChanged);
            // 
            // folderBrowser
            // 
            this.folderBrowser.Description = "בחר תיקייה עבור שמירת קבצים";
            this.folderBrowser.SelectedPath = "C:\\";
            // 
            // tb_choosefolder
            // 
            this.tb_choosefolder.BackColor = System.Drawing.SystemColors.Window;
            this.tb_choosefolder.Location = new System.Drawing.Point(65, 139);
            this.tb_choosefolder.Name = "tb_choosefolder";
            this.tb_choosefolder.ReadOnly = true;
            this.tb_choosefolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_choosefolder.Size = new System.Drawing.Size(174, 20);
            this.tb_choosefolder.TabIndex = 4;
            this.tb_choosefolder.Visible = false;
            // 
            // bt_chooseFolder
            // 
            this.bt_chooseFolder.Location = new System.Drawing.Point(258, 137);
            this.bt_chooseFolder.Name = "bt_chooseFolder";
            this.bt_chooseFolder.Size = new System.Drawing.Size(75, 20);
            this.bt_chooseFolder.TabIndex = 5;
            this.bt_chooseFolder.Text = "בחר...";
            this.bt_chooseFolder.UseVisualStyleBackColor = true;
            this.bt_chooseFolder.Visible = false;
            this.bt_chooseFolder.Click += new System.EventHandler(this.bt_chooseFolder_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(236, 183);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 30;
            this.bt_cancel.Text = "ביטול";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Location = new System.Drawing.Point(317, 183);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 29;
            this.bt_ok.Text = "הבא >";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // propertiesDefine
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_cancel;
            this.ClientSize = new System.Drawing.Size(404, 235);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.bt_chooseFolder);
            this.Controls.Add(this.tb_choosefolder);
            this.Controls.Add(this.rb_folder_manual);
            this.Controls.Add(this.rb_folder_auto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 269);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(412, 269);
            this.Name = "propertiesDefine";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "תוספות";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_folder_auto;
        private System.Windows.Forms.RadioButton rb_folder_manual;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.TextBox tb_choosefolder;
        private System.Windows.Forms.Button bt_chooseFolder;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_ok;
    }
}