
namespace CEIT310_final_p1_student
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_average = new System.Windows.Forms.Label();
            this.lst_engagementRecords = new System.Windows.Forms.ListBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.txt_engagementName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_createVideoEngagement = new System.Windows.Forms.Button();
            this.txt_minutesWatched = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_readingEngagement = new System.Windows.Forms.TabPage();
            this.btn_createReadingEngagement = new System.Windows.Forms.Button();
            this.txt_pagesRead = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pagesSkipped = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_bookmarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_highlights = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_videoEngagement = new System.Windows.Forms.TabPage();
            this.txt_minutesSkipped = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_plays = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_pauses = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_readingEngagement.SuspendLayout();
            this.tabPage_videoEngagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_average
            // 
            this.lbl_average.AutoSize = true;
            this.lbl_average.Location = new System.Drawing.Point(332, 341);
            this.lbl_average.Name = "lbl_average";
            this.lbl_average.Size = new System.Drawing.Size(198, 15);
            this.lbl_average.TabIndex = 12;
            this.lbl_average.Text = "Engagement score is displayed here.";
            // 
            // lst_engagementRecords
            // 
            this.lst_engagementRecords.FormattingEnabled = true;
            this.lst_engagementRecords.ItemHeight = 15;
            this.lst_engagementRecords.Location = new System.Drawing.Point(332, 62);
            this.lst_engagementRecords.Name = "lst_engagementRecords";
            this.lst_engagementRecords.Size = new System.Drawing.Size(223, 274);
            this.lst_engagementRecords.TabIndex = 10;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(38, 341);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(264, 15);
            this.lbl_message.TabIndex = 9;
            this.lbl_message.Text = "Please fill the form to create engagement record.";
            // 
            // txt_engagementName
            // 
            this.txt_engagementName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_engagementName.Location = new System.Drawing.Point(135, 57);
            this.txt_engagementName.Name = "txt_engagementName";
            this.txt_engagementName.Size = new System.Drawing.Size(114, 23);
            this.txt_engagementName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Engagement name : ";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id.Location = new System.Drawing.Point(135, 28);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(114, 23);
            this.txt_id.TabIndex = 1;
            this.txt_id.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Engagement Id : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(327, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Student Engagement Records ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_engagementName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(34, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 96);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Engagement";
            // 
            // btn_createVideoEngagement
            // 
            this.btn_createVideoEngagement.Location = new System.Drawing.Point(173, 138);
            this.btn_createVideoEngagement.Name = "btn_createVideoEngagement";
            this.btn_createVideoEngagement.Size = new System.Drawing.Size(75, 23);
            this.btn_createVideoEngagement.TabIndex = 21;
            this.btn_createVideoEngagement.Text = "Create";
            this.btn_createVideoEngagement.UseVisualStyleBackColor = true;
            // 
            // txt_minutesWatched
            // 
            this.txt_minutesWatched.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_minutesWatched.Location = new System.Drawing.Point(134, 100);
            this.txt_minutesWatched.Name = "txt_minutesWatched";
            this.txt_minutesWatched.Size = new System.Drawing.Size(114, 23);
            this.txt_minutesWatched.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Minutes watched : ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_readingEngagement);
            this.tabControl1.Controls.Add(this.tabPage_videoEngagement);
            this.tabControl1.Location = new System.Drawing.Point(34, 133);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(277, 203);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage_readingEngagement
            // 
            this.tabPage_readingEngagement.Controls.Add(this.btn_createReadingEngagement);
            this.tabPage_readingEngagement.Controls.Add(this.txt_pagesRead);
            this.tabPage_readingEngagement.Controls.Add(this.label5);
            this.tabPage_readingEngagement.Controls.Add(this.txt_pagesSkipped);
            this.tabPage_readingEngagement.Controls.Add(this.label6);
            this.tabPage_readingEngagement.Controls.Add(this.txt_bookmarks);
            this.tabPage_readingEngagement.Controls.Add(this.label3);
            this.tabPage_readingEngagement.Controls.Add(this.txt_highlights);
            this.tabPage_readingEngagement.Controls.Add(this.label4);
            this.tabPage_readingEngagement.Location = new System.Drawing.Point(4, 24);
            this.tabPage_readingEngagement.Name = "tabPage_readingEngagement";
            this.tabPage_readingEngagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_readingEngagement.Size = new System.Drawing.Size(269, 175);
            this.tabPage_readingEngagement.TabIndex = 0;
            this.tabPage_readingEngagement.Text = "Reading Engagement";
            this.tabPage_readingEngagement.UseVisualStyleBackColor = true;
            // 
            // btn_createReadingEngagement
            // 
            this.btn_createReadingEngagement.Location = new System.Drawing.Point(170, 142);
            this.btn_createReadingEngagement.Name = "btn_createReadingEngagement";
            this.btn_createReadingEngagement.Size = new System.Drawing.Size(75, 23);
            this.btn_createReadingEngagement.TabIndex = 12;
            this.btn_createReadingEngagement.Text = "Create";
            this.btn_createReadingEngagement.UseVisualStyleBackColor = true;
            // 
            // txt_pagesRead
            // 
            this.txt_pagesRead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pagesRead.Location = new System.Drawing.Point(131, 104);
            this.txt_pagesRead.Name = "txt_pagesRead";
            this.txt_pagesRead.Size = new System.Drawing.Size(114, 23);
            this.txt_pagesRead.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "# of pages read : ";
            // 
            // txt_pagesSkipped
            // 
            this.txt_pagesSkipped.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pagesSkipped.Location = new System.Drawing.Point(131, 75);
            this.txt_pagesSkipped.Name = "txt_pagesSkipped";
            this.txt_pagesSkipped.Size = new System.Drawing.Size(114, 23);
            this.txt_pagesSkipped.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "# of pages skipped : ";
            // 
            // txt_bookmarks
            // 
            this.txt_bookmarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_bookmarks.Location = new System.Drawing.Point(131, 46);
            this.txt_bookmarks.Name = "txt_bookmarks";
            this.txt_bookmarks.Size = new System.Drawing.Size(114, 23);
            this.txt_bookmarks.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "# of bookmarks : ";
            // 
            // txt_highlights
            // 
            this.txt_highlights.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_highlights.Location = new System.Drawing.Point(131, 17);
            this.txt_highlights.Name = "txt_highlights";
            this.txt_highlights.Size = new System.Drawing.Size(114, 23);
            this.txt_highlights.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "# of highlights : ";
            // 
            // tabPage_videoEngagement
            // 
            this.tabPage_videoEngagement.Controls.Add(this.btn_createVideoEngagement);
            this.tabPage_videoEngagement.Controls.Add(this.txt_minutesWatched);
            this.tabPage_videoEngagement.Controls.Add(this.label7);
            this.tabPage_videoEngagement.Controls.Add(this.txt_minutesSkipped);
            this.tabPage_videoEngagement.Controls.Add(this.label8);
            this.tabPage_videoEngagement.Controls.Add(this.txt_plays);
            this.tabPage_videoEngagement.Controls.Add(this.label9);
            this.tabPage_videoEngagement.Controls.Add(this.txt_pauses);
            this.tabPage_videoEngagement.Controls.Add(this.label10);
            this.tabPage_videoEngagement.Location = new System.Drawing.Point(4, 24);
            this.tabPage_videoEngagement.Name = "tabPage_videoEngagement";
            this.tabPage_videoEngagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_videoEngagement.Size = new System.Drawing.Size(269, 175);
            this.tabPage_videoEngagement.TabIndex = 1;
            this.tabPage_videoEngagement.Text = "Video Engagement";
            this.tabPage_videoEngagement.UseVisualStyleBackColor = true;
            // 
            // txt_minutesSkipped
            // 
            this.txt_minutesSkipped.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_minutesSkipped.Location = new System.Drawing.Point(134, 71);
            this.txt_minutesSkipped.Name = "txt_minutesSkipped";
            this.txt_minutesSkipped.Size = new System.Drawing.Size(114, 23);
            this.txt_minutesSkipped.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Minutes skipped : ";
            // 
            // txt_plays
            // 
            this.txt_plays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_plays.Location = new System.Drawing.Point(134, 42);
            this.txt_plays.Name = "txt_plays";
            this.txt_plays.Size = new System.Drawing.Size(114, 23);
            this.txt_plays.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(24, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "# of plays : ";
            // 
            // txt_pauses
            // 
            this.txt_pauses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_pauses.Location = new System.Drawing.Point(134, 13);
            this.txt_pauses.Name = "txt_pauses";
            this.txt_pauses.Size = new System.Drawing.Size(114, 23);
            this.txt_pauses.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(24, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "# of pauses : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 384);
            this.Controls.Add(this.lbl_average);
            this.Controls.Add(this.lst_engagementRecords);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_readingEngagement.ResumeLayout(false);
            this.tabPage_readingEngagement.PerformLayout();
            this.tabPage_videoEngagement.ResumeLayout(false);
            this.tabPage_videoEngagement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_average;
        private System.Windows.Forms.ListBox lst_engagementRecords;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TextBox txt_engagementName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_createVideoEngagement;
        private System.Windows.Forms.TextBox txt_minutesWatched;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_readingEngagement;
        private System.Windows.Forms.Button btn_createReadingEngagement;
        private System.Windows.Forms.TextBox txt_pagesRead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pagesSkipped;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_bookmarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_highlights;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage_videoEngagement;
        private System.Windows.Forms.TextBox txt_minutesSkipped;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_plays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pauses;
        private System.Windows.Forms.Label label10;
    }
}

