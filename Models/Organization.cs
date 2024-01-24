using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveMyIssue.Models
{
    public class Organization
    {
        private Guid _id;
        private string _name;
        private string _email;
        private List<User> _admins;
        private List<User> _members;
        private List<Issue> _issues;

        public Organization(string name, string email)
        {
            _id = Guid.NewGuid();
            _name = name;
            _email = email;
            _admins = new List<User>();
            _members = new List<User>();
            _issues = new List<Issue>();
        }
    }
}