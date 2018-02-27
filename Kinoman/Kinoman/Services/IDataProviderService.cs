using System.Threading.Tasks;
using Kinoman.Entities.MultiKino;

namespace Kinoman.Services
{
    public interface IDataProviderService
    {
        Task<T> GetCurrentData<T>();
    }
}