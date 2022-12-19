using System;
using System.Collections.Generic;
using System.Text;

namespace in_class11.Model
{
    public class Student
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Grade { get; set; }

    public double ShowReport()
        {
            return 2.5;
        }
    }
}
