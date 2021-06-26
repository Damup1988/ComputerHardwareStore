using System;
using ComputerHardwareStore.BusinessLogic;
using ComputerHardwareStore.Domain;
using Microsoft.AspNetCore.JsonPatch;
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
        [HttpGet("{id}", Name = "GetItemById")]
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
            return CreatedAtRoute(nameof(GetItemById), new {item.Id}, item);
            //return Ok(item);
        }
        
        /// <summary>
        /// UPDATE
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult UpdateItem(Item item)
        {
            if (_itemService.UpdateItem(item)) return NoContent();
            else return NotFound();
        }

        [HttpPatch("{id}")]
        public ActionResult PartialUpdateItem(Guid id, JsonPatchDocument<Item> patchDoc)
        {
            var itemFromDb = _itemService.GetItemById(id);
            if (itemFromDb == null) return NotFound();
            
            patchDoc.ApplyTo(itemFromDb, ModelState);
            if (!TryValidateModel(itemFromDb)) return ValidationProblem(ModelState);
            _itemService.UpdateItem(itemFromDb);
            return NoContent();
        }
        
        /// <summary>
        /// DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteItem(Guid id)
        {
            if (_itemService.DeleteItem(id)) return NoContent();
            else return NotFound();
        }
    }
}