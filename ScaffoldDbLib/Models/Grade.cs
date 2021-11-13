using System;
using System.Collections.Generic;

#nullable disable

namespace ScaffoldDbLib.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Users = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public string GradeName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
