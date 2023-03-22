namespace WellBeanAPI.Models
{
    public class Survey : UserInputSurvey
    {
        public Guid Id { get; set; }

        public DateTime SurveyDate { get; set; }
        
    }
}
