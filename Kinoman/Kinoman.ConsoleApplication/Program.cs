using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kinoman.Entities.MultiKino;
using Kinoman.Enums;
using Kinoman.Services;
using Kinoman.Services.Impl;
using Unity;

namespace Kinoman.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            var city = Cities.Warszawa;
            container.RegisterType<IDownloadService, DownloadService>();
            container.RegisterType<IDeserializer, Deserializer>();
            container.RegisterType<IUrlProviderService, MultiKinoUrlProviderService>();
            container.RegisterType<IDataProviderService,DataProviderService>();
            container.RegisterType<ICommonDataService, MultiKinoToCommonDataService>();


            //var dataProviderService = container.Resolve<IDataProviderService>();

            //var result = dataProviderService.GetCurrentData<MultiKinoShowing>(city).Result;

            
            var commonTypeShowing = container.Resolve<ICommonDataService>();

            var result = commonTypeShowing.GetCommonData(city).Result;

        }
    }
}
