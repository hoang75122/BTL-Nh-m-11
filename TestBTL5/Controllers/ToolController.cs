using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core;
namespace TestBTL5.Controllers
{
    public class ToolController : Controller
    {
        // GET: Tool
        public ActionResult CreateDatabase()
        {
            using (var de = new DataEntities())
            {
                return View();
            }
            
        }
    }
}