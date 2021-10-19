using Newtonsoft.Json;

namespace SSSoftware.TodaysTodos.MobileApp.Core
{
    public static class Extensions
    {
        /// <summary>
        /// Gets data from url and deserializes response json to provided type.
        /// </summary>
        /// <exception cref="HttpRequestException">Thrown if response did not have a success status code.</exception>
        /// <typeparam name="T">Type to deserialize to.</typeparam>
        /// <param name="httpClient">Http client.</param>
        /// <param name="url">URL to get data from.</param>
        /// <returns>Data deserialized to specified type.</returns>
        public static async Task<T> GetFromJsonAsync<T>(this HttpClient httpClient, string url)
        {
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
