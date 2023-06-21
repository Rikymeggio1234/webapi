using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        [Route("helloworld/")]
        [HttpGet]
        public string HelloWorld()
        {
            return "Hello world";
        }
    }
}