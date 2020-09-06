using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Unitech.Controllers
{
    public class BaseController : Controller
    {
       
    }

    public static class HTTPExtensions
    {
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            if (request == null)
                return false;
            else if (request.Headers != null)
                return request.Headers["X-request-With"] == "XMLHttpRequest";
            return false;
        }
    }
}
