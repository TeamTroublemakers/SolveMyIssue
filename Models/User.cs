using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveMyIssue.Models
{
    public class User
    {
        private Guid _id;
        private string _name;
        private string _email;
        private string _password;
        private List<Issue> _issues;
        private List<Solution> _solutions;
        private List<Comment> _comments;
        private List<Like> _likes;

        public User(string name, string email, string password)
        {
            _id = Guid.NewGuid();
            _name = name;
            _email = email;
            _password = password;
            _issues = new List<Issue>();
            _solutions = new List<Solution>();
            _comments = new List<Comment>();
            _likes = new List<Like>();
        }
    }
}