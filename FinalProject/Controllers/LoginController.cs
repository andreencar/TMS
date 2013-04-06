using DropNet;
using DropNet.Models;
using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        
        [HttpGet]
        public ActionResult Dropbox() {
            DropNetClient _client;
            _client = new DropNetClient("n6jbrgjg3up2hes", "0tdql16y2mp0n95");
            _client.GetToken();
            Session["dropboxLogin"] = _client;
            return Redirect(_client.BuildAuthorizeUrl(HttpContext.Request.Url.AbsoluteUri)+"Authorize");      
        }

        [HttpGet]
        public ActionResult DropboxAuthorize(DropboxLogin authorized){
            DropNetClient client = (DropNetClient)Session["dropboxLogin"];
            client.UseSandbox = true;
            var accessToken = client.GetAccessToken();
            var meta = client.GetMetaData("/");
            return View(meta);
        }
    }
}
