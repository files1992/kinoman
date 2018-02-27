using System.Net.Http;
using System.Threading.Tasks;
using Kinoman.Entities.MultiKino;

namespace Kinoman.Services.Impl
{
    public class DownloadService : IDownloadService
    {
        public async Task<string> DownloadData(string url)
        {
            var httpClient = new HttpClient();
            var dataTask = await httpClient.GetStringAsync(url);
            return dataTask;
        }
    }
}