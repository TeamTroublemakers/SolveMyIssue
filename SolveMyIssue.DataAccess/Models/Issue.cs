using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveMyIssue.DataAccess.Models
{
    public class Issue
    {
        [BsonId]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Category { get; set; }
        public DateTime Created { get; set; }

        //public List<string>? Comments = new List<string>();
        public string? Image {  get; set; }


    }
}