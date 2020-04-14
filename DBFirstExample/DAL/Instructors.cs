using System;
using System.Collections.Generic;

namespace DBFirstExample.DAL
{
    public partial class Instructors
    {
        public Instructors()
        {
            InstructorCourse = new HashSet<InstructorCourse>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GcidentificationNumbe { get; set; }
        public string OfficeNumber { get; set; }

        public virtual ICollection<InstructorCourse> InstructorCourse { get; set; }
    }
}
