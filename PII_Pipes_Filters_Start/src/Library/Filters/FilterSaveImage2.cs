using System;
using System.Collections.Generic;
using System.Text;
using CompAndDel;
using System.Drawing;
using System.Diagnostics;

namespace CompAndDel.Filters
{
    public class FilterSaveImage2 : IFilter
    {
        private int count=0;
        
        public IPicture Filter(IPicture image)
        {
            count++;
            IPicture savePicture = image.Clone();
            PictureProvider p = new PictureProvider();
            p.SavePicture(savePicture, $@"NewImage{count}.jpg");
            return savePicture;
        }
        
    }
}