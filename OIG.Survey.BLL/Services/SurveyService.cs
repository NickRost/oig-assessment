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
            return await _surveyContext.SurveySessions.ToListAsync();
        }

        public async Task<SurveySession> GetSurveyById(Guid id)
        {
            return await _surveyContext.SurveySessions.FindAsync(id);
        }

        public async Task CreateSurvey(SurveySession survey)
        {
            _surveyContext.SurveySessions.Add(survey);
            await _surveyContext.SaveChangesAsync();
        }

        public async Task<bool> UpdateSurvey(SurveySession survey)
        {
            _surveyContext.Entry(survey).State = EntityState.Modified;
            try
            {
                await _surveyContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurveyExists(survey.Id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<bool> DeleteSurvey(Guid id)
        {
            var survey = await _surveyContext.SurveySessions.FindAsync(id);
            if (survey == null)
            {
                return false;
            }

            _surveyContext.SurveySessions.Remove(survey);
            await _surveyContext.SaveChangesAsync();
            return true;
        }

        private bool SurveyExists(Guid id)
        {
            return _surveyContext.SurveySessions.Any(e => e.Id == id);
        }
    }
}
