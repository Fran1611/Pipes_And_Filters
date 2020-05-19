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


            

            pic = p.GetPicture(@"Imagen2.jpg");

            //Filtro FilterBlackAndWhite
            PipeNull pipeNull = new PipeNull();
            FilterSaveImage2 filterSaveImage2 = new FilterSaveImage2();
            PipeSerial pipeFilterSaveImage2 = new PipeSerial(filterSaveImage2, pipeNull);

            FilterBlackAndWhite filterBAndW = new FilterBlackAndWhite(20);
            PipeSerial pipeFilterBAndW = new PipeSerial(filterBAndW, pipeFilterSaveImage2);
         
            pipeFilterBAndW.Send(pic.Clone());

            //Filtro FilterClearOut
            pipeNull = new PipeNull();
            pipeFilterSaveImage2 = new PipeSerial(filterSaveImage2, pipeNull);

            FilterClearOut filterClearOut = new FilterClearOut();
            PipeSerial pipeFilterClearOut = new PipeSerial(filterClearOut, pipeFilterSaveImage2);
         
            pipeFilterClearOut.Send(pic.Clone());

            //Filtro FilterColoredLines
            pipeNull = new PipeNull();
            pipeFilterSaveImage2 = new PipeSerial(filterSaveImage2, pipeNull);

            FilterColoredLines filterColoredLines = new FilterColoredLines();
            PipeSerial pipeFilterColoredLines = new PipeSerial(filterColoredLines, pipeFilterSaveImage2);
         
            pipeFilterColoredLines.Send(pic.Clone());

            
            //Filtro FilterDarken
            pipeNull = new PipeNull();
            pipeFilterSaveImage2 = new PipeSerial(filterSaveImage2, pipeNull);

            FilterDarken filterDarken = new FilterDarken();
            PipeSerial pipeFilterDarken = new PipeSerial(filterDarken, pipeFilterSaveImage2);
         
            pipeFilterDarken.Send(pic.Clone());

            //Filtro FilterNeon
            pipeNull = new PipeNull();
            pipeFilterSaveImage2 = new PipeSerial(filterSaveImage2, pipeNull);

            FilterNeon filterNeon = new FilterNeon();
            PipeSerial pipeFilterNeon = new PipeSerial(filterNeon, pipeFilterSaveImage2);
         
            pipeFilterNeon.Send(pic.Clone());

            //Filtro FilterPencil
            pipeNull = new PipeNull();
            pipeFilterSaveImage2 = new PipeSerial(filterSaveImage2, pipeNull);

            FilterPencil filterPencil = new FilterPencil();
            PipeSerial pipeFilterPencil = new PipeSerial(filterPencil, pipeFilterSaveImage2);
         
            pipeFilterPencil.Send(pic.Clone());

            //Filtro FilterRelief
            pipeNull = new PipeNull();
            pipeFilterSaveImage2 = new PipeSerial(filterSaveImage2, pipeNull);

            FilterRelief filterRelief = new FilterRelief();
            PipeSerial pipeFilterRelief = new PipeSerial(filterRelief, pipeFilterSaveImage2);
         
            pipeFilterRelief.Send(pic.Clone());


            //Filtro FilterGreyScale
            pipeNull = new PipeNull();
            pipeFilterSaveImage2 = new PipeSerial(filterSaveImage2, pipeNull);

            FilterGreyscale filterGreyScale = new FilterGreyscale();
            PipeSerial pipeFilterGreyscale = new PipeSerial(filterGreyScale, pipeFilterSaveImage2);
         
            pipeFilterGreyscale.Send(pic.Clone());

            
            //Filtro BlurConvolution
            pipeNull = new PipeNull();
            pipeFilterSaveImage2 = new PipeSerial(filterSaveImage2, pipeNull);

            FilterBlurConvolution filterBlurConvolution = new FilterBlurConvolution();
            PipeSerial pipeFilterBlurConvolution = new PipeSerial(filterBlurConvolution, pipeFilterSaveImage2);
         
            pipeFilterBlurConvolution.Send(pic.Clone());

        }
    }
}
