using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class RetailAnnualIncome
    {
        public string CbecustomerId { get; set; } = null!;
        public int BankId { get; set; }
        public short Year { get; set; }
        public decimal Amount { get; set; }
        public short CurrencyId { get; set; }

        public virtual Bank Bank { get; set; } = null!;
        public virtual Cbecustomer Cbecustomer { get; set; } = null!;
        public virtual Currency Currency { get; set; } = null!;
    }
}
