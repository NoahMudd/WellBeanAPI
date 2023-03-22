namespace WellBeanAPI.Models
{
    public class UserInputSurvey
    {
        public string? UserName { get; set; }

        public int MinutesExercised { get; set; }

        public int OzWater { get; set; }

        public int DietRating { get; set; }

        public int HoursSlept { get; set; }

        public bool DidYouWork { get; set; }

        public int WellbeingRating { get; set; }
    }
}
