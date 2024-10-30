using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OIG.Survey.BLL.Interfaces;
using OIG.Survey.BLL.Services;
using OIG.Survey.DLL.Models;

namespace OIG.Survey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : Controller
    {
        private readonly SurveyService _surveyService;
        public SurveyController(SurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        // GET: api/Survey
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SurveySession>>> GetSurveys()
        {
            var surveys = await _surveyService.GetSurveys();
            return Ok(surveys);
        }

        // GET: api/Survey/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SurveySession>> GetSurvey(Guid id)
        {
            var survey = await _surveyService.GetSurveyById(id);
            if (survey == null)
            {
                return NotFound();
            }
            return Ok(survey);
        }

        // POST: api/Survey
        [HttpPost]
        public async Task<ActionResult<SurveySession>> CreateSurvey(SurveySession survey)
        {
            await _surveyService.CreateSurvey(survey);
            return CreatedAtAction(nameof(GetSurvey), new { id = survey.Id }, survey);
        }

        // PUT: api/Survey/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSurvey(Guid id, SurveySession survey)
        {
            if (id != survey.Id)
            {
                return BadRequest();
            }

            var result = await _surveyService.UpdateSurvey(survey);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/Survey/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSurvey(Guid id)
        {
            var result = await _surveyService.DeleteSurvey(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
