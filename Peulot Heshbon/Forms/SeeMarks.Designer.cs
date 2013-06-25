namespace Peulot_Heshbon.Forms
{
    internal partial class SeeMarks
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
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_mark = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_prev = new System.Windows.Forms.Button();
            this.bt_remove = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_finishTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_difficulty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(24, 43);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(40, 13);
            this.lb_date.TabIndex = 0;
            this.lb_date.Text = "תאריך";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Location = new System.Drawing.Point(24, 75);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(24, 13);
            this.lb_Time.TabIndex = 1;
            this.lb_Time.Text = "זמן";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(24, 106);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(40, 13);
            this.lb_type.TabIndex = 2;
            this.lb_type.Text = "פעולה";
            // 
            // lb_mark
            // 
            this.lb_mark.AutoSize = true;
            this.lb_mark.Location = new System.Drawing.Point(24, 140);
            this.lb_mark.Name = "lb_mark";
            this.lb_mark.Size = new System.Drawing.Size(29, 13);
            this.lb_mark.TabIndex = 3;
            this.lb_mark.Text = "ציון";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 43);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 75);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 106);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 140);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(83, 238);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(50, 28);
            this.bt_next.TabIndex = 8;
            this.bt_next.Text = "הבא";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_prev
            // 
            this.bt_prev.Location = new System.Drawing.Point(27, 238);
            this.bt_prev.Name = "bt_prev";
            this.bt_prev.Size = new System.Drawing.Size(50, 28);
            this.bt_prev.TabIndex = 9;
            this.bt_prev.Text = "הקודם";
            this.bt_prev.UseVisualStyleBackColor = true;
            this.bt_prev.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_remove
            // 
            this.bt_remove.Location = new System.Drawing.Point(139, 238);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(66, 28);
            this.bt_remove.TabIndex = 10;
            this.bt_remove.Text = "מחק ציון";
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(24, 9);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(23, 13);
            this.lb_name.TabIndex = 11;
            this.lb_name.Text = "שם";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 9);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "label0";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 177);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "label11";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_finishTime
            // 
            this.lb_finishTime.AutoSize = true;
            this.lb_finishTime.Location = new System.Drawing.Point(24, 177);
            this.lb_finishTime.Name = "lb_finishTime";
            this.lb_finishTime.Size = new System.Drawing.Size(60, 13);
            this.lb_finishTime.TabIndex = 13;
            this.lb_finishTime.Text = "זמן עבודה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 212);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_difficulty
            // 
            this.lb_difficulty.AutoSize = true;
            this.lb_difficulty.Location = new System.Drawing.Point(24, 212);
            this.lb_difficulty.Name = "lb_difficulty";
            this.lb_difficulty.Size = new System.Drawing.Size(25, 14);
            this.lb_difficulty.TabIndex = 15;
            this.lb_difficulty.Text = "קושי";
            // 
            // SeeMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_difficulty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_finishTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.bt_prev);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_mark);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.lb_date);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(314, 315);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(314, 315);
            this.Name = "SeeMarks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ציונים";
            this.Load += new System.EventHandler(this.SeeMarks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_mark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_prev;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_finishTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_difficulty;

    }
}