using MongoDB.Driver;
using SolveMyIssue.DataAccess.Models;
using SolveMyIssue.DataAccess.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveMyIssue.DataAccess.Services
{
	internal class IssueRepository : IIssueRepository
	{
		private readonly IMongoCollection<Issue> _issueCollection;
		public IssueRepository()
		{
			
			var databaseName = "";
			var collectionName = "";

			var mongoClient = new MongoClient(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
			var mongoDatabase = mongoClient.GetDatabase(databaseName);
			_issueCollection = mongoDatabase.GetCollection<Issue>(collectionName);


		}

		public async Task AddAsync(Issue entity)
		{
			await _issueCollection.InsertOneAsync(entity);
		}

		public async Task DeleteAsync(string id)
		{
			await _issueCollection.DeleteOneAsync(x => x.Id == id);
		}

		public async Task<IEnumerable<Issue>> GetAllAsync()
		{
			return await _issueCollection.Find(x => true).ToListAsync();
		}

		public async Task<Issue> GetByIdAsync(string id)
		{
			return await _issueCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
		}

		public async Task UpdateAsync(Issue entity)
		{
			await _issueCollection.ReplaceOneAsync(x => x.Id == entity.Id, entity);
		}
	}
}
