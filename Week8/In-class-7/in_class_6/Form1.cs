using System.Linq;

namespace in_class_6
{
    public partial class Form1 : Form
    {
        List<string> students = new List<string>();
        List<string> grades = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_filter_TextChanged(object sender, EventArgs e)
        {
            List<string> searchResult = new List<string>();
            if (rb_contains.Checked)
            { searchResult = students.Where(name => name.Contains(tb_filter.ToString())).ToList(); }
            if (rb_start.Checked)
            { searchResult = students.Where(name => name.StartsWith(tb_filter.ToString())).ToList(); }
            if (rb_end.Checked)
            { searchResult = students.Where(name => name.EndsWith(tb_filter.ToString())).ToList(); } 
            listBox1.DataSource = students;

            int Index1 = searchResult.IndexOf(listBox1.SelectedItem.ToString());
            string[] myGradesString = grades[Index1].ToString().Split(',');
            int[] myGradesInt = Array.ConvertAll(myGradesString,int.Parse);
            List<int> gradesList = new List<int>(myGradesInt);
            float max_number = gradesList.Max();
            float min_number = gradesList.Min();
            float mean_number = (gradesList[0] + gradesList[1] + gradesList[2] + gradesList[3]) / 4;
            int k = 0, t = 0;
            foreach (int i in gradesList)
            {
                
                if (i >= 60)
                {
                    k = k + 1;
                }
                else { t = t + 1; }
            }
            lbl_number_of_scores1.Text = k.ToString();
            lbl_number_of_scores2.Text = t.ToString();
            lbl_max.Text = max_number.ToString();
            lbl_min.Text = min_number.ToString();
            lbl_mean.Text = mean_number.ToString();




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students.Add("Erkan");
            students.Add("Serkan");
            students.Add("Berkant");
            students.Add("Hakan");
            students.Add("Atakan");
            grades.Add("90,80,60,50");
            grades.Add("40,60,70,80");
            grades.Add("60,80,60,90");
            grades.Add("40,50,67,80");
            grades.Add("30,45,50,40");
            listBox1.DataSource= students;
        }
    }
}