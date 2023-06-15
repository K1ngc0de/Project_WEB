using eUseControl.BusinessLogic.Service;
using eUseControl.Controllers;
using eUseControl.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace eUseControl.Web
{
    public class AllController : BaseController
    {
        // GET: All
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