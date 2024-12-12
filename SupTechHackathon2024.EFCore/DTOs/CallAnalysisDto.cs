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

        public Guid id { get; set; }
        public bool isMisSellingDetected { get; set; }
        public string misSellingCategory { get; set; }
        public string product { get; set; }
    }
}
