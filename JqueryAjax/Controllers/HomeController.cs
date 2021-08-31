using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryAjax.Controllers
{
    public class HomeController : Controller
    {
        private List<string> listData = new List<string>() { "apple", "samsung", "xiaomi", "huawei", "asus" };

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetData()
        {
            System.Threading.Thread.Sleep(1000); //To delay data withdrawal

            return PartialView("_DataItemPartial", listData);
        }
    }
}