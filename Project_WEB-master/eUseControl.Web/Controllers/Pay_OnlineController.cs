using eUseControl.BusinessLogic.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Controllers
{
    public class Pay_OnlineController : BaseController
    {
        // GET: Pay_Online
        public ActionResult Index()
        {
            using (var postsService = new Forum())
            {
                var postsResp = postsService.GetAll();
                if (!postsResp.Success)
                    return HttpNoPermission();
                return View();
            }
        }
    }
}