using MongoDB.Driver;
using Financial_Manager.Infrastructure.Models;
using Microsoft.Extensions.Options;
using meerkat;
using Financial_Manager.Models;
using Financial_Manager.Interfaces;
using System.Linq.Expressions;
using Financial_Manager.Attributes;
using Microsoft.AspNetCore.Routing;
using System.Reflection;

namespace Financial_Manager.Services
{
    public class MongoDBService<IDocument>:IDataBaseRepository<IDocument> 
    {
        private readonly IMongoCollection<IDocument > _collection;

        public MongoDBService(IOptions<MongoDbSettings> mongoDBSettings) {

            MongoClient client = new(mongoDBSettings.Value.ConnectionURI);
            var databse = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _collection = databse.GetCollection<IDocument>(GetCollectionName(typeof(IDocument)));

        }

        private string GetCollectionName(Type type)
        {
            var attribute = typeof(IDocument).GetCustomAttribute<BsonCollectionNameAttribute>();
            return attribute!.CollectionName;
        }

        public IQueryable<IDocument> AsQueryable()
        {
            return _collection.AsQueryable();
        }

        public async Task CreateAsync(IDocument document)
        {
            await _collection.InsertOneAsync(document);
            return;

          
        }

        public void DeleteById(string id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public void DeleteMany(Expression<Func<IDocument, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public Task DeleteManyAsync(Expression<Func<IDocument, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public void DeleteOne(Expression<Func<IDocument, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOneAsync(Expression<Func<IDocument, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDocument> FilterBy(Expression<Func<IDocument, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TProjected> FilterBy<TProjected>(Expression<Func<IDocument, bool>> filterExpression, Expression<Func<IDocument, TProjected>> projectionExpression)
        {
            throw new NotImplementedException();
        }

        public IDocument FindById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IDocument> FindByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public IDocument FindOne(Expression<Func<IDocument, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public Task<IDocument> FindOneAsync(Expression<Func<IDocument, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public void InsertMany(ICollection<IDocument> documents)
        {
            throw new NotImplementedException();
        }

        public Task InsertManyAsync(ICollection<IDocument> documents)
        {
            throw new NotImplementedException();
        }

        public void InsertOne(IDocument document)
        {
            throw new NotImplementedException();
        }

        public async Task InsertOneAsync(IDocument document)
        {
             await _collection.InsertOneAsync(document);
            return;
        }

        public void ReplaceOne(IDocument document)
        {
            throw new NotImplementedException();
        }

        public Task ReplaceOneAsync(IDocument document)
        {
            throw new NotImplementedException();
        }

        /*   public async Task<UserStockInfo> GetAsync()
           {
               await _userStockInfoCollection.f
           }*/

    }
}
