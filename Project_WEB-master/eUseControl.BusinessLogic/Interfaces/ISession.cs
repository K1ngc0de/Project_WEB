using System.Web;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BussinesLogic.Interfaces
{
    public interface ISession
    {

        ULoginResp UserLogin(ULoginData data);
        ULoginResp UserSignUp(USignUpData data);
        HttpCookie GenCookie(string loginCredential);
        UserMinimal GetUserByCookie(string apiCookieValue);
    }
}
