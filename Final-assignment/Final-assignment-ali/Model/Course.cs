using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Final_assıgnment_ali.Model
{
    public class Course
    { public int Courseİd { get; set; }
      public string Title {get; set;}
      public int Coursecode { get; set;  }
      public string Type { get; set; }
      public int Capacity { get; set; }

      public Department Departmentofacourse { get; set; } 

    [ForeignKey("Departmentofacourse")]
    public int Id { get; set; }



    }
}
