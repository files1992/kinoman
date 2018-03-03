using System.Collections.Generic;
using System.Threading.Tasks;
using Kinoman.Entities.Common;
using Kinoman.Enums;

namespace Kinoman.Services
{
    public interface ICommonDataService
    {
        Task<List<Showing>> GetCommonData(Cities city);

    }
}