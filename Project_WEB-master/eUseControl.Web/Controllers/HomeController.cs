using eUseControl.BusinessLogic.Service;
using eUseControl.Controllers;
using eUseControl.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace eUseControl.Web
{
	public class HomeController : BaseController
	{
		public ActionResult Index()
		{
			using(var postsService = new Forum())
			{
				var postsResp = postsService.GetAll();
                if (!postsResp.Success)
                    return HttpNoPermission();

                var vm = new HomePageView
                {
                    Posts = postsResp.Entry
                };

				return View(vm);
            }
		}
	}
}