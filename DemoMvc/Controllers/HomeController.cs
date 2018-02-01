using System.Web.Mvc;

namespace DemoMvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            // ViewData.Values.IsReadOnly.Equals()=new List<digit>();
            return View();
        }

        [HttpPost]
        public string DeIndex(string idigit)
        {
            return View();
        }
    }
}