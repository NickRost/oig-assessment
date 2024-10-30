using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIG.Survey.DLL.Models
{
    public class SurveySession
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SurveyStatus Status { get; set; }
        public Guid OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }
    }
}
