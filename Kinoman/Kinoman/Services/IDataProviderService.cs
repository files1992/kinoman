using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Kinoman.Entities.MultiKino;

namespace Kinoman.Services
{
    public interface IDataProviderService
    {
        Task<List<T>> GetCurrentData<T>();
    }
}