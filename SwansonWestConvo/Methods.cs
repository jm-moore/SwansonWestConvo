using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwansonWestConvo
{
    public class Methods
    {
        public void SwansonQuote()
        {
            var client = new HttpClient();

            var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var swansonQuote = client.GetStringAsync(swansonURL).Result;

            var swansonObject = JArray.Parse(swansonQuote);

            Console.WriteLine($"Ron Swanson-\n{swansonObject[0]}");
            Console.WriteLine();
        }

        public void WestQuote()
        {
            var client = new HttpClient();

            var westUrl = "https://api.kanye.rest";

            var westQuote = client.GetStringAsync(westUrl).Result;

            var westObject = JObject.Parse(westQuote);

            Console.WriteLine($"Kanye West-\n{westObject["quote"]}");
            Console.WriteLine();
        }
    }
}
