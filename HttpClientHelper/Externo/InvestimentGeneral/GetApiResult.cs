namespace Api.Test.Externo.InvestimentGeneral;

public record GetApiResult(string cep, string logradouro, string uf) : ApiResult;