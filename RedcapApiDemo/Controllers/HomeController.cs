using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Redcap;
using Redcap.Models;
namespace RedcapApiDemo.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var redcapApi = new RedcapApi("3D57A7FA57C8A43F6C8803A84BB3957B", "http://localhost/redcap/api/");
            var delimiters = new char[] { ',', ' ' };
            var records = await redcapApi.GetRecordsAsync(RedcapFormat.json, ReturnFormat.json, RedcapDataType.flat, delimiters);
            return Json(records);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
