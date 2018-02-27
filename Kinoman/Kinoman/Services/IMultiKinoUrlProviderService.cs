using System.Collections.Generic;
using Kinoman.Enums;

namespace Kinoman.Services
{
    public interface IMultiKinoUrlProviderService
    {
        List<string> GetUrl(Cities city);
    }
}