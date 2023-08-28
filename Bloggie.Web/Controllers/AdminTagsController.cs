using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //go to the below method when submit the form 
        [HttpPost]
        [ActionName("Add")]
        public IActionResult SubmitTag()
        {
            //Two ways to submit and read data using Read incoming request approach

            //var name = Request.Form["name"]; //Form["name"] -> name is the name from Add.cshtml input name
            //var displayName = Request.Form["displayName"];
            return View("Add");
        }
    }
}
