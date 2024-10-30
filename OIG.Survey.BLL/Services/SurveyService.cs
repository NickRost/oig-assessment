using Microsoft.EntityFrameworkCore;
using OIG.Survey.DLL;
using OIG.Survey.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIG.Survey.BLL.Services
{
    public class SurveyService
    {
        private readonly ApplicationDbContext _surveyContext;

        public SurveyService(ApplicationDbContext surveyContext)
        {
            _surveyContext = surveyContext;
        }

        public async Task<List<SurveySession>> GetSurveys()
        {
            var surveysList = _surveyContext.SurveySessions.ToListAsync();

            return null;
        }
    }
}
