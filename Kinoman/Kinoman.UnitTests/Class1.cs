using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kinoman.Entities.MultiKino;
using Kinoman.Enums;
using Kinoman.Services;
using Kinoman.Services.Impl;
using NUnit.Framework;

namespace Kinoman.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public async void sdasds()
        {
            IDownloadService download = new DownloadService();
            IDeserializer deserializer = new Deserializer();
            var city = Cities.Warszawa;
            IUrlProviderService urls = new MultiKinoUrlProviderService(download, deserializer, city);
            IDataProviderService data = new DataProviderService(download,deserializer,city,urls);
            var result = await data.GetCurrentData<MultiKinoShowing>();

        }
    }
}
