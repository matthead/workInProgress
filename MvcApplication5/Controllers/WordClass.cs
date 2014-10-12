using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
namespace MvcApplication5.Controllers
{
    public class WordClass
    {
        public static string GetWord()
        {
           /* count = 0;
            string url = "http://randomword.setgetgo.com/get.php";
            var request = System.Net.WebRequest.Create(url);
            request.ContentType = "application/json; charset=utf-8";
            var response = (System.Net.HttpWebResponse)request.GetResponse();
            using (var sr = new System.IO.StreamReader(response.GetResponseStream()))
            {
                word = sr.ReadToEnd().Trim();
            }
            return word;*/
            word = "matt";
            return word;
            
        }
        public static string word { get; private set; }
    }
}