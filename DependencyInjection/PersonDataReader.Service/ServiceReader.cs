using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataReader.Service
{
    public class ServiceReader
    {
        WebClient client = new WebClient();
        string baseUri = "http://localhost:9874/api/people";

        public IEnumerable<Person> getPeople()
        {
            string result = client.DownloadString(baseUri);
            var people = JsonConvert
        }
    }
}
