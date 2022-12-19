using in_class11.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace in_class11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void AddStudent ()
        {
            Student a1 = new Student
            {

                Name = "Serkan",
                Surname = "Berkan",
                Grade = "10,50"
            };
        }
    }
}
