using System;
using System.Collections.Generic;

namespace GregshapUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool IsFullTime { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}