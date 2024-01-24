using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveMyIssue.Models
{
    public class OrganizationUser : User
    {
        private Organization _organization;

        public OrganizationUser(string name, string email, string password, Organization organization) : base(name, email, password)
        {
            _organization = organization;
        }

    }
}