using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kinoman.Entities.MultiKino.Cities;
using Kinoman.Enums;

namespace Kinoman.Services.Impl
{
    public class MultiKinoUrlProviderService : IUrlProviderService
    {
        private IDownloadService _downloadService;
        private IDeserializer _deserializer;
        private IEnumerable<Cinema> _cinemasListInfo;



        public MultiKinoUrlProviderService(IDownloadService downloadService,IDeserializer deserializer)
        {
            _downloadService = downloadService;
            _deserializer = deserializer;

            
        }
        public async Task<List<string>> GetUrl(Cities city)
        {
            List<string> urlList = new List<string>();
            var deserializedObject = await GetObject();
            var cityNames = deserializedObject.Venues.SelectMany(v => v.Cinemas)
                .Where(c => c.Name.Contains(city.ToString()));
            _cinemasListInfo = cityNames;
            foreach (var cityName in cityNames)
            {
                var url = UrlBuilder(cityName.Id);
                urlList.Add(url);
            }
            return urlList;
        }

        private async Task<MultiKinoCity> GetObject()
        {
            var stringCityData = await _downloadService.DownloadData("https://multikino.pl/data/locations/");
            var deserializerObject = _deserializer.Deserialize<MultiKinoCity>(stringCityData);
            return deserializerObject;
        }

        private string UrlBuilder(string cityStrId)
        {
            var url = "https://multikino.pl/data/filmswithshowings/" + cityStrId;
            return url;
        }

        public IEnumerable<Cinema> CinemasListInfo()
        {
            return _cinemasListInfo;
        }
    }
}