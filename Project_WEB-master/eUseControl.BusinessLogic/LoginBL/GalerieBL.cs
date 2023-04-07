using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace eUseControl.BusinessLogic.LoginBL
{
    public class GalerieBL : UserApi, IGalerie
    {
        public List<Image> GetGalerieData()
        {
            return GetGalerieDataApi();
        }

        public void DeleteImage(int ImageId)
        {
            DeleteImageAction(ImageId);
        }
    }
}
