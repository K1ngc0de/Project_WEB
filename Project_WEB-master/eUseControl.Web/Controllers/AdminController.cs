using eUseControl.BusinessLogic.Service;
using eUseControl.Controllers;
using eUseControl.Domain.Entities;
using eUseControl.Filters;
using System.Web.Mvc;

namespace eUseControl.Controllers
{
    public class AdminController : BaseController
    {
        [RequireUserRole(UserRole.Admin)]
        public ActionResult Index()
        {
            return View();
        }

        #region Users
        [RequireUserRole(UserRole.Admin)]
        public ActionResult Users()
        {
            using (var userService = new UserService())
            {
                var prodResp = userService.GetAll();
                if (!prodResp.Success)
                    return HttpNoPermission();

                var prod = prodResp.Entry;
                return View(prod);
            }
        }

        [RequireUserRole(UserRole.Admin)]
        public ActionResult EditUser(int? id)
        {
            if (id == null)
                return HttpNotFound();

            using (var userService = new UserService())
            {
                var prodResp = userService.Get(id.Value);
                if (!prodResp.Success)
                    return HttpNoPermission();

                var prod = prodResp.Entry;
                if (prod == null)
                    return HttpNotFound();

                return View(prod);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [RequireUserRole(UserRole.Admin)]
        public ActionResult EditUser(User user)
        {
            if (ModelState.IsValid)
            {
                using (var userService = new UserService())
                {
                    var editResp = userService.AddOrUpdate(user);
                    if (!editResp.Success)
                        return HttpNoPermission();
                }
            }

            return View(user);
        }

        [RequireUserRole(UserRole.Admin)]
        public ActionResult DeleteUser(int? id)
        {
            if (id == null)
                return HttpNotFound();

            using (var userService = new UserService())
            {
                var prodResp = userService.Get(id.Value);
                if (!prodResp.Success)
                    return HttpNoPermission();

                var post = prodResp.Entry;
                if (post == null)
                    return HttpNotFound();

                return View(post);
            }

        }

    
       
        #endregion
    }
}