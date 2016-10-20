namespace YouTubeRSS
{
    using System;
    using System.IO;
    using System.Net;
    using Newtonsoft.Json;
    using System.Xml.Linq;
    using Newtonsoft.Json.Linq;
    using System.Linq;
    using System.Text;
    class Program
    {

        static void Main()
        {
            string downloadLink = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string fileLocation = "../../YouTubeRss.xml";

            //Try downloading the file
            DownloadRssFile(downloadLink, fileLocation);
            
            //Parse the XML to JSON
            var XMLdoc = XDocument.Load(fileLocation);
            var json = JsonConvert.SerializeXNode(XMLdoc,Formatting.Indented);

            var jsonObj = JObject.Parse(json);

            GenerateHTML(jsonObj);
            PrintVideoTitles(jsonObj);
        }

        private static void DownloadRssFile(string downloadLink, string fileLocation)
        {
            try
            {
                WebClient downloader = new WebClient();
                downloader.DownloadFile(downloadLink, fileLocation);
            }
            catch (WebException)
            {
                Console.WriteLine("Wrong file name or no internet connection!");
            }
        }

        private static void GenerateHTML(JObject jsonObj)
        {
            JToken videos = jsonObj["feed"]["entry"];

            var str = new StringBuilder();

            str.Append("<!DOCTYPE html>");
            str.Append("<html><head><title>Telerik Academy Latest Videos</title></head><body style=\"background:#77FF77;\">");

            foreach (var video in videos)
            {
                str.AppendFormat(
                    "<div style=\"background:#33FF33; color:black;  float: left; width:400px; padding:10px; margin:10px;\"><h3><a style=\"text-decoration:none; color:black; margin: 0; padding:0;\" href=\"{0}\">{1}</a></h3><iframe width=\"370\" height=\"265\" src=\"https://www.youtube.com/embed/{2}\"></iframe></div>",
                    (string)video["link"]["@href"],
                    video["title"],
                    video["yt:videoId"]);
            }

            str.Append("</body></html>");
            
            File.WriteAllText("../../index.html", str.ToString(), Encoding.UTF8);
        }

        private static void PrintVideoTitles(JObject jsonObj)
        {
            JToken videos = jsonObj["feed"]["entry"];

            foreach (var item in videos)
            {
                Console.WriteLine(item["title"]);
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
