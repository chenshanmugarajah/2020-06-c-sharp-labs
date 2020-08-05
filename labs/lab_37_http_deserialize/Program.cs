using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;

namespace lab_37_http_deserialize
{
    class Program
    {
        static Uri url = new Uri("https://jsonplaceholder.typicode.com/todos");
        public static List<Todo> todos = new List<Todo>();
        public static List<Todo> todosAsync = new List<Todo>();
        public static Stopwatch s = new Stopwatch();

        static void Main(string[] args)
        {
            s.Start();
            GetTodos();
            Console.WriteLine($"Recieved todos arrived with {todos.Count} items");
            Console.WriteLine($"Completed at: {s.ElapsedMilliseconds} ms\n");

            s.Restart();

            GetTodosAsync();
            Console.WriteLine($"Recieved todos async arrived with {todosAsync.Count} items");
            Console.WriteLine($"Completed at: {s.ElapsedMilliseconds} ms\n");
            Thread.Sleep(2000);
            Console.WriteLine($"Waited for results, now {todosAsync.Count} items");
        }

        static async void GetTodosAsync()
        {
            using (var httpclient = new HttpClient())
            {
                var response = await httpclient.GetStringAsync(url);
                todosAsync = JsonConvert.DeserializeObject<List<Todo>>(response);
            }
        }

        static void GetTodos()
        {
            using (var httpclient = new HttpClient())
            {
                var response = httpclient.GetStringAsync(url);
                string data = response.Result;
                todos = JsonConvert.DeserializeObject<List<Todo>>(data);
            }
        }
    }

    public class Todo
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }

        public Todo(int userid, int id, string title, bool completed)
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
