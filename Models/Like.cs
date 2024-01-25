using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveMyIssue.Models
{
    public class Like
    {
        private Guid _id;
        private string _userId;
        private string _issueId;
        private string? _solutionId;
        private string? _commentId;

        public Like(string userId, string issueId)
        {
            _id = Guid.NewGuid();
            _userId = userId;
            _issueId = issueId;
        }

        //public Like(string userId, string solutionId)
        //{
        //    _id = Guid.NewGuid();
        //    _userId = userId;
        //    _solutionId = solutionId;
        //}

        //public Like(string userId, string commentId)
        //{
        //    _id = Guid.NewGuid();
        //    _userId = userId;
        //    _commentId = commentId;
        //}

    }
}