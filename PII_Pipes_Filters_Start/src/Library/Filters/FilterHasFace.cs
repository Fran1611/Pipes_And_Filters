using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CompAndDel;
using System.Diagnostics;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FilterHasFace : IFilter
    {
        public static bool hasface = false;
        public IPicture Filter(IPicture image)
        {
            CognitiveFace cog = new CognitiveFace("620e818a46524ceb92628cde08068242", true);
            cog.Recognize("..\\Program\\NewImage.jpg");
            if (cog.FaceFound)
            {
                hasface = true;
            }
            return image;
        }
    }
}