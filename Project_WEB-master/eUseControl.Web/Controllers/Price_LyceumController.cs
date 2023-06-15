using eUseControl.BusinessLogic.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Controllers
{
    public class Price_LyceumController : BaseController
    {
        // GET: Price_Lyceum
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