using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Aplica el efecto de neon en una imagen 
    /// </summary>
    public class FilterNeon : FilterBlurConvolution
    {

        public FilterNeon()
        {
            this.matrizParametros = new int[3, 3]{ { -1, -2, -3 }, { 0, 4, 0 }, { -1, 0, -1 } };
            this.complemento = 300;
            this.divisor = 1;
        }
    }
}