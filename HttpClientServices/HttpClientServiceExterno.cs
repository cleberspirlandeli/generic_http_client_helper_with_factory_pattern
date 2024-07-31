//using System.Text.Json;

//namespace HttpClientServices;

//public class HttpClientServiceExterno : IHttpClientService
//{
//    private readonly HttpClient _httpClient;

//    public HttpClientServiceExterno(IHttpClientFactory httpClientFactory)
//    {
//        _httpClient = httpClientFactory.CreateClient("Teste");
//    }

//    public async Task<TResult> GetAsync<TResult>(string url, Dictionary<string, string> headers = null)
//        where TResult : ApiResult
//    {
//        AddHeaders(_httpClient, headers);
//        var apiResult = await _httpClient.GetAsync(url);

//        if (!apiResult.IsSuccessStatusCode)
//            return default;

//        var json = await apiResult.Content.ReadAsStringAsync();
//        var result = JsonSerializer.Deserialize<TResult>(json);
//        return result;
//    }

//    public async Task<TResult> PostAsync<TRequest, TResult>(string url, TRequest request, Dictionary<string, string> headers = null)
//        where TRequest : ApiRequest
//        where TResult : ApiResult
//    {
//        headers.Add("ContentType", "application/json");
//        AddHeaders(_httpClient, headers);

//        var httpContent = new StringContent(JsonSerializer.Serialize(request));
//        var apiResult = await _httpClient.PostAsync(url, httpContent);

//        if (!apiResult.IsSuccessStatusCode)
//            return default;

//        var json = await apiResult.Content.ReadAsStringAsync();
//        var result = JsonSerializer.Deserialize<TResult>(json);
//        return result;
//    }

//    private void AddHeaders(HttpClient httpClient, Dictionary<string, string> additionalHeaders)
//    {
//        httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

//        if (additionalHeaders == null)
//            return;

//        foreach (KeyValuePair<string, string> current in additionalHeaders)
//        {
//            httpClient.DefaultRequestHeaders.Add(current.Key, current.Value);
//        }
//    }
//}
