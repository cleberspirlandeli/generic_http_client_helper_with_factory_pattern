using Api.Test.Externo;
using Api.Test.Externo.Factory;
using Api.Test.Externo.InvestimentGeneral;

namespace Api.Test.Service.InvestimentGeneral;

public class InvestimentGeneralService : IInvestimentGeneralService
{
    //private readonly IHttpClientServiceTest _httpClientService;
    private readonly IInvestimentGeneralApiService _httpClientService;
    private readonly IHttpClientServiceFactory _httpClientServiceFactory;

    public InvestimentGeneralService(
        //IHttpClientServiceTest httpClientService,
        IInvestimentGeneralApiService httpClientService, 
        IHttpClientServiceFactory httpClientServiceFactory)
    {
        _httpClientService = httpClientService;
        _httpClientServiceFactory = httpClientServiceFactory;
    }

    public async Task<GetApiResult> ProcessAsync()
    {
        // Example GET
        var apiGetResult = await _httpClientService.GetAsync<GetApiResult>("");

        var investimentGeneralApi = _httpClientServiceFactory.Create(ApiLayoutEnum.InvestimentGeneral);
        var investimentGeneralApiResult = await investimentGeneralApi.GetAsync<GetApiResult>("");

        var userAccountApi = _httpClientServiceFactory.Create(ApiLayoutEnum.UserAccount);
        var userAccountApiResult = await userAccountApi.GetAsync<GetApiResult>("");




        // Example POST
        var request = new PostApiRequest("nome", 20);
        //var apiPostResult = await _httpClientService.PostAsync<PostApiRequest, GetApiResult>("https://viacep.com.br/ws/01001000/json/", request);

        return apiGetResult;
    }
}
