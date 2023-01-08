using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InvoiceDemo.Models;
namespace InvoiceDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly BitProSoftTechContext _dbContext;
        public ItemController(BitProSoftTechContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult GetItems()
        {
            List<InvoicItem> list = _dbContext.InvoicItems.ToList();
            return StatusCode(StatusCodes.Status200OK, list);
        }
    }




}
