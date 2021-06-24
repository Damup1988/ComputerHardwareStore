using ComputerHardwareStore.BusinessLogic;
using ComputerHardwareStore.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ComputerHardwareStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }
        
        [HttpGet]
        public ActionResult<Item> GetAllItems()
        {
            return Ok(_itemService.GetAllItems());
        }
    }
}