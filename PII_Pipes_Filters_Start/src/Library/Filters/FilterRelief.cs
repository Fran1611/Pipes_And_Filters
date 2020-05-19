using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Aplica el efecto de relieve en una imagen
    /// </summary>
    public class FilterRelief : FilterBlurConvolution
    {

        public FilterRelief()
        {
            this.matrizParametros = new int[3, 3]{ { -1, 0, -1 }, { 0, 4, 0 }, { -1, 0, -1 } };
            this.complemento = 150;
            this.divisor = 1;
        }
    }
}