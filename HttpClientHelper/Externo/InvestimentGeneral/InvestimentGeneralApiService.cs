using Api.Test.Externo.Base;

namespace Api.Test.Externo.InvestimentGeneral;

public class InvestimentGeneralApiService : BaseHttpClientService, IInvestimentGeneralApiService
{
    public InvestimentGeneralApiService(IHttpClientFactory httpClientFactory) 
        : base(httpClientFactory.CreateClient("EndpointExampleOne"))
    {
    }

    /*
    public async Task<TResult> GetAsync<TResult>(string url, Dictionary<string, string> headers = null)
        where TResult : ApiResult
    {
        AddHeaders(_httpClient, headers);
        var apiResult = await _httpClient.GetAsync(url);

        if (!apiResult.IsSuccessStatusCode)
            return default;

        var json = await apiResult.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<TResult>(json);
        return result;
    }

    public async Task<TResult> PostAsync<TBodyRequest, TResult>(string url, TBodyRequest bodyRequest, Dictionary<string, string> headers = null)
        where TBodyRequest : ApiRequest
        where TResult : ApiResult
    {
        headers.Add("ContentType", "application/json");
        AddHeaders(_httpClient, headers);

        var httpContent = new StringContent(JsonSerializer.Serialize(bodyRequest));
        var apiResult = await _httpClient.PostAsync(url, httpContent);

        if (!apiResult.IsSuccessStatusCode)
            return default;

        var json = await apiResult.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<TResult>(json);
        return result;
    }

    private void AddHeaders(HttpClient httpClient, Dictionary<string, string> additionalHeaders)
    {
        httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

        if (additionalHeaders == null)
            return;

        foreach (KeyValuePair<string, string> current in additionalHeaders)
        {
            httpClient.DefaultRequestHeaders.Add(current.Key, current.Value);
        }
    }
    */
}
