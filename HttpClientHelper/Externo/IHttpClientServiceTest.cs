﻿using Api.Test.Externo.Base;

namespace Api.Test.Externo;

public interface IHttpClientServiceTest : IBaseHttpClientService
{
    //Task<TResult> GetAsync<TResult>(string url, Dictionary<string, string> headers = null) 
    //    where TResult : ApiResult;

    //Task<TResult> PostAsync<TBodyRequest, TResult>(string url, TBodyRequest bodyRequest, Dictionary<string, string> headers = null) 
    //    where TBodyRequest : ApiRequest
    //    where TResult : ApiResult;
}