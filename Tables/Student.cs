using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Test.Tables
{
   public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SchoolYear { get; set; }
        public double TotalGrade { get; set; }

        public virtual School School { get; set; }

        [ForeignKey("School")]
        public int SchoolId { get; set; }


    }
}
