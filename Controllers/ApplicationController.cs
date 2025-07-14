using System.Linq;
using System.Threading.Tasks;
using System.Web;
using HireLog.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;

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



        [HttpPost]
        [ActionName("Application")]
        public HttpResponseMessage PostApplication(Application application)
        {
            // TODO: add some more data validation
            if (ModelState.IsValid && application != null)
            {
                // var Id = Guid.NewGuid(); //according to microsoft with a readonly dictionary containing the jobs https://learn.microsoft.com/en-us/aspnet/web-api/overview/advanced/sending-html-form-data-part-1
                application.Id = Guid.NewGuid();

                var response = new HttpResponseMessage(System.Net.HttpStatusCode.Created)
                {
                    Content = new StringContent(application.Position)
                }; // 201 response

                return response;
            }
            else
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Bad input value. Please try again.")
                };
            }
        }
    }
}