using EasyUIProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web.Script.Serialization;

namespace EasyUIProject.Controllers
{
    public class TestUIController : Controller
    {
        private readonly ILogger _logger;
        public TestUIController(ILogger<TestUIController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetUserTreeJson()
        {
            var _node = new EasyTreeData("1", "Root");          
            string json = ToJson(_node);
            _logger.LogWarning("--------------gamecc----");
            return Content(json);
        }
        //生成Json
        protected string ToJson(object obj)
        {
            string jsonData = (new JavaScriptSerializer()).Serialize(obj);
            return jsonData;
        }
    }
}