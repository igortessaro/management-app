using System.Collections.Generic;

namespace Management.Domain.Entity
{
    public class UserRole : BaseEntity
    {
        public string Name { get; set; }

        public bool IsAdmin { get; set; }

        public IList<UserSys> UserSysList { get; set; }
    }
}
