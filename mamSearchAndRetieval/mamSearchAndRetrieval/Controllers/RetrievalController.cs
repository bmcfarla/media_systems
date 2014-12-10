using mamSearchAndRetrieval.Models;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace mamSearchAndRetrieval.Controllers
{
    public class RetrievalController : AppController
    {
        // GET: Retrieval
        public ActionResult Details(string dmguid, string token)
        {
            RetrievalModel retrievalModel = new RetrievalModel(dmguid, token);

            return View(retrievalModel);
        }

        // GET: Retrieval
        public Stream Download()
        {
            string fileUri = "http://ma-stream01.ngs.org:13000/MA/SSMBA/get?emguid=c0ad0dc2-c16f-42a0-a9f6-34c671c0d76f&accesskey=c57e4a13-a4e1-4775-9433-e8631d2ce4cb";

            string filename = @"M:\MPEG1\2001001902NGT\2001001902NGT_0_3_1.MPG";

            WebRequest req = WebRequest.Create(fileUri);
            WebResponse response = req.GetResponse();
            Stream stream = response.GetResponseStream();

            return stream;
            /*

            WebClient webClient = new WebClient();

            webClient.DownloadFileAsync(new URI(fileUri), "blah.mov");
            string regExString = "^M:";

            string file = Regex.Replace(filename, "^M:", @"\\archive-ha100");

            //string file = Server.MapPath(Url.Content("~/Content/bootstrap.css"));

            FileInfo f = new FileInfo(file);

            long fileLength = f.Length;
            string fileName = f.Name;

            //var fileName = "bootstrap.css";
            //var fileLength = "10000";
            //var filePath = "/Content/bootstrap.css";
            

            Response.Clear();
            Response.BufferOutput = false;
            Response.ContentType = "application/octet-stream";
            Response.AddHeader("Content-Length", "1000");
            Response.AddHeader("content-disposition", "attachment; filename=" + "BLAH.MPG");
            Response.TransmitFile(stream);
            Response.Flush();
            */
        }
    }
}