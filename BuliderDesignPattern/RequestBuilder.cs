using BuliderDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class RequestBuilder
    {
        private readonly Request _request = new Request();

        public RequestBuilder(string url)
        {
            _request.Url = url;
        }

        public static RequestBuilder Request(string url)
        {
            return new RequestBuilder(url);
        }

        public RequestBuilder WithHeader(string name, string value)
        {
            _request.QueryString??= new();
            _request.QueryString[name] = value;
            return this;
        }

        public RequestBuilderWithForm AddFormRequest()
        {
            return new RequestBuilderWithForm(_request);
        }
        public RequestBuilderWithBody AddBodyRequest()
        {
            return new RequestBuilderWithBody(_request);
        }
    }

    public class RequestBuilderWithForm
    {
        private readonly Request _request;
        public RequestBuilderWithForm(Request request)
        {
            _request = request;
        }

        public RequestBuilderWithForm WithForm(object form)
        {
            _request.Form = form;
            return this;
        }

        public Request Build()
        {
            return _request;
        }
    }

    public class RequestBuilderWithBody
    {
        private readonly Request _request;
        public RequestBuilderWithBody(Request request)
        {
            _request = request;
        }

        public RequestBuilderWithBody WithBody(object body)
        {
            _request.Body = body;
            return this;
        }

        public Request Build()
        {
            return _request;
        }
    }

}
