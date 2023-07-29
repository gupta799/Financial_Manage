using Financial_Manager.Infrastructure.Models;
using Financial_Manager.Interfaces;
using System.Linq.Expressions;

namespace Financial_Manager.Services
{
    public class userStockInfoService : IUserStockInfoService
    {

        private readonly IDataBaseRepository<UserStockInfo> _mongoDBService;

        public userStockInfoService(IDataBaseRepository<UserStockInfo> mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        public async Task createStockInfo(UserStockInfo stockInfo)
        {
            await _mongoDBService.InsertOneAsync(stockInfo);
         /*   return CreatedAtAction(nameof(PostStockInfo), new
            {
                id = stockInfo.Id,

            }, stockInfo);*/
        }

        public Task<IDocument> getStockInfo(Expression<Func<UserStockInfo, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }
    }
}
