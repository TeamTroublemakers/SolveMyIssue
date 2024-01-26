using MongoDB.Driver;
using SolveMyIssue.Common.Interfaces;
using SolveMyIssue.DataAccess.Models;
using SolveMyIssue.DataAccess.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveMyIssue.DataAccess.Services
{
	internal class SolutionRepository : ISolutionRepository
	{
		private readonly IMongoCollection<Solution> _solutionCollection;

		public SolutionRepository(IMongoClient client)
		{
			var databaseName = "SolveMyIssue";
			var collectionName = "Solutions";

			var db = client.GetDatabase(databaseName);
			_solutionCollection = db.GetCollection<Solution>(collectionName);
		}


		public async Task AddAsync(Solution entity)
		{
			await _solutionCollection.InsertOneAsync(entity);
		}

		public async Task DeleteAsync(string id)
		{
			await _solutionCollection.DeleteOneAsync(x => x.Id == id);
		}

		public async Task<IEnumerable<Solution>> GetAllAsync()
		{
			return await _solutionCollection.Find(x => true).ToListAsync();
		}

		public async Task<Solution> GetByIdAsync(string id)
		{
			return await _solutionCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
		}

		public async Task UpdateAsync(Solution entity)
		{
			await _solutionCollection.ReplaceOneAsync(x => x.Id == entity.Id, entity);
		}

		Task IRepository<Solution>.UpdateAsync(Solution entity)
		{
			throw new NotImplementedException();
		}
	}
}
