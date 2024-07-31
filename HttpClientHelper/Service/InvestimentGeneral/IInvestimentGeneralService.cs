using Api.Test.Externo.InvestimentGeneral;

namespace Api.Test.Service.InvestimentGeneral;

public interface IInvestimentGeneralService
{
    Task<GetApiResult> ProcessAsync();
}
