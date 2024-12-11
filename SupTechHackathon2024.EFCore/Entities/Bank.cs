using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class Bank
    {
        public Bank()
        {
            BankBranches = new HashSet<BankBranch>();
            Calls = new HashSet<Call>();
            CustomerRiskRateYearlyHistories = new HashSet<CustomerRiskRateYearlyHistory>();
            RetailAnnualIncomes = new HashSet<RetailAnnualIncome>();
            SmeYearlyFinancialStatements = new HashSet<SmeYearlyFinancialStatement>();
        }

        public int Id { get; set; }
        public string NameAr { get; set; } = null!;
        public string NameEn { get; set; } = null!;

        public virtual ICollection<BankBranch> BankBranches { get; set; }
        public virtual ICollection<Call> Calls { get; set; }
        public virtual ICollection<CustomerRiskRateYearlyHistory> CustomerRiskRateYearlyHistories { get; set; }
        public virtual ICollection<RetailAnnualIncome> RetailAnnualIncomes { get; set; }
        public virtual ICollection<SmeYearlyFinancialStatement> SmeYearlyFinancialStatements { get; set; }
    }
}
