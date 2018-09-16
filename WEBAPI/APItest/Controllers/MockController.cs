using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APItest.Controllers
{
    public class MockController : Controller
    {
        // GET: Mock
        public ActionResult MockGet()
        {
            return View();
        }
        public ActionResult MockGetNode()
        {
            return View();
        }
        public ActionResult GetNodeAPI()
        {
            return View();
        }
    }
}