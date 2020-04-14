using System;
using System.Collections.Generic;

namespace DBFirstExample.DAL
{
    public partial class Locations
    {
        public Locations()
        {
            Courses = new HashSet<Courses>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
    }
}
