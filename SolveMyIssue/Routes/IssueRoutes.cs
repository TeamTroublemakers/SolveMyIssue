using SolveMyIssue.DataAccess.Models;
using SolveMyIssue.DataAccess.Services.Interfaces;
using System.Runtime.CompilerServices;

namespace SolveMyIssue.Routes
{
    public static class IssueRoutes
    {
        public static void MapIssueEndpoints(this WebApplication app)
        {
            app.MapGet("issues", async (IIssueRepository issueRepository) =>
            {
                return await issueRepository.GetAllAsync();
            });

            app.MapPost("issue", async (IIssueRepository issueRepository, Issue newIssue) =>
            {
                await issueRepository.AddAsync(newIssue);
            });
        }
    }
}
