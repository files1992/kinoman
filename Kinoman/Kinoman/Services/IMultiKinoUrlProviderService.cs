using System.Collections.Generic;
using System.Threading.Tasks;
using Kinoman.Enums;

namespace Kinoman.Services
{
    public interface IMultiKinoUrlProviderService
    {
        Task<List<string>> GetUrl(Cities city);
    }
}