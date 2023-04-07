using eUseControl.BusinessLogic.Interfaces;
using eUseControl.BusinessLogic.LoginBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic
{
    public class BusinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
        public IGalerie GetGalerieBL()
        {
            return new GalerieBL();
        }
    }
}
