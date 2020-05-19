using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Aplica el efecto de oscurecer en una imagen
    /// </summary>
    public class FilterDarken : FilterBlurConvolution
    {

        public FilterDarken()
        {
            this.matrizParametros = new int[3, 3]{ { -1,0,-1 }, { -1, 10, -1 }, { -1, -1, -1 } };
            this.complemento = 3;
            this.divisor = 8;
        }
    }
}