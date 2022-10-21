using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using Microsoft.AspNetCore.SystemWebAdapters;

namespace SystemWeb_Framework.Controllers
{
    public class SomeController : Controller
    {
        // GET: Some
        public ActionResult Index()
        {
            var c1 = new Class1();
            var checkResult = c1.PerformSomeCheck(System.Web.HttpContext.Current);
            Console.WriteLine(checkResult);
            return View();
        }
    }
}