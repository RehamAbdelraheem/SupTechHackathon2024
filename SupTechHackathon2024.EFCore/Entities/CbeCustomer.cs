using SupTechHackathon2024.Common;
using System;
using System.Collections.Generic;

namespace SupTechHackathon2024.EFCore.Models
{
    public partial class CbeCustomer : EntityBase
    {
        public CbeCustomer()
        {
            Calls = new HashSet<Call>();
            CustomerAddresses = new HashSet<CustomerAddress>();
            CustomerCreditBureauReportingYearlyHistories = new HashSet<CustomerCreditBureauReportingYearlyHistory>();
            CustomerRiskRateYearlyHistories = new HashSet<CustomerRiskRateYearlyHistory>();
            RetailAnnualIncomes = new HashSet<RetailAnnualIncome>();
            SmeYearlyFinancialStatements = new HashSet<SmeYearlyFinancialStatement>();
        }

        public string Id { get; set; } = null!;
        public short CustomerTypeId { get; set; }
        public int? PersonId { get; set; }
        public int? SmeId { get; set; }
        public short? LatestCreditBureauScore { get; set; }
        public DateTime LatestCreditBureauReportingDate { get; set; }

        public virtual CustomerType CustomerType { get; set; } = null!;
        public virtual Person? Person { get; set; }
        public virtual Sme? Sme { get; set; }
        public virtual ICollection<Call> Calls { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<CustomerCreditBureauReportingYearlyHistory> CustomerCreditBureauReportingYearlyHistories { get; set; }
        public virtual ICollection<CustomerRiskRateYearlyHistory> CustomerRiskRateYearlyHistories { get; set; }
        public virtual ICollection<RetailAnnualIncome> RetailAnnualIncomes { get; set; }
        public virtual ICollection<SmeYearlyFinancialStatement> SmeYearlyFinancialStatements { get; set; }
    }
}
