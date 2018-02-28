using System.Collections.Generic;
using System.Threading.Tasks;
using Kinoman.Enums;

namespace Kinoman.Services
{
    public interface IUrlProviderService
    {
        List<string> GetUrl();
    }
}