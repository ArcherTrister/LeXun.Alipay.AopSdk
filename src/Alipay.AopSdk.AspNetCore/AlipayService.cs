using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Util;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Alipay.AopSdk.AspNetCore
{
    public class AlipayService : IAlipayService
    {
        public AlipayOptions Options { get; set; }

        //private readonly HttpContext _context;

        private readonly IAopClient _aopClient;
        public AlipayService(IOptions<AlipayOptions> alipayOptions)
        {
            Options = alipayOptions.Value;
            //_context = contextAccessor.HttpContext; ,IHttpContextAccessor contextAccessor
            _aopClient = new DefaultAopClient(Options.Gatewayurl, Options.AppId, Options.PrivateKey, "json", "1.0",
                Options.SignType, Options.AlipayPublicKey, Options.CharSet, Options.IsKeyFromFile);
        }
        public T Execute<T>(IAopRequest<T> request) where T : AopResponse
        {
            return _aopClient.Execute(request);
        }

        public async Task<T> ExecuteAsync<T>(IAopRequest<T> request) where T : AopResponse
        {
            return await _aopClient.ExecuteAsync(request);
        }

        public T Execute<T>(IAopRequest<T> request, string session) where T : AopResponse
        {
            return _aopClient.Execute(request, session);
        }


        public async Task<T> ExecuteAsync<T>(IAopRequest<T> request, string session) where T : AopResponse
        {
            return await _aopClient.ExecuteAsync(request, session);
        }

        public T Execute<T>(IAopRequest<T> request, string session, string appAuthToken) where T : AopResponse
        {
            return _aopClient.Execute(request, session, appAuthToken);
        }

        public async Task<T> ExecuteAsync<T>(IAopRequest<T> request, string session, string appAuthToken) where T : AopResponse
        {
            return await _aopClient.ExecuteAsync(request, session, appAuthToken);
        }

        public T PageExecute<T>(IAopRequest<T> request) where T : AopResponse
        {
            return _aopClient.PageExecute(request);
        }

        public async Task<T> PageExecuteAsync<T>(IAopRequest<T> request) where T : AopResponse
        {
            return await _aopClient.PageExecuteAsync(request);
        }

        public T PageExecute<T>(IAopRequest<T> request, string session, string reqMethod) where T : AopResponse
        {
            return _aopClient.PageExecute(request, session, reqMethod);
        }

        public async Task<T> PageExecuteAsync<T>(IAopRequest<T> request, string session, string reqMethod) where T : AopResponse
        {
            return await _aopClient.PageExecuteAsync(request, session, reqMethod);
        }

        public T SdkExecute<T>(IAopRequest<T> request) where T : AopResponse
        {
            return _aopClient.SdkExecute(request);
        }

        //public Task<T> SdkExecuteAsync<T>(IAopRequest<T> request) where T : AopResponse
        //{
        //    throw new NotImplementedException();
        //}

        public bool RSACheckV1(Dictionary<string, string> data)
        {
            return AlipaySignature.RSACheckV1(data, Options.AlipayPublicKey, Options.CharSet, Options.SignType, false);
        }

    }
}