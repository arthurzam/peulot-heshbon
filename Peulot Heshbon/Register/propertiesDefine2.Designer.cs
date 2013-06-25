namespace Peulot_Heshbon.Register
{
    partial class propertiesDefine2
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
            this.cb_oneRememberedName = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name_f = new System.Windows.Forms.TextBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.tb_name_l = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_login_username = new System.Windows.Forms.TextBox();
            this.tb_login_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "כעט תוכל לבחור את התוספות הנוספות:";
            // 
            // cb_oneRememberedName
            // 
            this.cb_oneRememberedName.AutoSize = true;
            this.cb_oneRememberedName.Location = new System.Drawing.Point(15, 49);
            this.cb_oneRememberedName.Name = "cb_oneRememberedName";
            this.cb_oneRememberedName.Size = new System.Drawing.Size(177, 17);
            this.cb_oneRememberedName.TabIndex = 1;
            this.cb_oneRememberedName.Text = "התוכנה תעבוד רק עם שם אחד";
            this.cb_oneRememberedName.UseVisualStyleBackColor = true;
            this.cb_oneRememberedName.CheckedChanged += new System.EventHandler(this.cb_oneRememberedName_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "שם פרטי:";
            this.label2.Visible = false;
            // 
            // tb_name_f
            // 
            this.tb_name_f.Location = new System.Drawing.Point(123, 70);
            this.tb_name_f.Name = "tb_name_f";
            this.tb_name_f.Size = new System.Drawing.Size(100, 20);
            this.tb_name_f.TabIndex = 2;
            this.tb_name_f.Visible = false;
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(124, 278);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 11;
            this.bt_cancel.Text = "ביטול";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Location = new System.Drawing.Point(205, 278);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 11;
            this.bt_ok.Text = "הבא >";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // tb_name_l
            // 
            this.tb_name_l.Location = new System.Drawing.Point(123, 103);
            this.tb_name_l.Name = "tb_name_l";
            this.tb_name_l.Size = new System.Drawing.Size(100, 20);
            this.tb_name_l.TabIndex = 4;
            this.tb_name_l.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "שם משפחה: ";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "על מנת לעשות דברים מיוחדים, תצטרך להתחבר\nבחר סיסמה ושם משתמש שישרתו אותך:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "שם משתמש:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "סיסמה:";
            // 
            // tb_login_username
            // 
            this.tb_login_username.Location = new System.Drawing.Point(145, 193);
            this.tb_login_username.Name = "tb_login_username";
            this.tb_login_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_login_username.Size = new System.Drawing.Size(88, 20);
            this.tb_login_username.TabIndex = 7;
            // 
            // tb_login_password
            // 
            this.tb_login_password.Location = new System.Drawing.Point(145, 219);
            this.tb_login_password.Name = "tb_login_password";
            this.tb_login_password.PasswordChar = '*';
            this.tb_login_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_login_password.Size = new System.Drawing.Size(88, 20);
            this.tb_login_password.TabIndex = 9;
            // 
            // propertiesDefine2
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_cancel;
            this.ClientSize = new System.Drawing.Size(292, 313);
            this.Controls.Add(this.tb_login_password);
            this.Controls.Add(this.tb_login_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_name_l);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_name_f);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_oneRememberedName);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 347);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 347);
            this.Name = "propertiesDefine2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "תוספות";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_oneRememberedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name_f;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.TextBox tb_name_l;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_login_username;
        private System.Windows.Forms.TextBox tb_login_password;
    }
}