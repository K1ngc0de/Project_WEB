﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace eUseControl.BusinessLogic.Interfaces
{
    public interface IGalerie
    {
        List<Image> GetGalerieData();
        void DeleteImage(int ImageID);
    }
}
