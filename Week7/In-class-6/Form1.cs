using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnclass_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> students = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            students.Add("Fatma");
            students.Add("Hakan");
            students.Add("Furkan");

            ListStudents(students);
        }
        private void ListStudents(List <string> students)
        {
   
            lb_students.Items.Clear();
            foreach(string student in students)
            {
                lb_students.Items.Add(student);
            }    
            
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            students.Add(tbx_add.Text);
            ListStudents(students);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            int Index1 = lb_students.SelectedIndex;
            string tmb = students[Index1];
            students[Index1] = students[Index1-1];
            ListStudents(students);

        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            int Index1 = lb_students.SelectedIndex;
            string tmb = students[Index1];
            students[Index1] = students[Index1 + 1];
            students[Index1 + 1] = tmb;
            ListStudents(students);

        }

        private void btn_remove_selected_item_Click(object sender, EventArgs e)
        {
            students.Remove(lb_students.SelectedItem.ToString());
            ListStudents(students);

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            students.RemoveAt(students.Count - 1);
            ListStudents(students);

        }
    }
}
