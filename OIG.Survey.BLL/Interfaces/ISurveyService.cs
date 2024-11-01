using OIG.Survey.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIG.Survey.BLL.Interfaces
{
    public interface ISurveyService
    {
        Task<List<SurveySession>> GetSurveys();
        Task<List<SurveySession>> GetSurveysAssignedToUser(string userId);
        Task SubmitAnswer(UserAnswer userAnswer);
        Task<List<SurveySession>> GetSurveysByAssignedUserEmail(string email);
        Task<SurveySession> GetSurveyById(Guid id);
        Task CreateSurvey(SurveySession survey);
        Task<bool> UpdateSurvey(SurveySession survey);
        Task<bool> DeleteSurvey(Guid id);
    }
}
