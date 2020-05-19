using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CompAndDel;
using System.Diagnostics;
using CompAndDel.Filters;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FilterCondicionalFace : IFilter
    {
        /// <summary>
        /// Recibe una imagen y la retorna con un filtro de relive aplicado si es un rostro y de blanco y negro en caso contrario
        /// </summary>
        /// <param name="image">Imagen a la que se le va a aplicar el filtro.</param>
        /// <returns>Imagen con el filtro aplicado.</returns>
        
        private string fileName;
        private FilterRelief filterRelief;
        private FilterBlackAndWhite filterBW;

        public FilterCondicionalFace(string fileName){
            this.fileName=fileName;
        }

        public IPicture Filter(IPicture image)
        {
            CognitiveFace cog = new  CognitiveFace("620e818a46524ceb92628cde08068242", false);
            cog.Recognize($@"{fileName}");

            if(cog.FaceFound){
                this.filterRelief = new FilterRelief();
                return this.filterRelief.Filter(image);
            }else{

                this.filterBW = new FilterBlackAndWhite(35);
                return this.filterBW.Filter(image);
            }
        }
    }
}
