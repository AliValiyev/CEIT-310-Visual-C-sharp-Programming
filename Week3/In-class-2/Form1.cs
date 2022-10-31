using System.Text;

namespace inclass_assignment_ali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder sb_history = new StringBuilder();
        DateTime lastClickedTime = new DateTime();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            sb_history.AppendLine(DateTime.Now.ToString() + " : Mouse down. ");
            lbl_history.Text = sb_history.ToString();
            lastClickedTime = DateTime.Now;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            sb_history.AppendLine((DateTime.Now - lastClickedTime).TotalSeconds.ToString() + " second later. ");
            sb_history.AppendLine(DateTime.Now.ToString() + " : Mouse up. ");
            lbl_history.Text = sb_history.ToString();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            sb_history.AppendLine(DateTime.Now.ToString() + " : Double click on the form. ");
            lbl_history.Text = sb_history.ToString();
        }
        private void lbl_history_Click(object sender, EventArgs e)
        {
            sb_history.AppendLine(DateTime.Now.ToString() + " : Single click on the label. ");
            lbl_history.Text = sb_history.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sb_history.AppendLine(DateTime.Now.ToString() + " : Single click. ");
            lbl_history.Text = sb_history.ToString();
        }
    }
}