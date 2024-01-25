using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveMyIssue.DataAccess.Models
{
    public class User
    {
		public string Id { get; set; }
		
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private List<string> IssueIds { get; set; }
        private List<string> SolutionIds { get; set; }
        private List<string> CommentIds { get; set; }
        private List<string> LikeIds { get; set; }
        private List<string> OrganizationIds { get; set; }

        public User(string id,string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            IssueIds = new List<string>();
            SolutionIds = new List<string>();
            CommentIds = new List<string>();
            LikeIds = new List<string>();
        }

		public User(string name, string email, string password)
		{
			Name = name;
			Email = email;
			Password = password;
		}
	}
}