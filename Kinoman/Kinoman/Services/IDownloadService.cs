using System.Threading.Tasks;

namespace Kinoman.Services
{
    public interface IDownloadService
    {
        Task<string> DownloadData(string url);
    }
}