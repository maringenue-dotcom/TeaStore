using Microsoft.AspNetCore.Mvc;
using TeaStoreApi.Context;
using TeaStoreApi.Models;

namespace TeaStoreApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthenticationController : ControllerBase
    {
        private dbcontext db;
        public AuthenticationController(dbcontext db)
        {
            this.db = db;
        }

        [HttpPost]
        public async Task<IActionResult> PostCreateNewUser(string login, string pass)
        {
            try
            {
                db.Users.Add(new Users(login, pass));
                db.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCheckUserName(string name)
        {
            try
            {
                if (db.Users.Where(n=>n.Login==name).Count() == 0)
                    return Ok();
                else
                    return Ok(name);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
