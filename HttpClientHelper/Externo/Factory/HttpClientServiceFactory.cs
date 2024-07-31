using Api.Test.Externo.Base;
using Api.Test.Externo.InvestimentGeneral;

namespace Api.Test.Externo.Factory;

public class HttpClientServiceFactory : IHttpClientServiceFactory
{
    private readonly IInvestimentGeneralApiService _investimentGeneralApiService;

    public HttpClientServiceFactory(IInvestimentGeneralApiService investimentGeneralApiService)
    {
        _investimentGeneralApiService = investimentGeneralApiService;
    }

    public IBaseHttpClientService Create(ApiLayoutEnum layout)
    {
        return layout switch 
        {
            ApiLayoutEnum.InvestimentGeneral => _investimentGeneralApiService,
            ApiLayoutEnum.UserAccount => _investimentGeneralApiService,
            _ => throw new NotImplementedException()
        };
    }
}
