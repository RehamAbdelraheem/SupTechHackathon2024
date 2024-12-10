using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class CustomerAddress
    {
        public long Id { get; set; }
        public string CbeCustomerId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Governorate { get; set; } = null!;
        public string City { get; set; } = null!;
        public short TypeId { get; set; }
        public string OtherDetails { get; set; } = null!;
        public string PostalCode { get; set; } = null!;

        public virtual CbeCustomer CbeCustomer { get; set; } = null!;
        public virtual AddressType Type { get; set; } = null!;
    }
}
