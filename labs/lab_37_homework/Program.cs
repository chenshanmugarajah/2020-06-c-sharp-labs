using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading;
using Newtonsoft.Json;

namespace lab_37_homework
{
    class Program
    {
        public static string nasaUrl = "https://images-api.nasa.gov";
        public static string searchExt = "/search?q=";
        public static string response;
        public static Root jsonNasaData;

        static void Main(string[] args)
        {
            SearchNasaImages("cloud");
            Thread.Sleep(2000);
            DisplayNasaData(jsonNasaData.collection.items);
        }

        static async void SearchNasaImages(string input)
        {
            using (var httpclient = new HttpClient())
            {
                response = await httpclient.GetStringAsync(nasaUrl + searchExt + input);
                jsonNasaData = JsonConvert.DeserializeObject<Root>(response); 
            }
        }

        static void Menu()
        {
        }

        static void DisplayNasaData (List<Item> items)
        {
            foreach (var item in items)
            {
                
            }
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
