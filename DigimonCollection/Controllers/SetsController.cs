using DigimonCollection.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DigimonCollection.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SetsController : ControllerBase
    {
        private readonly DigimonContext context;

        public SetsController(DigimonContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IQueryable<Set>> GetSets()
        {
            return Ok(context.Sets);
        }

        [HttpGet("{id}")]
        public ActionResult<Set> GetSetById(int id)
        {
            Set set = context.Sets.Find(id);
            if (set == null)
            {
                return NotFound();
            }
            return Ok(set);
        }
    }
}
