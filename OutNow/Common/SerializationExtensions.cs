using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace OutNow.Common
{
    public static class SerializationExtensions
    {
        public static string ToJson<T>(this T obj) where T : class, new()
        {
            var ser = new DataContractJsonSerializer(typeof(T));
            var result = String.Empty;

            using (var ms = new MemoryStream())
            {
                ser.WriteObject(ms, obj);

                var array = ms.ToArray();
                result = Encoding.UTF8.GetString(array, 0, array.Length);
            }
            return (result);
        }

        public static T FromJsonString<T>(this string jsonString)
        {
            using (var mem = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
                return (mem.FromJsonStream<T>());
        }

        public static T FromJsonStream<T>(this Stream jsonStream)
        {
            var c = new DataContractJsonSerializer(typeof(T));
            var parsedObject = c.ReadObject(jsonStream);
            return ((T)parsedObject);
        }

    }
}
