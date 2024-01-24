using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveMyIssue.Models
{
    public class Like
    {
        private Guid _id;
        private User _user;
        private Issue _issue;
        private Solution? _solution;
        private Comment? _comment;

        public Like(User user, Issue issue)
        {
            _id = Guid.NewGuid();
            _user = user;
            _issue = issue;
        }

        public Like(User user, Solution solution)
        {
            _id = Guid.NewGuid();
            _user = user;
            _solution = solution;
        }

        public Like(User user, Comment comment)
        {
            _id = Guid.NewGuid();
            _user = user;
            _comment = comment;
        }

    }
}