using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module8_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This  method should add ☑ to the end of labelText and return it
        private string AddCheckBoxToMessage(string labelText)
        {
            //Check if labelText contains ❌, if so delete ❌
            //YOUR CODE GOES HERE
            int index = labelText.IndexOf("❌");
            if (index != -1)
            {
                labelText = labelText.Remove(index);
            }

            //Check if labelText contains ☑, if not add ☑ to the end of labelText
            //YOUR CODE GOES HERE
            if (!labelText.Contains("☑"))
            {
                labelText = labelText.Insert(labelText.Length - 1, "☑");
            }


            return labelText;
        }

        //This  method should add ❌ to the end of labelText and return it
        private string AddCrossToMessage(string labelText)
        {
            //Check if labelText contains ☑, if so delete ☑
            //YOUR CODE GOES HERE
            int index = labelText.IndexOf("☑");
            if (index != -1)
            {
                labelText = labelText.Remove(index);
            }

            //Check if labelText contains ❌, if not add ❌ to the end of labelText
            //YOUR CODE GOES HERE
            if (!labelText.Contains("❌"))
            {
                labelText = labelText.Insert(labelText.Length - 1, "❌");
            }
            return labelText;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            //CHECK THE LENGHT REQUIREMENT
            //Write the if-else condition in which you need to call CheckLength.
            ////(1)If CheckLength returns TRUE,
            ////////(1.1)make a proper call to AddCheckBoxToMessage
            ////////(1.2)update the lbl_length text
            ////////(1.3)set the font color of lbl_length text to Green.
            ////(2)If CheckLength returns FALSE
            ////////(2.1)make a proper call to AddCrossToMessage
            ////////(2.2)update the lbl_length text
            ////////(2.3)set the font color of lbl_length text to Red.
            //YOUR CODE GOES HERE
            if (CheckLength(txt_password.Text))
            {
                AddCheckBoxToMessage(txt_password.Text);
                lbl_length.Text = "Password length is valid!";
                lbl_length.ForeColor = Color.Green;
            }
            else
            {
                AddCrossToMessage(txt_password.Text);
                lbl_length.Text = "Password length should be at least 10!";
                lbl_length.ForeColor = Color.Red;
            }
            //CHECK THE UPPERCASE REQUIREMENT
            //YOUR CODE GOES HERE
            if (CheckUpperCase(txt_password.Text))
            {
                AddCheckBoxToMessage(txt_password.Text);
                lbl_upper.Text = "Password have valid number of uppercase letters!";
                lbl_upper.ForeColor = Color.Green;

            }
            else
            {
                AddCrossToMessage(txt_password.Text);
                lbl_upper.Text = "Password should contain at least 3 uppercase letters!";
                lbl_upper.ForeColor = Color.Red;
            }
            //CHECK THE LOWERCASE REQUIREMENT
            //YOUR CODE GOES HERE
            if (CheckLowerCase(txt_password.Text))
            {
                AddCheckBoxToMessage(txt_password.Text);
                lbl_lower.Text = "Password have valid number of lowercase letters!";
                lbl_lower.ForeColor = Color.Green;

            }
            else
            {
                AddCrossToMessage(txt_password.Text);
                lbl_lower.Text = "Password should contain at least 2 lowercase letters!";
                lbl_lower.ForeColor = Color.Red;
            }
            //CHECK THE NUMERIC REQUIREMENT
            //YOUR CODE GOES HERE
            if (CheckDigit(txt_password.Text))
            {
                AddCheckBoxToMessage(txt_password.Text);
                lbl_digits.Text = "Password have valid number of numeric digits!";
                lbl_digits.ForeColor = Color.Green;

            }
            else
            {
                AddCrossToMessage(txt_password.Text);
                lbl_digits.Text = "Password should contain at least 2 numbers!";
                lbl_digits.ForeColor = Color.Red;
            }


            //OPTIONAL FUNCTIONALITY//
            //This part will not be graded!//
            //Once all requirements are met, do not let users enter new text.
            if (CheckLength(txt_password.Text) && CheckUpperCase(txt_password.Text) && CheckLowerCase(txt_password.Text) && CheckDigit(txt_password.Text))
            {
                txt_password.ReadOnly = true;
            }
        }

        #region Method for Checking Requirements
        //All methods for checking various requirements are already defined below.
        //All these methods return true if the requirement is satisfied.

        private bool CheckLength(string password)
        {
            return (password.Length >= 10);
        }

        private bool CheckUpperCase(string password)
        {
            int upperCaseCount = 0;

            foreach (char ch in password)
            {
                if (char.IsUpper(ch))
                {
                    upperCaseCount++;
                }
            }

            return (upperCaseCount >= 3);
        }

        private bool CheckLowerCase(string password)
        {
            int lowerCaseCount = 0;

            for (int x = 0; x < password.Length; x++)
            {
                if (char.IsLower(password, x))
                {
                    lowerCaseCount++;
                }
            }

            return (lowerCaseCount >= 2);
        }

        private bool CheckDigit(string password)
        {
            int digitCount = 0;

            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitCount++;
                }
            }

            return (digitCount >= 2);
        }
        #endregion
    }
}
