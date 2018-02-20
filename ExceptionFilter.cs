using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;


namespace MySommelier
{
    public class NotImplExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            HttpResponseMessage resp = new HttpResponseMessage(HttpStatusCode.NotImplemented)
            {
                Content = new StringContent(context.Exception.ToString()),
                ReasonPhrase = context.Exception.Message
            };

            context.Response = resp;
        }
    }
}
