using Financial_Manager.Infrastructure.Models;
using Financial_Manager.Interfaces;
using Financial_Manager.Services;
using Microsoft.AspNetCore.Mvc;

namespace Financial_Manager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserStockInfoController : ControllerBase
    {
        private readonly IDataBaseRepository<UserStockInfo> _mongoDBService;

        private readonly ILogger<UserStockInfoController> _logger;

        public UserStockInfoController(ILogger<UserStockInfoController> logger, IDataBaseRepository<UserStockInfo> mongoDBService)
        {
            _logger = logger;
            _mongoDBService = mongoDBService;
        }

        /*[HttpGet]
        public async Task<List<UserStockInfo>> GetStockInfo()
        {

        }
*/
        [HttpPost]
        public async Task<IActionResult> PostStockInfo([FromBody] UserStockInfo stockInfo)
        {
            await _mongoDBService.Crea(stockInfo);
            return CreatedAtAction(nameof(PostStockInfo), new
            {
                id = stockInfo.Id,
           
            },stockInfo);

        }

      /*  [HttpPut("{id}")]
        public async Task<UserStockInfo> editStockInfo(string id, [FromBody] string description)
        {

        }*/
    }
}