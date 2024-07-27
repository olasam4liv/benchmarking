using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanJsonObject
{
    internal class Todo
    {

        public Todo()
        {
                
        }

        public void SomeMethod()
        {
            var result = SomeAsyncMethod().Result; // Blocking call
        }


        public async Task SomeMethodAsync()
        {
            var result = await SomeAsyncMethod();
        }


        private async Task<dynamic?> SomeAsyncMethod()
        {
            throw new NotImplementedException();
        }

//        BenchmarkExample benchmarkExample = new BenchmarkExample();
//        Console.WriteLine("FindMaxNumber: {0}", benchmarkExample.FindMaxNumber());
//Console.WriteLine("FindMaxNumberMethod: {0}", benchmarkExample.FindMaxNumberMethod());
        //using (HttpClient client = new HttpClient())
        //{
        //    try
        //    {
        //        string url = "https://coderbyte.com/api/challenges/json/json-cleaning";
        //        HttpResponseMessage response = await client.GetAsync(url);
        //        response.EnsureSuccessStatusCode();

        //        string jsonString = await response.Content.ReadAsStringAsync();
        //        Console.WriteLine(jsonString);
        //        JObject jsonObject = JObject.Parse(jsonString);

        //        CleanJsonObject(jsonObject);

        //        string cleanedJsonString = JsonConvert.SerializeObject(jsonObject);
        //        Console.WriteLine(cleanedJsonString);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"An error occurred: {e.Message}");
        //    }
        //}

        //static void CleanJsonObject(JToken token)
        //{
        //    if (token is JObject)
        //    {
        //        var propertiesToRemove = new List<JProperty>();

        //        foreach (var property in token.Children<JProperty>())
        //        {
        //            if (property.Value.Type == JTokenType.String &&
        //                (property.Value.ToString() == "N/A" || property.Value.ToString() == "-" || property.Value.ToString() == ""))
        //            {
        //                propertiesToRemove.Add(property);
        //            }
        //            else
        //            {
        //                CleanJsonObject(property.Value);
        //            }
        //        }

        //        foreach (var property in propertiesToRemove)
        //        {
        //            property.Remove();
        //        }
        //    }
        //    else if (token is JArray)
        //    {
        //        var itemsToRemove = new List<JToken>();

        //        foreach (var item in token.Children())
        //        {
        //            if (item.Type == JTokenType.String &&
        //                (item.ToString() == "N/A" || item.ToString() == "-" || item.ToString() == ""))
        //            {
        //                itemsToRemove.Add(item);
        //            }
        //            else
        //            {
        //                CleanJsonObject(item);
        //            }
        //        }

        //        foreach (var item in itemsToRemove)
        //        {
        //            item.Remove();
        //        }
        //    }
        //}

    }
}
