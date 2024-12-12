using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupTechHackathon2024.EFCore.DTOs
{
    public class CustomerYearFinancialReportDto
    {
        public string CbeCustomerId { get; set; }
        public short CurrencyId { get; set; }
        //person
        public decimal AnnualIncomeAmount { get; set; }
        public short Rate { get; set; }
        //sme
        public DateTime ReportingDate { get; set; }
        public decimal TotalAssets { get; set; }
        public decimal TotalLiabilities { get; set; }
        public decimal TotalEquity { get; set; }
        public decimal Profit { get; set; }
        public decimal Revenue { get; set; }


    }
}
