using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WellBeanAPI.Data;
using WellBeanAPI.Models;

namespace WellBeanAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WellBeanController : Controller
    {
        private readonly WellBeanAPIDbContext dbContext;

        public WellBeanController(WellBeanAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllSurveys()
        {
            return Ok(await dbContext.Surveys.ToListAsync());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetSurveyByUserName([FromRoute] Guid id)
        {
            var surveys = await dbContext.Surveys.FindAsync(id);

            if (surveys == null)
            {
                return NotFound();
            }
            
            return Ok(surveys);
        }

        [HttpPost]
        public async Task<IActionResult> AddSurvey(AddSurveyRequest addSurveyRequest)
        {
            var survey = new Survey()
            {
                Id = Guid.NewGuid(),
                SurveyDate = DateTime.Now,
                UserName = addSurveyRequest.UserName,
                MinutesExercised = addSurveyRequest.MinutesExercised,
                OzWater = addSurveyRequest.OzWater,
                DietRating = addSurveyRequest.DietRating,
                HoursSlept = addSurveyRequest.HoursSlept,
                DidYouWork = addSurveyRequest.DidYouWork,
                WellbeingRating = addSurveyRequest.WellbeingRating
            };
            
            await dbContext.Surveys.AddAsync(survey);
            await dbContext.SaveChangesAsync();

            return Ok(survey);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateSurvey([FromRoute] Guid id, UpdateSurveyRequest updateSurveyRequest)
        {
            var survey = await dbContext.Surveys.FindAsync(id);

            if (survey != null)
            {
                survey.UserName = updateSurveyRequest.UserName;
                survey.MinutesExercised = updateSurveyRequest.MinutesExercised;
                survey.OzWater = updateSurveyRequest.OzWater;
                survey.DietRating = updateSurveyRequest.DietRating;
                survey.HoursSlept = updateSurveyRequest.HoursSlept;
                survey.DidYouWork = updateSurveyRequest.DidYouWork;
                survey.WellbeingRating = updateSurveyRequest.WellbeingRating;

                await dbContext.SaveChangesAsync();
                return Ok(survey);
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteSurvey([FromRoute] Guid id)
        {
            var survey = await dbContext.Surveys.FindAsync(id);

            if (survey != null)
            {
                dbContext.Remove(survey);
                await dbContext.SaveChangesAsync();
                return Ok(survey);
            }

            return NotFound();
        }
    }
}
