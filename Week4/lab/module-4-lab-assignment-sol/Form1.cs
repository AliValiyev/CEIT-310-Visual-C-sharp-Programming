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
            try
            {
                int number_of_page_views = int.Parse(tbx_number_of_page_views.Text);
                int number_of_highlights = int.Parse(tbx_number_of_highlight.Text);
                int number_of_unread_pages = int.Parse(tbx_number_of_unread_pages.Text);
                reading = (number_of_page_views + number_of_highlights) / number_of_unread_pages;
                lbl_reading_message.Text = "Reading score is : " + reading.ToString();
                lbl_reading_message.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                lbl_reading_message.Text = "Invalid entry in the Reading box. ";
                lbl_reading_message.ForeColor = Color.Red;
            }



            try
            {
                int number_of_questions = int.Parse(tbx_number_of_questions.Text);
                int number_of_comments = int.Parse(tbx_number_of_comments.Text);
                int number_of_unread_posts = int.Parse(tbx_number_of_unread_posts.Text);
                discussions = (number_of_questions + number_of_comments) / number_of_unread_posts;
                lbl_discussions_message.Text = "Discussion score is : " + discussions.ToString();
                lbl_discussions_message.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                lbl_discussions_message.Text = "Invalid entry in the Discussion box. ";
                lbl_discussions_message.ForeColor = Color.Red;
            }



            try
            {
                double average_minutes_watched = double.Parse(tbx_average_minutes_watched.Text);
                int number_of_play = int.Parse(tbx_number_of_play.Text);
                int minutes_skipped = int.Parse(tbx_minutes_skipped.Text);
                videos = (average_minutes_watched + number_of_play) / minutes_skipped;
                videos = Math.Round(videos, 2);
                lbl_videos_message.Text = "Video score is : " + videos.ToString();
                lbl_videos_message.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                lbl_videos_message.Text = "Invalid entry in the Videos box. ";
                lbl_videos_message.ForeColor = Color.Red;
            }



            try
            {
                int number_of_failed_questions = int.Parse(tbx_number_of_failed_questions.Text);
                double average_quiz_score = double.Parse(tbx_average_quiz_score.Text);
                double average_number_of_attempts = double.Parse(tbx_average_number_of_attempts.Text);
                quizzes = (number_of_failed_questions + average_quiz_score) / average_number_of_attempts;
                quizzes = Math.Round(quizzes, 2);
                lbl_quizzes_message.Text = "Quiz score is : " + quizzes.ToString();
                lbl_quizzes_message.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                lbl_quizzes_message.Text = "Invalid entry in the Quizzes box. ";
                lbl_quizzes_message.ForeColor = Color.Red;
            }

            double overall = reading + discussions + videos + quizzes;
            overall = Math.Round(overall, 2);
            lbl_overall.Text = "General engagement score is : " + overall.ToString();
            lbl_overall.ForeColor = Color.Blue;

        }
    }
}
