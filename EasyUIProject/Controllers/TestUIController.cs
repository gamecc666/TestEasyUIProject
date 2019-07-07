using EasyUIProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyUIProject.Controllers
{
    public class TestUIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EastUIGetData()
        {
            var _node = new NodeModel();
            _node.id = 1;
            _node.text = "root1";


            return Json(_node);
        }
    }
}