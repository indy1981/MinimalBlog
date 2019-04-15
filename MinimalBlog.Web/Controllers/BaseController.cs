using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace MinimalBlog.Web.Controllers
{
    public class BaseController : Controller
    {
        protected void AddTokenToClient(HttpClient httpClient)
        {
            var accessToken = User.FindFirst("access_token").Value;
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
        }
    }
}