using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using npiypAPI.Models;

namespace npiypAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RawDataController : ControllerBase
    {
        private readonly RawDataContext _context;

        //Display items
        public RawDataController(RawDataContext context)
        {
            _context = context;

            if (_context.RawDataItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                //_context.RawDataItems.Add(new RawData { Name = "Item1" });
                //_context.SaveChanges();

            }
        }
    
        [HttpGet]
        public ActionResult<List<RawData>> GetAll()
        {
            return _context.RawDataItems.ToList();
        }

        [HttpGet("{TestId}", Name = "GetRawData")]
        public ActionResult<RawData> GetById(long TestId)
        {
            var item = _context.RawDataItems.Find(TestId);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public IActionResult Create(RawData item)
        {
            _context.RawDataItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetRawData", new { TestId = item.TestId }, item);
        }
    }
}