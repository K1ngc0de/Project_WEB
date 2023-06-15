using eUseControl.BusinessLogic.Service;
using eUseControl.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Controllers
{
        // GET: Login
        public class LoginController : BaseController
        {
            // GET /Auth/Login
            public ActionResult Login()
            {
                return View();
            }

            // POST /Auth/Login
            [HttpPost]
            public ActionResult Login(LoginForm form)
            {
                if (ModelState.IsValid)
                {
                    var data = new AuthService.LoginData()
                    {
                        Email = form.Email,
                        Password = form.Password,
                        IpAddress = Request.UserHostAddress,
                        Time = DateTime.Now
                    };

                    var accountService = new AuthService();
                    var loginResp = accountService.Login(data);
                    if (loginResp.Success)
                    {
                        var session = loginResp.Entry;

                        // Create Cookie.
                        var cookie = new HttpCookie(SESSION_COOKIE_NAME, session.Token);
                        cookie.Expires = DateTime.Now.AddDays(1);
                        Response.Cookies.Add(cookie);

                        return Redirect("/");
                    }

                    ModelState.AddModelError("Password", loginResp.Message);
                }

                return View(form);
            }
        }
}