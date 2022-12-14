using M7IndividualActivitiy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M7IndividualActivitiy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void BindStudents()
        {
            StudentDbContext _db = new StudentDbContext();
            listBox1.DataSource = _db.Students.ToList();
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "StudentId";
        }

        public void AddStudent()
        {
            Student s1 = new Student("Erkan", "Er");
            s1.Grades = "90,80,60,50";

            Student s2 = new Student("Ceren", "Gökmen");
            s2.Grades = "40, 60, 70, 80";

            Student s3 = new Student("Eren", "Gökmen");
            s3.Grades = "60, 80, 60, 90";

            StudentDbContext _db = new StudentDbContext();

           
            if (_db.Students.ToList().Count() == 0)
            {
                _db.Students.Add(s1);
                _db.Students.Add(s2);
                _db.Students.Add(s3);
                _db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Already exists.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddStudent();
            BindStudents();
          

        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            
            List<Student> searchResult = new List<Student>();
            StudentDbContext _db=new StudentDbContext();

            if (rb_contains.Checked)
            {
                searchResult = _db.Students.Where(student => student.Name.Contains(textbox.Text)).ToList();
            }
            else if (rb_startsWith.Checked)
            {
                searchResult = _db.Students.Where(student => student.Name.StartsWith(textbox.Text)).ToList();
            }
            else if (rb_endsWith.Checked)
            {
                searchResult = _db.Students.Where(student => student.Name.EndsWith(textbox.Text)).ToList();
            }

            listBox1.DataSource = searchResult;
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            /*
            Student student = (Student)listBox1.SelectedItem;
            Student selectedStudent = students.Single(s => s.ID == student.ID);

            string show = selectedStudent.ShowReport();
            lb_report.Text = show.ToString();
            */


        }

        
    }
}
