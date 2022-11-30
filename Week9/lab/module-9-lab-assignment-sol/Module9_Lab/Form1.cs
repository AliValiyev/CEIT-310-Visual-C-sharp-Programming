using Module9_Lab.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module9_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingList<Person> people = new BindingList<Person>();
        BindingList<Person> usersFiltered = new BindingList<Person>();
        int idTracker = 0;

        
        bool filterName = false;
        bool filterSurname = false;
        bool filterYear = false;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            BindPeopleToListBox(people);
        }

        private void BindPeopleToListBox(BindingList<Person> data)
        {
            lst_users.DataSource = data;
            lst_users.ValueMember = "Id";
            lst_users.DisplayMember = "Name";
        }

        private void ResetForm()
        {
            idTracker++;
            txt_name.Text = "";
            txt_surname.Text = "";
            txt_year.Text = "";
            txt_place.Text = "";
        }

        private void btn_addOrEdit_Click(object sender, EventArgs e)
        {
            if (btn_addOrEdit.Text == "Add User")
            {
                Person person = new Person();
                person.Id = idTracker;
                person.Name = txt_name.Text;
                person.Surname = txt_surname.Text;
                person.Birthyear = txt_year.Text;
                person.Birthplace = txt_place.Text;
                people.Add(person);
                ResetForm();
            }
            else if (btn_addOrEdit.Text == "Apply")
            {
                int personId = (int)lst_users.SelectedValue;
                Person person = people.Single(c => c.Id == personId);
                int oldId = person.Id;
                people.Remove(person);

                person = new Person();
                person.Id = oldId;
                person.Name = txt_name.Text;
                person.Surname = txt_surname.Text;
                person.Birthyear = txt_year.Text;
                person.Birthplace = txt_place.Text;
                people.Add(person);

                btn_addOrEdit.Text = "Add User";
                ResetForm();
            }
        }
           

        private void btn_showDetails_Click(object sender, EventArgs e)
        {
            int personId = (int) lst_users.SelectedValue;
            Person person = people.Single(c => c.Id == personId);

            lbl_details.Text = person.Name + " " + person.Surname + " was born in " + person.Birthplace + " in " + person.Birthyear;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int personId = (int)lst_users.SelectedValue;
            Person person = people.Single(c => c.Id == personId);
            people.Remove(person);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int personId = (int)lst_users.SelectedValue;
            Person person = people.Single(c => c.Id == personId);

            btn_addOrEdit.Text = "Apply";

            txt_name.Text = person.Name;
            txt_place.Text = person.Birthplace;
            txt_surname.Text = person.Surname;
            txt_year.Text = person.Birthyear;
        }

        private void txt_filterName_TextChanged(object sender, EventArgs e)
        {
            if (txt_filterName.Text != "")
            {
                usersFiltered =  new BindingList<Person> (people.Where(u => u.Name.StartsWith(txt_filterName.Text) && u.Surname.StartsWith(txt_filterSurname.Text) && u.Birthyear.StartsWith(txt_filterYear.Text)).ToList());
                BindPeopleToListBox(usersFiltered);
                filterName = true;
            }
            else
            {
                filterName = false;
                if (filterName == false && filterSurname == false && filterYear == false)
                {
                    BindPeopleToListBox(people);
                }
                
            }
        }

        private void txt_filterSurname_TextChanged(object sender, EventArgs e)
        {
            /*if (txt_filterSurname.Text != "")
            {
                usersFiltered = (BindingList<Person>) people.Where(u => u.Surname.StartsWith(txt_filterSurname.Text));
                BindPeopleToListBox(usersFiltered);
                filterSurname = true;
            }
            else
            {
                filterSurname = false;
                if (filterName == false && filterSurname == false && filterYear == false)
                {
                    BindPeopleToListBox(people);
                }

            }*/
        }

        private void txt_filterYear_TextChanged(object sender, EventArgs e)
        {
            /*if (txt_filterYear.Text != "")
            {
                usersFiltered = (BindingList<Person>) people.Where(u => u.Birthyear.StartsWith(txt_filterYear.Text));
                BindPeopleToListBox(usersFiltered);
                filterYear = true;
            }
            else
            {
                filterYear = false;
                if (filterName == false && filterSurname == false && filterYear == false)
                {
                    BindPeopleToListBox(people);
                }

            }*/
        }
    }
}
