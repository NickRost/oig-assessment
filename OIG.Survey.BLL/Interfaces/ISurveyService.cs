using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIG.Survey.BLL.Interfaces
{
    public interface ISurveyService
    {
        Task CreateSurvey();
        Task DeleteSurvey();
        Task UpdateSurvey();
        Task ScheduleSurvey();
        Task GetSurvey();
        Task GetSurveysList();
    }
}
