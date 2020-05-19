using System;
using CompAndDel.Filters;
using CompAndDel.Pipes;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Se obtiene la imagen.
            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture(@"download.jpg");
            
            // Se crean los filtros que se van a utilizar.
            FilterGreyscale filterGreyscale = new FilterGreyscale();
            FilterNegative filterNegative = new FilterNegative();
            FilterSaveImage filterSaveImage = new FilterSaveImage();
            FilterTwitterApi filterTwitterApi =  new FilterTwitterApi();
            FilterHasFace filterHasFace = new FilterHasFace();
            

            // Parte 1
            /*
            PipeNull pipeNull = new PipeNull();
            PipeSerial pipeFilterNegative = new PipeSerial(filterNegative, pipeNull);
            PipeSerial pipeFilterGreyScale = new PipeSerial(filterGreyscale, pipeFilterNegative);
            pipeFilterGreyScale.Send(pic);*/


             // Parte 2
            /*
            PipeNull pipeNull = new PipeNull();
            PipeSerial pipeFilterSaveImageTwo = new PipeSerial(filterSaveImage, pipeNull);
            PipeSerial pipeFilterNegative = new PipeSerial(filterNegative, pipeFilterSaveImageTwo);
            PipeSerial pipeFilterSaveImageOne = new PipeSerial(filterSaveImage, pipeFilterNegative);
            PipeSerial pipeFilterGreyScale = new PipeSerial(filterGreyscale, pipeFilterSaveImageOne);
            pipeFilterGreyScale.Send(pic);*/

            // Parte 3
            /*
            PipeNull pipeNull = new PipeNull();
            PipeSerial pipeTwitterApiTwo = new PipeSerial(filterTwitterApi, pipeNull);
            PipeSerial pipeFilterSaveImageTwo = new PipeSerial(filterSaveImage, pipeTwitterApiTwo);
            PipeSerial pipeFilterNegative = new PipeSerial(filterNegative, pipeFilterSaveImageTwo);
            PipeSerial pipeTwitterApi = new PipeSerial(filterTwitterApi, pipeFilterNegative);
            PipeSerial pipeFilterSaveImageOne = new PipeSerial(filterSaveImage, pipeTwitterApi);
            PipeSerial pipeFilterGreyScale = new PipeSerial(filterGreyscale, pipeFilterSaveImageOne);
            pipeFilterGreyScale.Send(pic);*/


            // Parte 4.
            /*
            PipeNull pipeNull = new PipeNull();
            PipeSerial pipeFilterSaveImageTwo = new PipeSerial(filterSaveImage, pipeNull);
            PipeSerial pipeFilterNegative = new PipeSerial(filterNegative, pipeFilterSaveImageTwo);
            PipeSerial pipeTwitterApi = new PipeSerial(filterTwitterApi, pipeNull);
            PipeFork pipeConditionalFork = new PipeFork(pipeFilterNegative, pipeTwitterApi);
            PipeSerial pipeFilterHasFace = new PipeSerial(filterHasFace, pipeConditionalFork);
            PipeSerial pipeFilterSaveImageOne = new PipeSerial(filterSaveImage, pipeFilterHasFace);
            PipeSerial pipeFilterGreyScale = new PipeSerial(filterGreyscale, pipeFilterSaveImageOne);
            pipeFilterGreyScale.Send(pic);*/

        }
    }
}
