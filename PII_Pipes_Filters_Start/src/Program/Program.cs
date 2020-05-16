using System;
using CompAndDel.Filters;
using CompAndDel.Pipes;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture(@"download.jpg");

            PipeNull pipeNull = new PipeNull();

            FilterSaveImage filterSaveImage = new FilterSaveImage();
            PipeSerial pipeFilterSaveImage = new PipeSerial(filterSaveImage, pipeNull);

            FilterNegative filterNegative = new FilterNegative();
            PipeSerial pipeFilterNegative = new PipeSerial(filterNegative, pipeFilterSaveImage);
           
            FilterGreyscale filterGreyScale = new FilterGreyscale();
            PipeSerial pipeFilterGreyScale = new PipeSerial(filterGreyScale, pipeFilterNegative);
            pipeFilterGreyScale.Send(pic); 

            //Hecho hasta parte 2.

        }
    }
}
