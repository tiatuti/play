using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SampleApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome()
        {
            
    
            var html = new HtmlDocument();
            html.Load(@"C:\_Sandra\NET\SampleApp\HRSD.html"); // load from a file

            // load from a URL
            // html.LoadHtml(new WebClient().DownloadString("http://www.mikesdotnetting.com/article/273/using-the-htmlagilitypack-to-parse-html-in-asp-net"));


            html.LoadHtml(new WebClient().DownloadString("http://dw38dusgut02.dev.us.corp/pdf-html/LeftPanePrototypes/JobAid_MultipleTopics.html"));

            HtmlNode node = html.DocumentNode.SelectSingleNode("//article");

            ViewBag.Message = node.InnerHtml;

            return View();
        }

    }
}