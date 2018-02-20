using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MySommelier
{
    [RoutePrefix("api")]
    [NotImplExceptionFilter]
    //[Authorize]

#if !DEBUG
        [Authorize]
#endif
    public class WineController : ApiController
    {

      SommelierDataContext sc = new SommelierDataContext();

      public WineController() { }

      public List<Wine> Get()
      {
        List<Wine> wines = new List<Wine>();
        try
        {
          //wines = sc.Wines..AsNoTracking().

        }
        catch (Exception ex)
        {
            HttpResponseMessage resp = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent(ex.ToString()),
                ReasonPhrase = ex.Message
            };
            throw new HttpResponseException(resp);
        }

        return wines;
      }

        public int Put(Dictionary<string, object> Assessment)
        {
            int assessmentId = 0;
            try
            {
                //DataAccess da = new DataAccess();
                //assessmentId = da.UpdateAssessment(Assessment);

            }
            catch (Exception ex)
            {
                HttpResponseMessage resp = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.ToString()),
                    ReasonPhrase = ex.Message
                };
                throw new HttpResponseException(resp);
            }

            return assessmentId;
        }
    }
}
