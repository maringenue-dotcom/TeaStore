using Microsoft.AspNetCore.Mvc;
using TeaStoreApi.Context;
using TeaStoreApi.Models;

namespace TeaStoreApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TeasController : ControllerBase
    {
        private dbcontext db;
        public TeasController(dbcontext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IEnumerable<Teas> GetTea()
        {
            return db.Teas;
        }

    }
}
