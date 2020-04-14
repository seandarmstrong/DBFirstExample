using System;
using System.Collections.Generic;

namespace DBFirstExample.DAL
{
    public partial class InstructorCourse
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Instructors Instructor { get; set; }
    }
}
