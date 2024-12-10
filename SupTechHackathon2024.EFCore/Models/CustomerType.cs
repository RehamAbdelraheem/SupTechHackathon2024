using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            CbeCustomers = new HashSet<CbeCustomer>();
        }

        public short Id { get; set; }
        public string NameAr { get; set; } = null!;
        public string NameEn { get; set; } = null!;

        public virtual ICollection<CbeCustomer> CbeCustomers { get; set; }
    }
}
