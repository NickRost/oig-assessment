using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIG.Survey.DLL.Models
{
    public class SurveyModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<string> Questions { get; set; }
    }
}
