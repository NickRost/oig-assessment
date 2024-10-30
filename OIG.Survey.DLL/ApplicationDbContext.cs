using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OIG.Survey.DLL.Models;

namespace OIG.Survey.DLL
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<SurveySession> SurveySessions { get; set; }
    }
}
