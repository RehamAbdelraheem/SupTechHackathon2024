using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class AddressType
    {
        public AddressType()
        {
            CustomerAddresses = new HashSet<CustomerAddress>();
        }

        public short Id { get; set; }
        public string NameAr { get; set; } = null!;
        public string NameEn { get; set; } = null!;

        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
    }
}
