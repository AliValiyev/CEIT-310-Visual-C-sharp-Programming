namespace lab_3_assignment
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
            this.gb_readings = new System.Windows.Forms.GroupBox();
            this.gb_discussions = new System.Windows.Forms.GroupBox();
            this.gb_videos = new System.Windows.Forms.GroupBox();
            this.gb_quizzes = new System.Windows.Forms.GroupBox();
            this.lbl_number_of_page_views = new System.Windows.Forms.Label();
            this.tbx_number_of_page_views = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.tbx_number_of_highlight = new System.Windows.Forms.TextBox();
            this.lbl_number_of_unread_pages = new System.Windows.Forms.Label();
            this.tbx_number_of_unread_pages = new System.Windows.Forms.TextBox();
            this.lbl_reading_message = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_videos_message = new System.Windows.Forms.Label();
            this.lbl_minutes_skipped = new System.Windows.Forms.Label();
            this.tbx_minutes_skipped = new System.Windows.Forms.TextBox();
            this.lbl_number_of_play = new System.Windows.Forms.Label();
            this.tbx_number_of_play = new System.Windows.Forms.TextBox();
            this.lbl_average_minutes_watched = new System.Windows.Forms.Label();
            this.tbx_average_minutes_watched = new System.Windows.Forms.TextBox();
            this.lbl_discussions_message = new System.Windows.Forms.Label();
            this.lbl_number_of_unread_posts = new System.Windows.Forms.Label();
            this.tbx_number_of_unread_posts = new System.Windows.Forms.TextBox();
            this.lbl_number_of_comments = new System.Windows.Forms.Label();
            this.tbx_number_of_comments = new System.Windows.Forms.TextBox();
            this.lbl_number_of_questions = new System.Windows.Forms.Label();
            this.tbx_number_of_questions = new System.Windows.Forms.TextBox();
            this.lbl_quizzes_message = new System.Windows.Forms.Label();
            this.lbl_average_number_of_attempts = new System.Windows.Forms.Label();
            this.tbx_average_number_of_attempts = new System.Windows.Forms.TextBox();
            this.lbl_average_quiz_score = new System.Windows.Forms.Label();
            this.tbx_average_quiz_score = new System.Windows.Forms.TextBox();
            this.lbl_number_of_failed_questions = new System.Windows.Forms.Label();
            this.tbx_number_of_failed_questions = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_overall = new System.Windows.Forms.Label();
            this.gb_readings.SuspendLayout();
            this.gb_discussions.SuspendLayout();
            this.gb_videos.SuspendLayout();
            this.gb_quizzes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_readings
            // 
            this.gb_readings.BackColor = System.Drawing.Color.PapayaWhip;
            this.gb_readings.Controls.Add(this.lbl_reading_message);
            this.gb_readings.Controls.Add(this.lbl_number_of_unread_pages);
            this.gb_readings.Controls.Add(this.tbx_number_of_unread_pages);
            this.gb_readings.Controls.Add(this.c);
            this.gb_readings.Controls.Add(this.tbx_number_of_highlight);
            this.gb_readings.Controls.Add(this.lbl_number_of_page_views);
            this.gb_readings.Controls.Add(this.tbx_number_of_page_views);
            this.gb_readings.Location = new System.Drawing.Point(48, 101);
            this.gb_readings.Name = "gb_readings";
            this.gb_readings.Size = new System.Drawing.Size(323, 169);
            this.gb_readings.TabIndex = 0;
            this.gb_readings.TabStop = false;
            this.gb_readings.Text = "Readings";
            // 
            // gb_discussions
            // 
            this.gb_discussions.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gb_discussions.Controls.Add(this.lbl_discussions_message);
            this.gb_discussions.Controls.Add(this.lbl_number_of_unread_posts);
            this.gb_discussions.Controls.Add(this.tbx_number_of_unread_posts);
            this.gb_discussions.Controls.Add(this.lbl_number_of_comments);
            this.gb_discussions.Controls.Add(this.tbx_number_of_comments);
            this.gb_discussions.Controls.Add(this.lbl_number_of_questions);
            this.gb_discussions.Controls.Add(this.tbx_number_of_questions);
            this.gb_discussions.Location = new System.Drawing.Point(436, 101);
            this.gb_discussions.Name = "gb_discussions";
            this.gb_discussions.Size = new System.Drawing.Size(323, 169);
            this.gb_discussions.TabIndex = 1;
            this.gb_discussions.TabStop = false;
            this.gb_discussions.Text = "Discussions";
            // 
            // gb_videos
            // 
            this.gb_videos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_videos.Controls.Add(this.lbl_videos_message);
            this.gb_videos.Controls.Add(this.lbl_minutes_skipped);
            this.gb_videos.Controls.Add(this.tbx_minutes_skipped);
            this.gb_videos.Controls.Add(this.lbl_number_of_play);
            this.gb_videos.Controls.Add(this.tbx_number_of_play);
            this.gb_videos.Controls.Add(this.lbl_average_minutes_watched);
            this.gb_videos.Controls.Add(this.tbx_average_minutes_watched);
            this.gb_videos.Location = new System.Drawing.Point(48, 306);
            this.gb_videos.Name = "gb_videos";
            this.gb_videos.Size = new System.Drawing.Size(323, 169);
            this.gb_videos.TabIndex = 2;
            this.gb_videos.TabStop = false;
            this.gb_videos.Text = "Videos";
            // 
            // gb_quizzes
            // 
            this.gb_quizzes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gb_quizzes.Controls.Add(this.lbl_quizzes_message);
            this.gb_quizzes.Controls.Add(this.lbl_average_number_of_attempts);
            this.gb_quizzes.Controls.Add(this.tbx_average_number_of_attempts);
            this.gb_quizzes.Controls.Add(this.lbl_average_quiz_score);
            this.gb_quizzes.Controls.Add(this.tbx_average_quiz_score);
            this.gb_quizzes.Controls.Add(this.lbl_number_of_failed_questions);
            this.gb_quizzes.Controls.Add(this.tbx_number_of_failed_questions);
            this.gb_quizzes.Location = new System.Drawing.Point(436, 306);
            this.gb_quizzes.Name = "gb_quizzes";
            this.gb_quizzes.Size = new System.Drawing.Size(323, 169);
            this.gb_quizzes.TabIndex = 0;
            this.gb_quizzes.TabStop = false;
            this.gb_quizzes.Text = "Quizzes";
            // 
            // lbl_number_of_page_views
            // 
            this.lbl_number_of_page_views.AutoSize = true;
            this.lbl_number_of_page_views.Location = new System.Drawing.Point(6, 45);
            this.lbl_number_of_page_views.Name = "lbl_number_of_page_views";
            this.lbl_number_of_page_views.Size = new System.Drawing.Size(132, 15);
            this.lbl_number_of_page_views.TabIndex = 3;
            this.lbl_number_of_page_views.Text = "Number of page views :";
            // 
            // tbx_number_of_page_views
            // 
            this.tbx_number_of_page_views.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_number_of_page_views.Location = new System.Drawing.Point(162, 42);
            this.tbx_number_of_page_views.Name = "tbx_number_of_page_views";
            this.tbx_number_of_page_views.Size = new System.Drawing.Size(139, 23);
            this.tbx_number_of_page_views.TabIndex = 4;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(6, 74);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(127, 15);
            this.c.TabIndex = 5;
            this.c.Text = "Number of highlights :";
            // 
            // tbx_number_of_highlight
            // 
            this.tbx_number_of_highlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_number_of_highlight.Location = new System.Drawing.Point(162, 71);
            this.tbx_number_of_highlight.Name = "tbx_number_of_highlight";
            this.tbx_number_of_highlight.Size = new System.Drawing.Size(139, 23);
            this.tbx_number_of_highlight.TabIndex = 6;
            // 
            // lbl_number_of_unread_pages
            // 
            this.lbl_number_of_unread_pages.AutoSize = true;
            this.lbl_number_of_unread_pages.Location = new System.Drawing.Point(6, 103);
            this.lbl_number_of_unread_pages.Name = "lbl_number_of_unread_pages";
            this.lbl_number_of_unread_pages.Size = new System.Drawing.Size(145, 15);
            this.lbl_number_of_unread_pages.TabIndex = 7;
            this.lbl_number_of_unread_pages.Text = "Number of unread pages :";
            // 
            // tbx_number_of_unread_pages
            // 
            this.tbx_number_of_unread_pages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_number_of_unread_pages.Location = new System.Drawing.Point(162, 100);
            this.tbx_number_of_unread_pages.Name = "tbx_number_of_unread_pages";
            this.tbx_number_of_unread_pages.Size = new System.Drawing.Size(139, 23);
            this.tbx_number_of_unread_pages.TabIndex = 8;
            // 
            // lbl_reading_message
            // 
            this.lbl_reading_message.AutoSize = true;
            this.lbl_reading_message.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_reading_message.Location = new System.Drawing.Point(42, 141);
            this.lbl_reading_message.Name = "lbl_reading_message";
            this.lbl_reading_message.Size = new System.Drawing.Size(259, 15);
            this.lbl_reading_message.TabIndex = 9;
            this.lbl_reading_message.Text = "Reading engagement score is not calculated yet";
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_header.Location = new System.Drawing.Point(48, 38);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(312, 28);
            this.lbl_header.TabIndex = 3;
            this.lbl_header.Text = "Student Engagement Calculator";
            // 
            // lbl_videos_message
            // 
            this.lbl_videos_message.AutoSize = true;
            this.lbl_videos_message.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_videos_message.Location = new System.Drawing.Point(47, 140);
            this.lbl_videos_message.Name = "lbl_videos_message";
            this.lbl_videos_message.Size = new System.Drawing.Size(215, 15);
            this.lbl_videos_message.TabIndex = 16;
            this.lbl_videos_message.Text = "Video engagement is not calculated yet";
            // 
            // lbl_minutes_skipped
            // 
            this.lbl_minutes_skipped.AutoSize = true;
            this.lbl_minutes_skipped.Location = new System.Drawing.Point(11, 102);
            this.lbl_minutes_skipped.Name = "lbl_minutes_skipped";
            this.lbl_minutes_skipped.Size = new System.Drawing.Size(100, 15);
            this.lbl_minutes_skipped.TabIndex = 14;
            this.lbl_minutes_skipped.Text = "Minutes skipped :";
            // 
            // tbx_minutes_skipped
            // 
            this.tbx_minutes_skipped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_minutes_skipped.Location = new System.Drawing.Point(167, 99);
            this.tbx_minutes_skipped.Name = "tbx_minutes_skipped";
            this.tbx_minutes_skipped.Size = new System.Drawing.Size(139, 23);
            this.tbx_minutes_skipped.TabIndex = 15;
            // 
            // lbl_number_of_play
            // 
            this.lbl_number_of_play.AutoSize = true;
            this.lbl_number_of_play.Location = new System.Drawing.Point(11, 73);
            this.lbl_number_of_play.Name = "lbl_number_of_play";
            this.lbl_number_of_play.Size = new System.Drawing.Size(132, 15);
            this.lbl_number_of_play.TabIndex = 12;
            this.lbl_number_of_play.Text = "Number of play/pause :";
            // 
            // tbx_number_of_play
            // 
            this.tbx_number_of_play.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_number_of_play.Location = new System.Drawing.Point(167, 70);
            this.tbx_number_of_play.Name = "tbx_number_of_play";
            this.tbx_number_of_play.Size = new System.Drawing.Size(139, 23);
            this.tbx_number_of_play.TabIndex = 13;
            // 
            // lbl_average_minutes_watched
            // 
            this.lbl_average_minutes_watched.AutoSize = true;
            this.lbl_average_minutes_watched.Location = new System.Drawing.Point(10, 44);
            this.lbl_average_minutes_watched.Name = "lbl_average_minutes_watched";
            this.lbl_average_minutes_watched.Size = new System.Drawing.Size(150, 15);
            this.lbl_average_minutes_watched.TabIndex = 10;
            this.lbl_average_minutes_watched.Text = "Average minutes watched :";
            // 
            // tbx_average_minutes_watched
            // 
            this.tbx_average_minutes_watched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_average_minutes_watched.Location = new System.Drawing.Point(167, 41);
            this.tbx_average_minutes_watched.Name = "tbx_average_minutes_watched";
            this.tbx_average_minutes_watched.Size = new System.Drawing.Size(139, 23);
            this.tbx_average_minutes_watched.TabIndex = 11;
            // 
            // lbl_discussions_message
            // 
            this.lbl_discussions_message.AutoSize = true;
            this.lbl_discussions_message.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_discussions_message.Location = new System.Drawing.Point(45, 141);
            this.lbl_discussions_message.Name = "lbl_discussions_message";
            this.lbl_discussions_message.Size = new System.Drawing.Size(272, 15);
            this.lbl_discussions_message.TabIndex = 16;
            this.lbl_discussions_message.Text = "Discussion engagement score is not calculated yet";
            // 
            // lbl_number_of_unread_posts
            // 
            this.lbl_number_of_unread_posts.AutoSize = true;
            this.lbl_number_of_unread_posts.Location = new System.Drawing.Point(11, 103);
            this.lbl_number_of_unread_posts.Name = "lbl_number_of_unread_posts";
            this.lbl_number_of_unread_posts.Size = new System.Drawing.Size(142, 15);
            this.lbl_number_of_unread_posts.TabIndex = 14;
            this.lbl_number_of_unread_posts.Text = "Number of unread posts :";
            // 
            // tbx_number_of_unread_posts
            // 
            this.tbx_number_of_unread_posts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_number_of_unread_posts.Location = new System.Drawing.Point(167, 100);
            this.tbx_number_of_unread_posts.Name = "tbx_number_of_unread_posts";
            this.tbx_number_of_unread_posts.Size = new System.Drawing.Size(139, 23);
            this.tbx_number_of_unread_posts.TabIndex = 15;
            // 
            // lbl_number_of_comments
            // 
            this.lbl_number_of_comments.AutoSize = true;
            this.lbl_number_of_comments.Location = new System.Drawing.Point(11, 74);
            this.lbl_number_of_comments.Name = "lbl_number_of_comments";
            this.lbl_number_of_comments.Size = new System.Drawing.Size(131, 15);
            this.lbl_number_of_comments.TabIndex = 12;
            this.lbl_number_of_comments.Text = "Number of comments :";
            // 
            // tbx_number_of_comments
            // 
            this.tbx_number_of_comments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_number_of_comments.Location = new System.Drawing.Point(167, 71);
            this.tbx_number_of_comments.Name = "tbx_number_of_comments";
            this.tbx_number_of_comments.Size = new System.Drawing.Size(139, 23);
            this.tbx_number_of_comments.TabIndex = 13;
            // 
            // lbl_number_of_questions
            // 
            this.lbl_number_of_questions.AutoSize = true;
            this.lbl_number_of_questions.Location = new System.Drawing.Point(11, 45);
            this.lbl_number_of_questions.Name = "lbl_number_of_questions";
            this.lbl_number_of_questions.Size = new System.Drawing.Size(125, 15);
            this.lbl_number_of_questions.TabIndex = 10;
            this.lbl_number_of_questions.Text = "Number of questions :";
            // 
            // tbx_number_of_questions
            // 
            this.tbx_number_of_questions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_number_of_questions.Location = new System.Drawing.Point(167, 42);
            this.tbx_number_of_questions.Name = "tbx_number_of_questions";
            this.tbx_number_of_questions.Size = new System.Drawing.Size(139, 23);
            this.tbx_number_of_questions.TabIndex = 11;
            // 
            // lbl_quizzes_message
            // 
            this.lbl_quizzes_message.AutoSize = true;
            this.lbl_quizzes_message.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_quizzes_message.Location = new System.Drawing.Point(47, 137);
            this.lbl_quizzes_message.Name = "lbl_quizzes_message";
            this.lbl_quizzes_message.Size = new System.Drawing.Size(240, 15);
            this.lbl_quizzes_message.TabIndex = 16;
            this.lbl_quizzes_message.Text = "Quiz engagement score is not calculated yet";
            // 
            // lbl_average_number_of_attempts
            // 
            this.lbl_average_number_of_attempts.AutoSize = true;
            this.lbl_average_number_of_attempts.Location = new System.Drawing.Point(11, 99);
            this.lbl_average_number_of_attempts.Name = "lbl_average_number_of_attempts";
            this.lbl_average_number_of_attempts.Size = new System.Drawing.Size(130, 15);
            this.lbl_average_number_of_attempts.TabIndex = 14;
            this.lbl_average_number_of_attempts.Text = "Average # of attempts :";
            // 
            // tbx_average_number_of_attempts
            // 
            this.tbx_average_number_of_attempts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_average_number_of_attempts.Location = new System.Drawing.Point(167, 96);
            this.tbx_average_number_of_attempts.Name = "tbx_average_number_of_attempts";
            this.tbx_average_number_of_attempts.Size = new System.Drawing.Size(139, 23);
            this.tbx_average_number_of_attempts.TabIndex = 15;
            // 
            // lbl_average_quiz_score
            // 
            this.lbl_average_quiz_score.AutoSize = true;
            this.lbl_average_quiz_score.Location = new System.Drawing.Point(11, 70);
            this.lbl_average_quiz_score.Name = "lbl_average_quiz_score";
            this.lbl_average_quiz_score.Size = new System.Drawing.Size(112, 15);
            this.lbl_average_quiz_score.TabIndex = 12;
            this.lbl_average_quiz_score.Text = "Average quiz score :";
            // 
            // tbx_average_quiz_score
            // 
            this.tbx_average_quiz_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_average_quiz_score.Location = new System.Drawing.Point(167, 67);
            this.tbx_average_quiz_score.Name = "tbx_average_quiz_score";
            this.tbx_average_quiz_score.Size = new System.Drawing.Size(139, 23);
            this.tbx_average_quiz_score.TabIndex = 13;
            // 
            // lbl_number_of_failed_questions
            // 
            this.lbl_number_of_failed_questions.AutoSize = true;
            this.lbl_number_of_failed_questions.Location = new System.Drawing.Point(11, 41);
            this.lbl_number_of_failed_questions.Name = "lbl_number_of_failed_questions";
            this.lbl_number_of_failed_questions.Size = new System.Drawing.Size(120, 15);
            this.lbl_number_of_failed_questions.TabIndex = 10;
            this.lbl_number_of_failed_questions.Text = "# of failed questions :";
            // 
            // tbx_number_of_failed_questions
            // 
            this.tbx_number_of_failed_questions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_number_of_failed_questions.Location = new System.Drawing.Point(167, 38);
            this.tbx_number_of_failed_questions.Name = "tbx_number_of_failed_questions";
            this.tbx_number_of_failed_questions.Size = new System.Drawing.Size(139, 23);
            this.tbx_number_of_failed_questions.TabIndex = 11;
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_calculate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calculate.Location = new System.Drawing.Point(292, 527);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(243, 37);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "Calculate Engagement Scores ";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_overall
            // 
            this.lbl_overall.AutoSize = true;
            this.lbl_overall.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_overall.Location = new System.Drawing.Point(283, 499);
            this.lbl_overall.Name = "lbl_overall";
            this.lbl_overall.Size = new System.Drawing.Size(264, 15);
            this.lbl_overall.TabIndex = 5;
            this.lbl_overall.Text = "Overall engagement score will be displayed here.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 604);
            this.Controls.Add(this.lbl_overall);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.gb_quizzes);
            this.Controls.Add(this.gb_videos);
            this.Controls.Add(this.gb_discussions);
            this.Controls.Add(this.gb_readings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_readings.ResumeLayout(false);
            this.gb_readings.PerformLayout();
            this.gb_discussions.ResumeLayout(false);
            this.gb_discussions.PerformLayout();
            this.gb_videos.ResumeLayout(false);
            this.gb_videos.PerformLayout();
            this.gb_quizzes.ResumeLayout(false);
            this.gb_quizzes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gb_readings;
        private Label lbl_reading_message;
        private Label lbl_number_of_unread_pages;
        private TextBox tbx_number_of_unread_pages;
        private Label c;
        private TextBox tbx_number_of_highlight;
        private Label lbl_number_of_page_views;
        private TextBox tbx_number_of_page_views;
        private GroupBox gb_discussions;
        private Label lbl_discussions_message;
        private Label lbl_number_of_unread_posts;
        private TextBox tbx_number_of_unread_posts;
        private Label lbl_number_of_comments;
        private TextBox tbx_number_of_comments;
        private Label lbl_number_of_questions;
        private TextBox tbx_number_of_questions;
        private GroupBox gb_videos;
        private Label lbl_videos_message;
        private Label lbl_minutes_skipped;
        private TextBox tbx_minutes_skipped;
        private Label lbl_number_of_play;
        private TextBox tbx_number_of_play;
        private Label lbl_average_minutes_watched;
        private TextBox tbx_average_minutes_watched;
        private GroupBox gb_quizzes;
        private Label lbl_quizzes_message;
        private Label lbl_average_number_of_attempts;
        private TextBox tbx_average_number_of_attempts;
        private Label lbl_average_quiz_score;
        private TextBox tbx_average_quiz_score;
        private Label lbl_number_of_failed_questions;
        private TextBox tbx_number_of_failed_questions;
        private Label lbl_header;
        private Button btn_calculate;
        private Label lbl_overall;
    }
}