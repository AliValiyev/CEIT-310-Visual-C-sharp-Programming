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

            //Check if labelText contains ☑, if not add ☑ to the end of labelText
            //YOUR CODE GOES HERE

            return labelText;
        }

        //This  method should add ❌ to the end of labelText and return it
        private string AddCrossToMessage(string labelText)
        {
            //Check if labelText contains ☑, if so delete ☑
            //YOUR CODE GOES HERE

            //Check if labelText contains ❌, if not add ❌ to the end of labelText
            //YOUR CODE GOES HERE

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

            //CHECK THE UPPERCASE REQUIREMENT
            //YOUR CODE GOES HERE

            //CHECK THE LOWERCASE REQUIREMENT
            //YOUR CODE GOES HERE

            //CHECK THE NUMERIC REQUIREMENT
            //YOUR CODE GOES HERE


            //OPTIONAL FUNCTIONALITY//
            //This part will not be graded!//
            //Once all requirements are met, do not let users enter new text.

        }

        #region Method for Checking Requirements
        //All methods for checking various requirements are alread defined below.
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
