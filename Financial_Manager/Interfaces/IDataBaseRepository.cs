using System.Linq.Expressions;

namespace Financial_Manager.Interfaces
{
    public interface IDataBaseRepository<IDocument> 
    {
        IQueryable<IDocument> AsQueryable();

        IEnumerable<IDocument> FilterBy(
            Expression<Func<IDocument, bool>> filterExpression);

        IEnumerable<TProjected> FilterBy<TProjected>(
            Expression<Func<IDocument, bool>> filterExpression,
            Expression<Func<IDocument, TProjected>> projectionExpression);

        IDocument FindOne(Expression<Func<IDocument, bool>> filterExpression);

        Task<IDocument> FindOneAsync(Expression<Func<IDocument, bool>> filterExpression);

        IDocument FindById(string id);

        Task<IDocument> FindByIdAsync(string id);

        void InsertOne(IDocument document);

        Task InsertOneAsync(IDocument document);

        void InsertMany(ICollection<IDocument> documents);

        Task InsertManyAsync(ICollection<IDocument> documents);

        void ReplaceOne(IDocument document);

        Task ReplaceOneAsync(IDocument document);

        void DeleteOne(Expression<Func<IDocument, bool>> filterExpression);

        Task DeleteOneAsync(Expression<Func<IDocument, bool>> filterExpression);

        void DeleteById(string id);

        Task DeleteByIdAsync(string id);

        void DeleteMany(Expression<Func<IDocument, bool>> filterExpression);

        Task DeleteManyAsync(Expression<Func<IDocument, bool>> filterExpression);
    }
}
