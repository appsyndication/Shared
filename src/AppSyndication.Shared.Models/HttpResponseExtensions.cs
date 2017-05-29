using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AppSyndication.Shared.Models
{
    public static class HttpResponseExtensions
    {
        public static async Task WriteJsonAsync(this HttpResponse response, object obj)
        {
            var json = Json.ToString(obj);

            await response.WriteJsonAsync(json);
        }

        public static async Task WriteJsonAsync(this HttpResponse response, string str)
        {
            response.ContentType = "application/json";

            await response.WriteAsync(str);
        }
    }
}
