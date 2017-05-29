using Newtonsoft.Json;

namespace AppSyndication.Shared.Models
{
    public static class Json
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            DefaultValueHandling = DefaultValueHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore
        };

        public static T ToObject<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str, Settings);
        }

        public static string ToString(object obj)
        {
            return JsonConvert.SerializeObject(obj, Settings);
        }
    }
}
