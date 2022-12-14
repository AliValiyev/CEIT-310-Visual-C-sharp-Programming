using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M7IndividualActivitiy
{
    public class Student
    {
        public Student() { }
        public Student( string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string DisplayName
        {
            get
            {
                return StudentId + " " + Name + " " + Surname;
            }
        }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Grades { get; set; }
        /*
        public string ShowReport()
        {

            int max = Grades.Max();
            int min = Grades.Min();
            double avg = Grades.Average();
            int greater = Grades.Count(grade => grade >= 60);
            int lower = Grades.Count(grade => grade < 60);
            return "Max score is:" + max + Environment.NewLine + "Min score is:" + min + Environment.NewLine + "Mean score is:" + avg + Environment.NewLine + "# of Scores>=" + greater + Environment.NewLine + "# of Scores<" + lower;
            
        }
        */
    }
}
