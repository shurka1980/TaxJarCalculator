using System.Net.Http;
using System.Net.Http.Headers;

namespace TaxCalculator.Service
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; private set; }

        public void InitializeHttpClient()
        {
            InitializeClient();
        }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();

            //TODO: all hardcoded values should be moved to the appsettings.json config file.
            
            ApiClient.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // TODO: this needs to be stored in some secure key vault storage
            var accessToken = "5da2f821eee4035db4771edab942a4cc";

            ApiClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
            ApiClient.DefaultRequestHeaders.Add("x-api-version", "2020-08-07");
        }
    }
}