using OIG.Survey.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIG.Survey.DLL.Models
{
    public class SurveySession
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SurveyStatus Status { get; set; }
        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }
        public string? AssignedUserId { get; set; }
        public ApplicationUser AssignedUser { get; set; }
        public List<SurveyQuestion> Questions { get; set; } = new();
        public List<UserAnswer> UserAnswers { get; set; } = new();
    }
}

public class UserAnswer
{
    public Guid Id { get; set; }
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public Guid SurveySessionId { get; set; }
    public SurveySession SurveySession { get; set; }
    public Guid SurveyQuestionId { get; set; }
    public SurveyQuestion SurveyQuestion { get; set; }
    public string? Answer { get; set; }
}

public class SurveyQuestion
{
    public Guid Id { get; set; }
    public string QuestionText { get; set; }
}
