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
        private readonly IUserStockInfoService _userStockInfoService;

        private readonly ILogger<UserStockInfoController> _logger;

        public UserStockInfoController(ILogger<UserStockInfoController> logger, IUserStockInfoService userStockInfoService)
        {
            _logger = logger;
            _userStockInfoService = userStockInfoService;
        }

        /*[HttpGet]
        public async Task<List<UserStockInfo>> GetStockInfo()
        {

        }
*/
        [HttpPost]
        public async Task<IActionResult> PostStockInfo([FromBody] UserStockInfo stockInfo)
        {
            await _userStockInfoService.createStockInfo(stockInfo);
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