using System;
using System.Collections.Generic;
using System.Text;

namespace Final_assıgnment_ali.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Abbreviation { get; set; }
        public string Name { get; set; }


        public List<Course> Courses { get; set; }
    }
}
