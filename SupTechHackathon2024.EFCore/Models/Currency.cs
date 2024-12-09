using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class Currency
    {
        public Currency()
        {
            RetailAnnualIncomes = new HashSet<RetailAnnualIncome>();
            SmeYearlyFinancialStatements = new HashSet<SmeYearlyFinancialStatement>();
        }

        public short Id { get; set; }
        public string NameAr { get; set; } = null!;
        public string NameEn { get; set; } = null!;

        public virtual ICollection<RetailAnnualIncome> RetailAnnualIncomes { get; set; }
        public virtual ICollection<SmeYearlyFinancialStatement> SmeYearlyFinancialStatements { get; set; }
    }
}
