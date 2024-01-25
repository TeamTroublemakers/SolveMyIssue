using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveMyIssue.DataAccess.Models
{
    public class OrganizationUser : User
    {
        private string _organizationId;

        public OrganizationUser(string name, string email, string password, string organizationId) : base(name, email, password)
        {
            _organizationId = organizationId;
        }

    }
}