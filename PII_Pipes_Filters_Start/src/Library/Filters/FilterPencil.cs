using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Aplica el efecto de lápiz en una imagen
    /// </summary>
    public class FilterPencil : FilterBlurConvolution
    {

        public FilterPencil()
        {
            this.matrizParametros = new int[3, 3]{ { -2, 2, -2 }, { 2, 8, -2 }, { -2, -1, -3 } };
            this.complemento = 250;
            this.divisor = 1;
        }
    }
}