using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveMyIssue.Models
{
    public class Comment
    {
        private Guid _id;
        private string _userId;
        private string _issueId;
        private string? _solutionId;
        private string _text;
        private List<string> _likeIds;

        public Comment(string userId, string issueId, string text)
        {
            _id = Guid.NewGuid();
            _userId = userId;
            _issueId = issueId;
            _text = text;
            _likeIds = new List<string>();
        }

        //public Comment(string userId, string solutionId, string text)
        //{
        //    _id = Guid.NewGuid();
        //    _userId = userId;
        //    _solutionId = solutionId;
        //    _text = text;
        //    _likeIds = new List<string>();
        //}
    }
}