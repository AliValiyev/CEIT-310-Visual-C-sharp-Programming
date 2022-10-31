namespace lab_3_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int reading = 0, discussions = 0;
            double videos = 0, quizzes = 0;
            bool issuc1 = int.TryParse(tbx_number_of_page_views.Text, out int number_of_page_view);
            bool issuc2 = int.TryParse(tbx_number_of_highlight.Text, out int number_of_highlight);
            bool issuc3 = int.TryParse(tbx_number_of_unread_pages.Text, out int number_of_unread_page);
            bool issuc4 = int.TryParse(tbx_number_of_questions.Text, out int number_of_question);
            bool issuc5 = int.TryParse(tbx_number_of_comments.Text, out int number_of_comment);
            bool issuc6 = int.TryParse(tbx_number_of_unread_posts.Text, out int number_of_unread_post);
            bool issuc7 = double.TryParse(tbx_average_minutes_watched.Text, out double average_minutes_watch);
            bool issuc8 = int.TryParse(tbx_number_of_play.Text, out int number_of_played);
            bool issuc9 = int.TryParse(tbx_minutes_skipped.Text, out int minutes_skip);
            bool issuc10 = int.TryParse(tbx_number_of_failed_questions.Text, out int number_of_failed_question);
            bool issuc11 = double.TryParse(tbx_average_quiz_score.Text, out double average_quiz_scores);
            bool issuc12 = double.TryParse(tbx_average_number_of_attempts.Text, out double average_number_of_attempt);
            
            if (issuc1 == true && issuc2 == true && issuc3== true)
            {
                reading = (number_of_page_view + number_of_highlight) / number_of_unread_page;
                lbl_reading_message.Text = "Reading score is : " + reading.ToString();
                lbl_reading_message.ForeColor = Color.Blue;
            }
            else if (int.TryParse(tbx_number_of_page_views.Text, out int number_of_page_views) == false)
            {
                lbl_reading_message.Text = "Invalid entry in the page views textbox.";
                lbl_reading_message.ForeColor = Color.Red;
            }

            else if (int.TryParse(tbx_number_of_highlight.Text, out int number_of_highlights) == false)
            {
                lbl_reading_message.Text = "Invalid entry in the highlights textbox.";
                lbl_reading_message.ForeColor = Color.Red;
            }

            else if (int.TryParse(tbx_number_of_unread_pages.Text, out int number_of_unread_pages) == false)
            {
                lbl_reading_message.Text = "Invalid entry in the unread pages textbox.";
                lbl_reading_message.ForeColor = Color.Red;
            }



            if (issuc4 == true && issuc5 == true && issuc6 == true)
            {
                discussions = (number_of_question + number_of_comment) / number_of_unread_post;
                lbl_discussions_message.Text = "Discussion score is : " + discussions.ToString();
                lbl_discussions_message.ForeColor = Color.Blue;
            }

            else if (int.TryParse(tbx_number_of_questions.Text, out int number_of_questions) == false)
            {
                lbl_discussions_message.Text = "Invalid entry in the questions textbox.";
                lbl_discussions_message.ForeColor = Color.Red;
            }

            else if (int.TryParse(tbx_number_of_comments.Text, out int number_of_comments) == false)
            {
                lbl_discussions_message.Text = "Invalid entry in the comments textbox.";
                lbl_discussions_message.ForeColor = Color.Red;
            }

            else if (int.TryParse(tbx_number_of_unread_posts.Text, out int number_of_unread_posts) == false)
            {
                lbl_discussions_message.Text = "Invalid entry in the unread posts textbox.";
                lbl_discussions_message.ForeColor = Color.Red;
            }

            if (issuc7 == true && issuc8 == true && issuc9 == true)
            {
                videos = (average_minutes_watch + number_of_played) / minutes_skip;
                videos = Math.Round(videos, 2);
                lbl_videos_message.Text = "Video score is : " + videos.ToString();
                lbl_videos_message.ForeColor = Color.Blue;
            }

            else if (double.TryParse(tbx_average_minutes_watched.Text, out double average_minutes_watched) == false)
            {
                lbl_videos_message.Text = "Invalid entry in the average minutes watched textbox.";
                lbl_videos_message.ForeColor = Color.Red;
            }

            else if (int.TryParse(tbx_number_of_play.Text, out int number_of_play) == false)
            {
                lbl_videos_message.Text = "Invalid entry in the play/pause textbox.";
                lbl_videos_message.ForeColor = Color.Red;
            }

            else if (int.TryParse(tbx_minutes_skipped.Text, out int minutes_skipped) == false)
            {
                lbl_videos_message.Text = "Invalid entry in the minutes skipped textbox.";
                lbl_videos_message.ForeColor = Color.Red;
            }

            if (issuc10 == true && issuc11 == true && issuc12 == true)
            {
                quizzes = (number_of_failed_question + average_quiz_scores) / average_number_of_attempt;
                quizzes = Math.Round(quizzes, 2);
                lbl_quizzes_message.Text = "Quiz score is : " + quizzes.ToString();
                lbl_quizzes_message.ForeColor = Color.Blue;
            }

           else if (int.TryParse(tbx_number_of_failed_questions.Text, out int number_of_failed_questions) == false)
            {
                lbl_quizzes_message.Text = "Invalid entry in the failed questions textbox.";
                lbl_quizzes_message.ForeColor = Color.Red;
            }

           else if (double.TryParse(tbx_average_quiz_score.Text, out double average_quiz_score) == false)
            {
                lbl_quizzes_message.Text = "Invalid entry in the average quiz score textbox.";
                lbl_quizzes_message.ForeColor = Color.Red;
            }

           else if (double.TryParse(tbx_average_number_of_attempts.Text, out double average_number_of_attempts) == false)
            {
                lbl_quizzes_message.Text = "Invalid entry in the average number of attempts textbox.";
                lbl_quizzes_message.ForeColor = Color.Red;
            }

            double overall = reading + discussions + videos + quizzes;
            overall = Math.Round(overall, 2);
            lbl_overall.Text = "General engagement score is : " + overall.ToString();
            lbl_overall.ForeColor = Color.Blue;

        }
    }
}
