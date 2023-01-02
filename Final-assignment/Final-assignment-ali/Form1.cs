using Final_assıgnment_ali.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_assıgnment_ali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DepDbContext db = new DepDbContext();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCourses();
        }

        private void btn_createdep_Click(object sender, EventArgs e)
        {try
            {
                Department department = new Department
                {
                    Name = tbx_name.Text,
                    Abbreviation = tbx_abbreviation.Text,
                };
                db.Departments.Add(department);
                db.SaveChanges();
                lbl_confirmation_deps.Text = "Deparment has succesfully created";
                tbx_name.Text = "";
            }
            catch (Exception ex)
            {
                lbl_confirmation_deps.Text = "An error has occured. More info:" + ex.Message;
            }

                    }

        private void btn_create_course_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = new Course()
                {
                    Title = tbx_title.Text,
                    Coursecode = int.Parse(tbx_coursecode.Text),
                    Type = tbx_type.Text,
                    Capacity = int.Parse(tbx_capacity.Text),
                    Courseİd = (int)cmb_departmentforcourse.SelectedValue
                };
            }
            catch (Exception ex) { lbl_confirmationmesseagforcourses.Text = "An error has occured. More info:" + ex.Message; }
            }
        private void BindDepartments()
        {
            
            lstb_deps.ValueMember = "DepartmentId";
            lstb_deps.DisplayMember = "Name" + " " + "Abbreviation";
            lstb_deps.DataSource = db.Departments.ToList();

        }
        private void BindCourses()
        {
            int selectedDepartmentId = (int)lstb_deps.SelectedValue;
            lstb_courses.ValueMember = "CourseId";
            lstb_courses.DisplayMember = "Course Code" + " " + "Title";
            lstb_courses.DataSource = db.Courses.Where(s => s.Id == selectedDepartmentId).ToList();

        }
        private void btn_delete_dep_Click(object sender, EventArgs e)
        {
                int departmentId = (int)lstb_deps.SelectedValue;
                
            if (db.Departments.Count(s => s.DepartmentId == departmentId) == 0)
            {
                 Department departmentToDelete = db.Departments.Find(departmentId);
                db.Departments.Remove(departmentToDelete);
                db.SaveChanges();
                BindDepartments();
            }
            else
            {
                MessageBox("Department has at least one courses");
            }
        }

        private void MessageBox(string v)
        {
            throw new NotImplementedException();
        }

        private void btn_delete_course_Click(object sender, EventArgs e)
        {
            foreach(Course c in lstb_courses.SelectedItems)
            {
                Course courseToDelete = db.Courses.Find(c);
                db.Courses.Remove(courseToDelete);
                db.SaveChanges();
                BindCourses();
            }
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDepartments();
        }

        private void txb_filter_deps_TextChanged(object sender, EventArgs e)
        {
            List<Department> searchresultfordeps = new List<Department>();
            searchresultfordeps = db.Departments.Where(s => s.Name.Contains(txb_filter_deps.Text)).ToList();
            lstb_deps.DataSource = searchresultfordeps;
        }

        private void txb_filter_courses_TextChanged(object sender, EventArgs e)
        {
            List<Course> searchresultforcourses = new List<Course>();
            searchresultforcourses = db.Courses.Where(s => s.Title.Contains(txb_filter_courses.Text)).ToList();
            lstb_courses.DataSource = searchresultforcourses;
        }
    }
    }
    

