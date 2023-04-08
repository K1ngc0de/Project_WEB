using eUseControl.Web.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Web.Controllers;
using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            SessionStatus();
            if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] != "login")
            {
                return View(new DataRequest());
            }

            var user = System.Web.HttpContext.Current.GetMySessionObject();

            DataRequest data = new DataRequest()
            {
                UserName = user.Username,
                Level = user.Level,

            };

            return View(data);
        }
    }
}