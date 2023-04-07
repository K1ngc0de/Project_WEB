using eUseControl.BussinesLogic.Interfaces;
using System.Web;
using eUseControl.Domain.Entities.User;
using eUseControl.BussinesLogic.Core;

namespace eUseControl.BussinesLogic
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


        public ULoginResp UserSignUp(USignUpData data)
        {
            return UserRegisterAction(data);
        }

        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }
    }
}
