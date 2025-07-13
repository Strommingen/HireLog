using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HireLog.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "TEMP";
        }
        [HttpGet("{ID}")]
        public string GetByID(int ID)
        {
            return "TEMP";
        }
    }
}