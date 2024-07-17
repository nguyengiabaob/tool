using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace toolWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
       

        public MainController()
        {
            
        }

        [HttpGet("GetApi")]
        public IActionResult GetApi(string address, int port, string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebProxy myproxy = new WebProxy(address, port);
            myproxy.BypassProxyOnLocal = false;
            request.Proxy = myproxy;
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            return Ok("success");
        }
    }
}
