using System.Collections.Generic;
using System.Threading.Tasks;
using Kinoman.Enums;

namespace Kinoman.Services
{
    public interface IUrlProviderService
    {
        Task<List<string>> GetUrl();
    }
}