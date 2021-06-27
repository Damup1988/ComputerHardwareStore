using System.Collections;
using ComputerHardwareStore.BusinessLogic;
using ComputerHardwareStore.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ComputerHardwareStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _service;

        public SupplierController(ISupplierService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public ActionResult<Supplier> GetAllItems()
        {
            return Ok(_service.GetAllSuppliers());
        }
    }
}