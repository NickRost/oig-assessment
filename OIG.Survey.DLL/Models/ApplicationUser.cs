using Microsoft.AspNetCore.Identity;

namespace OIG.Survey.DLL.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<SurveySession> OwnedSurveys { get; set; } = new();
        public List<SurveySession> AssignedSurveys { get; set; } = new();
    }

}
