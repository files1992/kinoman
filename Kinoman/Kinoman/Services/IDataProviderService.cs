using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Kinoman.Entities.MultiKino;
using Kinoman.Entities.MultiKino.Cities;
using Kinoman.Enums;

namespace Kinoman.Services
{
    public interface IDataProviderService
    {
        Task<List<T>> GetCurrentData<T>(Cities city);
        IEnumerable<Cinema> GetCityInfo();
    }
}