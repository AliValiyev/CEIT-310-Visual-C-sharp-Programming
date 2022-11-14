using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module6_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //DO NOT CHANGE THIS PART
            CopyArraysToLists();//Creates the section1 and section2 lists based on the arrays
            BindSectionData();//Binds section1 and section2 lists to lst_section1 and lst_section2 list controls
            CheckOverlappingItems();//Checks if lst_section1 and lst_section2 have an overlapping item.
            CompareListSize();//Checks if lst_section1 and lst_section2 have the same number of items
        }


        #region PART1 : CREATING AND INITIALIZING VARIABLES
        /// <summary>
        /// In Part1, you need to define some array and list objects
        /// </summary>
        /// <Difficulty 1/5></Difficulty>
        /// <Points value="0.1"></Points>

        //Initialize a string array called section1_array with values Ahmet, David, Sara, Rodrigo, Fatma, Ilkem 
        //YOUR CODE GOES HERE

        //Initialize a string array called section2_array with values Onur, Nehir, "Gustavo, Ahmet", "Sara, "Fatma", "Deniz", "Eduardo", "Paulo"
        //YOUR CODE GOES HERE

        //Create two string List objects, named section1 and section2
        //YOUR CODE GOES HERE

        #endregion


        #region PART2 : COPYING ARRAYS TO LISTS
        /// <summary>
        /// This part simply involves defining a method called CopyArraysToLists
        /// This method should copy the contents of section1_array to section1 list, and 
        /// copy the contents of section2_array to section2 list.
        /// </summary>
        /// <Difficulty 2/5></Difficulty>
        /// <Points value="0.2"></Points>

        //This method copy the contents of the arrays into the list objects
        private void CopyArraysToLists()
        {
            //UNCOMMENT AND REVISE THE FOLLOWING CODE
            //foreach ()
            //{
            //    section1.Add();
            //}

            //foreach ()
            //{
            //    section2.Add();
            //}
        }
        #endregion


        #region PART3: POPULATING THE LISTBOXES
        /// <summary>
        /// Im this part, you need to define a method called BindSectionData
        /// This method should append new all items in section1 to lst_section1 and
        /// append all items in section2 to lst_section2
        /// </summary>
        /// <Difficulty 2/5></Difficulty>
        /// <Points value="0.3"></Points>


        //This method binds the section1 and secion2 to list controls: lst_section1 and lst_section2
        private void BindSectionData()
        {
            //DO NOT DELETE THESE TWO LINES
            lst_section1.Items.Clear();
            lst_section2.Items.Clear();


            //Use a loop to add items inside section1 list to lst_section1 listbox
            //YOUR CODE GOES HERE


            //Use a loop to add items inside section2 list to lst_section2 listbox
            //YOUR CODE GOES HERE
            
        }

        #endregion
      

        #region PART4: CHECKING IF SECTIONS HAVE OVERLAPS
        /// <summary>
        /// In this part, you need to define a method called CheckOverlappingItems
        /// This method should check if section1 and section2 lists have a common student (in other words, overlaps)
        /// The details of the implementation are provided inside the method below.
        /// </summary>
        /// <Difficulty 4/5></Difficulty>
        /// <Points value="0.6"></Points>


        private void CheckOverlappingItems()
        {
            //This variable will be set to true if there is any overlap
            bool overlaps = false;

            for (/*write code here to define the for loop header*/)//outer loop will traverse lst_section1
            {
                for (/*write code here to define the for loop header*/)//inner loop will traverse lst_section1
                {
                    //Check if the traversed items matches 
                    if (lst_section1.Items[/*write the proper index variable*/].ToString() == lst_section2.Items[/*write the proper index variable*/].ToString())
                    {
                        //Do not change the code below
                        overlaps = true;//there is match, so lets set it to true
                        break;//no need to continue iterating the loops
                    }
                }
            }
            if (overlaps)
            {
                //Change the text of lbl_overlapping to "There are overlapping items." and set its font color to red.
                //YOUR CODE GOES HERE
            }
            else
            {
                //Change the text of lbl_overlapping to "No overlapping items." and set its font color to blue.
                //YOUR CODE GOES HERE
            }

        }

        #endregion


        #region PART5: CHECKING IF SECTIONS HAVE THE SAME NUMBER OF STUDENTS
        /// <summary>
        /// In this part, you need to define a method called CompareListSize
        /// This method should check if section1 and section2 have the same size.
        /// The details of the implementation are provided inside the method below.
        /// </summary>
        /// <Difficulty 2/5></Difficulty>
        /// <Points value="0.2"></Points>

        private void CompareListSize()
        {
            //Write the necessary if-else statement to compare the length of the lst_section1 and lst_section2
            //If the size are equal change the text of lbl_sizeComparison to "Lists contain the same number of items."
            //and set its font color to blue.
            //If the size are NOT equal change the text of lbl_sizeComparison to "Lists have a different number of items."
            //and set its font color to red.
            //YOUR CODE GOES HERE
        }

        #endregion


        #region PART6: MOVING STUDENTS BETWEEN SECTIONS
        /// <summary>
        /// In this part, you need to write the necessary code 
        /// for the click event handlers of two buttons: 
        /// >> button (to move the selected students from section1 to section2)
        /// << button (to move the selected students from section2 to section1)
        /// Detailed instructors for implementation are provided below.
        /// </summary>
        /// <Difficulty 4/5></Difficulty>
        /// <Points value="0.6"></Points>


        //Right button click should move the selected items from section1 to section2
        //If the item already exists in section2, it should not be added but should be removed from section1
        private void btn_moveToRight_Click(object sender, EventArgs e)
        {
            //Multiple items can be selected in the list
            //we will use foreach loop to iterate through its SelectedIndices property
            //SelectedIndices property holds the indices of the selected items in a list
            foreach (int x in lst_section1.SelectedIndices)
            {
                //the selected item is assigned to itemToBemoved variable at each iteration
                string itemToBemoved = lst_section1.Items[x].ToString();

                //Write the necessary code to remove itemToBemoved from section1.
                //YOUR CODE GOES HERE

                //Write if condition (not if-else) to check if section2 contains itemToBemoved
                //If it does NOT contain it, please insert itemToBemoved to section2 at index 0.
                //YOUR CODE GOES HERE

            }

            //Do not change the code below
            BindSectionData();
            CheckOverlappingItems();
            CompareListSize();
        }


        //Left button click should move the selected items from section2 to section1
        //If the item already exists in section1, it should not be added but should be removed from section2
        private void btn_moveToLeft_Click(object sender, EventArgs e)
        {
            //Following the approach applied in btn_moveToRight_Click above,
            //please write the complete code for moving items from right to left.
        }

        #endregion
    }
}
