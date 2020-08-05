using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks.Dataflow;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace lab_36_http
{
    class Program
    {
        static Uri url = new Uri("https://jsonplaceholder.typicode.com/todos/5");
        static Uri url2 = new Uri("https://www.bbc.co.uk");

        static void Main(string[] args)
        {
            // HTTP - Hyper Text Transfer Protocol
            // Uses fixed <tag> </tags> 
            // HTML is just text file which is opened and rendered by browser

            //GetDataUsingWebClient();
            //GetPageUsingWebClient();
            //GetPageUsingWebRequest();
            //GetDataUsingHttpClient();
        }

        static void GetDataUsingHttpClient()
        {
            var httpclient = new HttpClient();
            var response = httpclient.GetStringAsync(url);
            var data = response.Result;
            Console.WriteLine("=== Data from Response ===");
            Console.WriteLine(data);
            Console.WriteLine("");

            var json = JObject.Parse(data);
            //Console.WriteLine(json["completed"]);

            Console.WriteLine("Deserilised");
            User user = JsonConvert.DeserializeObject<User>(data);
            //Console.WriteLine(user);
            Console.WriteLine($"{user.userId, -10}{user.id, -10}{user.title, -10}{user.completed, -10}");
        }

        static void GetDataUsingWebClient()
        {
            WebClient webClient = new WebClient { Proxy = null };
            var data = webClient.DownloadString(url);
            Console.WriteLine(data);
        }

        static void GetPageUsingWebClient()
        {
            WebClient webClient = new WebClient { Proxy = null };
            webClient.DownloadFile(url2, "bbcpage.html");
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "bbcpage.html");
        }

        static void GetPageUsingWebRequest()
        {
            var bbcRequest = WebRequest.Create(url2);
            bbcRequest.Proxy = null;

            var bbcResponse = bbcRequest.GetResponse();

            //Console.WriteLine("Recieved BBC content");
            //Console.WriteLine(bbcResponse.ContentType);
            //Console.WriteLine(bbcResponse.ContentLength);

            var pageRequestHeader = bbcResponse.Headers.AllKeys;
            Console.WriteLine(pageRequestHeader.Length);
            foreach (var key in pageRequestHeader)
            {
                Console.WriteLine(key);
            }
        }
    }

    public class User
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }

        public User(int userid, int id, string title, bool completed)
        {
            this.userId = userid;
            this.id = id;
            this.title = title;
            this.completed = completed;
        }

        public override string ToString()
        {
            return $"userid: {userId}, id: {id}, title: {title}, complete: {completed}";
        }
    }
}
