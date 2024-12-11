using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class Sme
    {
        public Sme()
        {
            CbeCustomers = new HashSet<CbeCustomer>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string TaxIdNumber { get; set; } = null!;
        public string BusinessRegisterIdNumber { get; set; } = null!;
        public int LegalRepresentativePersonId { get; set; }
        public string IndustrySector { get; set; } = null!;

        public virtual Person LegalRepresentativePerson { get; set; } = null!;
        public virtual ICollection<CbeCustomer> CbeCustomers { get; set; }
    }
}
