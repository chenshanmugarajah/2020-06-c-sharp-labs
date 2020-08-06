using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace lab_37_homework
{
    class Program
    {
        public static string nasaUrl = "https://images-api.nasa.gov";
        public static string searchExt = "/search?q=";
        public static string response;
        public static Root jsonNasaData;
        public static int start = 0;
        public static int last = start + 5;

        static void Main(string[] args)
        {
            MainMenu();
        }

        static async void SearchNasaImages(string input)
        {
            using (var httpclient = new HttpClient())
            {
                response = await httpclient.GetStringAsync(nasaUrl + searchExt + input);
                jsonNasaData = JsonConvert.DeserializeObject<Root>(response); 
            }
        }

        static void MainMenu()
        {
            Console.WriteLine("\n===\tWelcome to the NASA data shower\t===");
            Console.Write("What do you want to see? ");
            string query = Console.ReadLine();
            Console.WriteLine($"You are searching for {query}");
            Thread.Sleep(2000);
            DisplayNasaData(query);
        }

        static void DisplayNasaData (string query)
        {
            SearchNasaImages(query);
            Console.WriteLine("\n\n===\tLoading results\t===");
            Thread.Sleep(1000);

            Console.WriteLine($"{jsonNasaData.collection.items.Count} results found.\n");
            ShowItems(start, last);
        }

        static void ShowItems(int start, int last)
        {
            var items = jsonNasaData.collection.items;
            for (int i = start; i <= last; i++)
            {
                Console.WriteLine($"\nPost {i}");
                Console.WriteLine($"Title: {items[i].data[0].title}");
                Console.WriteLine($"Description: {items[i].data[0].description}");
                Console.WriteLine($"Link to image:");
                Console.WriteLine(items[i].links[0].href);
                Console.WriteLine("");

                
            }
            NavigateItems();
        }

        static void NavigateItems()
        {
            Console.WriteLine("Next..\t9");
            Console.WriteLine("Back..\t1");
            Console.WriteLine("Exit..\t0");
            Console.Write("Choice: ");

            string inputStr = Console.ReadLine();
            int input = Convert.ToInt32(inputStr);

            if (input == 0)
            {
                MainMenu();
                start = 0;
                last = start + 5;
            }
            if (input == 9)
            {
                if (last + 5 < jsonNasaData.collection.items.Count)
                {
                    start = start + 5;
                    last = start + 5;
                }
                else last = jsonNasaData.collection.items.Count - 1;
            }
            if (input == 1)
            {
                if (start - 5 > 0)
                {
                    start = start - 5;
                    last = start - 5;
                }
                else start = 0;
            }
            ShowItems(start, last);
        }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Link
    {
        public string href;
        public string rel;
        public string prompt;
    }

    public class Metadata
    {
        public int total_hits;
    }

    public class Link2
    {
        public string href;
        public string rel;
        public string render;
    }

    public class Datum
    {
        public string secondary_creator;
        public string description_508;
        public string nasa_id;
        public DateTime date_created;
        public List<string> keywords;
        public string title;
        public string center;
        public string media_type;
        public string description;
    }

    public class Item
    {
        public string href;
        public List<Link2> links;
        public List<Datum> data;
    }

    public class Collection
    {
        public string href;
        public string version;
        public List<Link> links;
        public Metadata metadata;
        public List<Item> items;
    }

    public class Root
    {
        public Collection collection;
    }



}
