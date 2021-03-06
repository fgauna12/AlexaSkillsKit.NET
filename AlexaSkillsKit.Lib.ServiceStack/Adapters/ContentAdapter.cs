﻿using System.Text;
using System.Threading.Tasks;
using AlexaSkillsKit.Speechlet.Abstractions;
using ServiceStack.Web;

namespace AlexaSkillsKit.Lib.ServiceStack.Adapters
{
    public class ContentAdapter :IHttpContent
    {
        private readonly IRequest _httpRequest;

        public ContentAdapter(IRequest httpRequest)
        {
            _httpRequest = httpRequest;
        }

        public Task<byte[]> ReadAsByteArrayAsync()
        {
            return Task.FromResult(Encoding.UTF8.GetBytes(_httpRequest.GetRawBody())); //todo test
        }
    }
}