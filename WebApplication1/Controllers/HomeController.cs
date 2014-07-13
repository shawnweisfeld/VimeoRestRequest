using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult VideoDetails(string id = "100578839")
        {
            var client = new RestClient("https://api.vimeo.com");
            var request = new RestRequest("videos/{id}");
            request.AddUrlSegment("id", id);
            request.AddHeader("Authorization", "<< the password goes here >>");
            var response = client.Execute(request);

            ViewBag.Json = response.Content;
            var video = JsonConvert.DeserializeObject<Models.Video>(response.Content);

            return View(video);
        }
    }
}