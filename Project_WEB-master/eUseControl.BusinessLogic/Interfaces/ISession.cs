﻿using eUseControl.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace eUseControl.BusinessLogic.Interfaces
{
    public interface ISession
    {

        ULoginResp UserLogin(ULoginData data);
        ULoginResp UserRegister(URegisterData data);
        HttpCookie GenCookie(string loginCredential);
        UserMinimal GetUserByCookie(string apiCookieValue);
    }
}
