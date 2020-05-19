using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Aplica el efecto aclarar en una imagen
    /// </summary>
    public class FilterClearOut : FilterBlurConvolution
    {

        public FilterClearOut()
        {
            this.matrizParametros = new int[3, 3]{ { -1,0,-1 }, { -1, 10, -1 }, { 0, 0, 0 } };
            this.complemento = 130;
            this.divisor = 12;
        }
    }
}