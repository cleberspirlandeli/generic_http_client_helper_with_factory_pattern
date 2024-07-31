using Api.Test.Externo.Base;

namespace Api.Test.Externo.Factory;

public interface IHttpClientServiceFactory
{
    IBaseHttpClientService Create(ApiLayoutEnum layout);
}
