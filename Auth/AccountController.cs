using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        [Route("redirect")]
        [HttpGet]
        public ActionResult Redirect()
        {
            return Ok("success");
        }
    }
}
