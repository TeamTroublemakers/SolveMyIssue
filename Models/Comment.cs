using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveMyIssue.Models
{
    public class Comment
    {
        private Guid _id;
        private User _user;
        private Issue _issue;
        private Solution? _solution;
        private string _text;
        private List<Like> _likes;

        public Comment(User user, Issue issue, string text)
        {
            _id = Guid.NewGuid();
            _user = user;
            _issue = issue;
            _text = text;
            _likes = new List<Like>();
        }

        public Comment(User user, Solution solution, string text)
        {
            _id = Guid.NewGuid();
            _user = user;
            _solution = solution;
            _text = text;
            _likes = new List<Like>();
        }
    }
}