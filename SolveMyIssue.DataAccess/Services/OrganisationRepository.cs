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
	internal class OrganisationRepository : IOrganisationRepository
	{
		private readonly IMongoCollection<Organization> _organisationCollection;


		public OrganisationRepository()
        {
			var databaseName = "";
			var collectionName = "";

			var mongoClient = new MongoClient(Environment.GetEnvironmentVariable("CONNECTION_STRING"));
			var mongoDatabase = mongoClient.GetDatabase(databaseName);
			_organisationCollection = mongoDatabase.GetCollection<Organization>(collectionName);
		}
		public async Task AddAsync(Organization entity)
		{
			await _organisationCollection.InsertOneAsync(entity);
		}

		public async Task DeleteAsync(string id)
		{
			await _organisationCollection.DeleteOneAsync(x => x.Id == id);
		}

		public async Task<IEnumerable<Organization>> GetAllAsync()
		{
			return await _organisationCollection.Find(x => true).ToListAsync();
		}

		public async Task<Organization> GetByIdAsync(string id)
		{
			return await _organisationCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
		}

		public async Task UpdateAsync(Organization entity)
		{
			await _organisationCollection.ReplaceOneAsync(x => x.Id == entity.Id, entity);
		}
	}
}
