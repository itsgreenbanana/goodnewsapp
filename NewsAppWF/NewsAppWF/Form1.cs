using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using Newtonsoft.Json.Serialization;
using System.Threading;
using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.Script.Serialization;
using System.IO;

namespace NewsAppWF
{
    public partial class Form1 : Form
    {
        string currentTitle;
        string currentAuth;
        string currentDesc;
        string currentUrl;
        string currentPub;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var newsApiClient = new NewsApiClient("a2c0e585fc08450292f86e48e4439bef");
            //var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            //{
            //    Q = "Apple",
            //    SortBy = SortBys.Popularity,
            //    Language = Languages.EN,
            //    From = new DateTime(2018, 1, 25)
            //});
            //if (articlesResponse.Status == Statuses.Ok)
            //{

            //    // here's the first 20
            //    foreach (var article in articlesResponse.Articles)
            //    {
            //        // title
            //        currentTitle = article.Title;
            //        // author
            //        currentAuth = article.Author;
            //        // description
            //        currentDesc = article.Description;
            //        // url
            //        currentUrl = article.Url;
            //        // published at
            //        currentPub = article.PublishedAt.ToString();

            //        label1.Text = currentTitle;
            //        label2.Text = currentAuth;
            //        label3.Text = currentDesc;
            //        label4.Text = currentPub;
            //        linkLabel1.Text = currentUrl;

            //    }

            //}
            var url = "https://newsapi.org/v2/everything?" +
          "q=Apple&" +
          "from=2019-10-28&" +
          "sortBy=popularity&" +
          "apiKey=a2c0e585fc08450292f86e48e4439bef";
            //List<News> newsList = new List<News>();
            //var Serializer = new JavaScriptSerializer();
            var json = new WebClient().DownloadString(url);
            //var serializedResult = Serializer.Serialize(json);
            //var deserializedResult = Serializer.Deserialize<List<News>>(serializedResult);
            Debug.WriteLine(json);
            //Debug.WriteLine(serializedResult);
            File.WriteAllText(@"C:\users\josh\desktop\json.json", json);

        }
    }
    public class News 
    {
        private string source;
        private string author;
        private string title;
        private string description;
        private string url;
    }

    public static class JsonConvert { }
}
