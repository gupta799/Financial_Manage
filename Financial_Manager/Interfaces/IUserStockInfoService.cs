using Financial_Manager.Infrastructure.Models;
using System.Linq.Expressions;

namespace Financial_Manager.Interfaces
{
    public interface IUserStockInfoService
    {
        public Task<IDocument> getStockInfo(Expression<Func<UserStockInfo, bool>> filterExpression);

        public Task createStockInfo(UserStockInfo stockInfo);



    }
}
