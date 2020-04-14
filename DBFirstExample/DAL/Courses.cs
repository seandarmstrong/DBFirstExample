using System;
using System.Collections.Generic;

namespace DBFirstExample.DAL
{
    public partial class Courses
    {
        public Courses()
        {
            Enrollments = new HashSet<Enrollments>();
            InstructorCourse = new HashSet<InstructorCourse>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public int LocationId { get; set; }

        public virtual Locations Location { get; set; }
        public virtual ICollection<Enrollments> Enrollments { get; set; }
        public virtual ICollection<InstructorCourse> InstructorCourse { get; set; }
    }
}
