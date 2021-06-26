using System;
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
        
        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<Item> GetAllItems()
        {
            return Ok(_itemService.GetAllItems());
        }
        
        /// <summary>
        /// GET by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<Item> GetItemById(Guid id)
        {
            var item = _itemService.GetItemById(id);
            return item != null ? Ok(item) : NotFound();
        }
        
        /// <summary>
        /// CREATE
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<Item> CreateItem(Item item)
        {
            _itemService.CreateItem(item);
            return Ok(item);
        }
        
        /// <summary>
        /// DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(Guid id)
        {
            var item = _itemService.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                _itemService.DeleteItem(id);
                return NoContent();
            }
        }
    }
}