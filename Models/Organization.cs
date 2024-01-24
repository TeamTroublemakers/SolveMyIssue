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
        private List<string> _adminIds;
        private List<string> _memberIds;
        private List<string> _issueIds;

        public Organization(string name, string email)
        {
            _id = Guid.NewGuid();
            _name = name;
            _email = email;
            _adminIds = new List<string>();
            _memberIds = new List<string>();
            _issueIds = new List<string>();
        }
    }
}