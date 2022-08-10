using HttpClientSample.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientSample
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new Client("https://localhost:44388", new HttpClient());
            var data = await client.ProductsGETAsync(5);
        }
    }
}
