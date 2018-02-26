using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Kinoman.Services.Impl
{
    public class Deserializer : IDeserializer
    {
        public T Deserialize<T>(string data)
        {
            var deserializedObject = JsonConvert.DeserializeObject<T>(data);
            return deserializedObject;
        }
    }
}
