using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class BankBranch
    {
        public BankBranch()
        {
            Calls = new HashSet<Call>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int BankId { get; set; }

        public virtual Bank Bank { get; set; } = null!;
        public virtual ICollection<Call> Calls { get; set; }
    }
}
