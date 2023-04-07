using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interfaces;
//using eUseControl.Domain.Etities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public HttpCookie GenCookie(string loginCredential)
        {
            return Cookie(loginCredential);
        }

        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }


        public ULoginResp UserRegister(URegisterData data)
        {
            return UserRegisterAction(data);
        }

        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }
    }
}
