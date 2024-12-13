using SupTechHackathon2024.EFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupTechHackathon2024.EFCore.DTOs
{
    public class CallAnalysisDto
    {

        public Guid Id { get; set; }
        public bool IsMisSellingDetected { get; set; }
        public string? MisSellingCategory { get; set; }
        public string ProductName { get; set; }
    }
}
