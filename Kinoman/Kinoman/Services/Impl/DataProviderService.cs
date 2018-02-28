using System.Collections.Generic;
using System.Threading.Tasks;
using Kinoman.Entities.MultiKino;
using Kinoman.Enums;

namespace Kinoman.Services.Impl
{
    public class DataProviderService : IDataProviderService
    {
        private readonly IDeserializer _deserializer;
        private readonly IDownloadService _downloadService;
        private Cities _city;
        private IUrlProviderService _urlProviderService;

        public DataProviderService(IDownloadService downloadService, IDeserializer deserializer, Cities city,IUrlProviderService urlProviderService)
        {
            _deserializer = deserializer;
            _downloadService = downloadService;
            _city = city;
            _urlProviderService = urlProviderService;
        }
        public async Task<List<T>> GetCurrentData<T>()
        {
            List<T> deserializedObjestsList = new List<T>();
            var city = _city.ToString();
            var urlList = await GetUrlsList();
            foreach (var url in urlList)
            {
                var stringData = await _downloadService.DownloadData(url);
                var deserializedData = _deserializer.Deserialize<T>(stringData);
                deserializedObjestsList.Add(deserializedData);
            }
            return deserializedObjestsList;
        }

        public async Task<List<string>> GetUrlsList()
        {
            var urlList = await _urlProviderService.GetUrl(_city);
            return urlList;
        }
    }
}