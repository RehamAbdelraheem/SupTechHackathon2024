using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class CustomerRiskRateYearlyHistory
    {
        public string CbecustomerId { get; set; } = null!;
        public int BankId { get; set; }
        public short Rate { get; set; }
        public short Year { get; set; }

        public virtual Bank Bank { get; set; } = null!;
        public virtual Cbecustomer Cbecustomer { get; set; } = null!;
    }
}
