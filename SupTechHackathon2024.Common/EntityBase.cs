 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupTechHackathon2024.Common
{
    public class EntityBase
    {
        public DateTime CreateDate { get; set; }

        public int CreateBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }

        public EntityStatus Status { get; set; }

    }
}
