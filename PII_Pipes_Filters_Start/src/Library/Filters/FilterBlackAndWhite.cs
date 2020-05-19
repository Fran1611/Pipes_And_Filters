using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CompAndDel.Filters
{
    /// <summary>
    /// Transforma una imagen a blanco y negro cambiando un color a negro si se supera un límite pasado por
    /// parámetro o dejándole en blanco en caso contrario
    /// </summary>
    public class FilterBlackAndWhite : IFilter
    {

        private IPicture image;
        private int limit;

        public FilterBlackAndWhite(int limit)
        {
            this.limit = limit;
        }

        public IPicture Filter(IPicture image)
        {
            
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {

                    Color color = image.GetColor(i, j);

                    if (Math.Min(color.R,Math.Min(color.G,color.B))>limit)
                    {
                        image.SetColor(i, j, Color.FromArgb(255,255,255));
                    }
                    else
                    {
                        image.SetColor(i, j, Color.FromArgb(0, 0, 0));
                    }
                }
            }

            return image;
        }
    }
}
