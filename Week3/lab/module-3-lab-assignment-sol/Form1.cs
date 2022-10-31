using System.Text;
namespace module3_lab_ali_vlyv
{
    public partial class frm_user_registration_application : Form
    {
        public frm_user_registration_application()
        {
            InitializeComponent();
        }
        StringBuilder summary_sb = new StringBuilder();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tp_address_info_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_profile_info_Click(object sender, EventArgs e)
        {
            tc_user_registration.SelectedTab = tp_address_info;
        }

        private void btn_back_address_info_Click(object sender, EventArgs e)
        {
            tc_user_registration.SelectedTab = tp_profile_info;
        }

        private void btn_next_address_info_Click(object sender, EventArgs e)
        {
            tc_user_registration.SelectedTab = tp_summary;
            summary_sb.Append("----Registration Summary----").AppendLine(" ");
            summary_sb.AppendLine(" ");
            summary_sb.Append(tb_first_name.Text).Append("  ").AppendLine(tb_last_name.Text).AppendLine(tb_email.Text);
            summary_sb.AppendLine(" ");
            summary_sb.Append("Address Type: ").AppendLine(cb_address_type.Text).AppendLine(tb_address_line.Text);
            lbl_summary.Text = summary_sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tc_user_registration.SelectedTab = tp_address_info;
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration is completed", "Success");
        }
    }
}