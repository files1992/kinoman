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
        private IUrlProviderService _urlProviderService;

        public DataProviderService(IDownloadService downloadService, IDeserializer deserializer, IUrlProviderService urlProviderService)
        {
            _deserializer = deserializer;
            _downloadService = downloadService;
            _urlProviderService = urlProviderService;
        }
        public async Task<List<T>> GetCurrentData<T>(Cities city)
        {
            List<T> deserializedObjestsList = new List<T>();
            var urlList = await GetUrlsList(city);
            foreach (var url in urlList)
            {
                var stringData = await _downloadService.DownloadData(url);
                var deserializedData = _deserializer.Deserialize<T>(stringData);
                deserializedObjestsList.Add(deserializedData);
            }
            return deserializedObjestsList;
        }

        public async Task<List<string>> GetUrlsList(Cities city)
        {
            var urlList = await _urlProviderService.GetUrl(Cities.Gdynia);
            return urlList;
        }
    }
}