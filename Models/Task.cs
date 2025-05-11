using System;
using System.Collections.Generic;

namespace TaskManagement_api.Models
{
    public partial class task
    {
        public task()
        {
            Users = new HashSet<User>();
        }

        public int TaskId { get; set; }
        public string TaskName { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
