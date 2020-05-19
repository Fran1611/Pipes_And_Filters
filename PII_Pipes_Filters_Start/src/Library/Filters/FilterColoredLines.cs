using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Aplica el efecto de línea de colores en una imagen
    /// </summary>
    public class FilterColoredLines : FilterBlurConvolution
    {

        public FilterColoredLines()
        {
            this.matrizParametros = new int[3, 3]{ { 0, -1, 0 }, { 0, -5, 0 }, { 3, 0, 0 } };
            this.complemento = 100;
            this.divisor = 1;
        }
    }
}