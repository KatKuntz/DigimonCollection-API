using DigimonCollection.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DigimonCollection.Controllers
{
    [ApiController]
    [Route("[Controller]")]
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
    }
}
