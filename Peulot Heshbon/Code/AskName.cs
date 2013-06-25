using System;
using System.Drawing;
using System.Windows.Forms;

namespace Peulot_Heshbon.Code
{
    internal class AskName : Form
    {
        public AskName()
        {
            InitializeComponent();

            Text = Languages.ChosenLanguage.form_askName["title"];
            button1.Text = Languages.ChosenLanguage.form_askName["button1"];
            label2.Text = Languages.ChosenLanguage.form_askName["label2"];
            label3.Text = Languages.ChosenLanguage.form_askName["label3"];
            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;
        }

        public static DialogResult ShowForm(ref Peulot_Heshbon.Classes.PersonName PersonName)
        {
            AskName f = new AskName();
            f.ShowDialog();
            PersonName.FirstName = f.tb_name_f.Text;
            PersonName.LastName = f.tb_name_l.Text;
            return f.DialogResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_name_l.Text != "" && tb_name_f.Text != "")
                this.Close();
            else
            {
                errorProvider.Clear();
                if (tb_name_f.Text == "") errorProvider.SetError(tb_name_f, Languages.ChosenLanguage.form_askName["missing"]);
                if (tb_name_l.Text == "") errorProvider.SetError(tb_name_l, Languages.ChosenLanguage.form_askName["missing"]);
            }
        }

        private void AskName_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tb_name_l.Text == "" || tb_name_f.Text == "")
            {
                e.Cancel = true;
                errorProvider.Clear();
                if (tb_name_f.Text == "") errorProvider.SetError(tb_name_f, Languages.ChosenLanguage.form_askName["missing"]);
                if (tb_name_l.Text == "") errorProvider.SetError(tb_name_l, Languages.ChosenLanguage.form_askName["missing"]);
            }
        }

        #region Designer

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_name_l = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name_f = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name_l
            // 
            this.tb_name_l.Location = new System.Drawing.Point(94, 36);
            this.tb_name_l.Name = "tb_name_l";
            this.tb_name_l.Size = new System.Drawing.Size(100, 20);
            this.tb_name_l.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "שם משפחה:";
            // 
            // tb_name_f
            // 
            this.tb_name_f.Location = new System.Drawing.Point(94, 3);
            this.tb_name_f.Name = "tb_name_f";
            this.tb_name_f.Size = new System.Drawing.Size(100, 20);
            this.tb_name_f.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "שם פרטי:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "אישור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // AskName
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 115);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_name_l);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name_f);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(205, 149);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(205, 149);
            this.Name = "AskName";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "שם";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskName_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_name_l;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tb_name_f;
        private System.Windows.Forms.ErrorProvider errorProvider;

        #endregion Designer
    }
}