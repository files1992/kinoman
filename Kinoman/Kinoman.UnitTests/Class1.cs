using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kinoman.Entities.MultiKino;
using Kinoman.Enums;
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
            var download = new DownloadService();
            var deserializer = new Deserializer();
            var city = Cities.Warszawa;
            var urls = new MultiKinoUrlProviderService(download, deserializer, city);
            var data = new DataProviderService(download,deserializer,city,urls);
            var result = await data.GetCurrentData<MultiKinoShowing>();

        }
    }
}
