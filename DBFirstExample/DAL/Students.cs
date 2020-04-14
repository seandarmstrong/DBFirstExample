using System;
using System.Collections.Generic;

namespace DBFirstExample.DAL
{
    public partial class Students
    {
        public Students()
        {
            Enrollments = new HashSet<Enrollments>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GcidentificationNumbe { get; set; }
        public string DeclaredMajor { get; set; }

        public virtual ICollection<Enrollments> Enrollments { get; set; }
    }
}
