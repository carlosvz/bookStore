using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Net.Http;
using System.Net;

namespace BookStore.Util.Attributes
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        private const string BasicAuthResponseHeader = "WWW-Autenticate";
        private const string BasicAuthResponseHeaderValue = "Basic";

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            AuthenticationHeaderValue authValue = actionContext.Request.Headers.Authorization;

            if (authValue != null && !string.IsNullOrEmpty(authValue.Parameter) && authValue.Scheme == BasicAuthResponseHeaderValue)
            {
                string[] credentials = Encoding.ASCII.GetString(Convert.FromBase64String(authValue.Parameter)).Split(new[] { ':' });
                ///Autentica o usuario daqui em diante
            }
            else
            {
                actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                return;
            }
            base.OnAuthorization(actionContext);
        }
    }
}
