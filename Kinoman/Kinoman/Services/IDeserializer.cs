using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Services
{
    public interface IDeserializer
    {
        T Deserialize<T>(string data);
    }
}
