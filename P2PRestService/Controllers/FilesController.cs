using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace P2PRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {

        private static Dictionary<string , List<FileEndPoint>> dic = new Dictionary<string, List<FileEndPoint>>();

        private string filename1 = "Test.txt";
        FileEndPoint fep1 = new FileEndPoint("localhost", 3300);
        FileEndPoint fep2 = new FileEndPoint("localhost", 4000);


        private static void InsertIntoDictionary(Dictionary<string, List<FileEndPoint>> dic, string filename, FileEndPoint fep)
        {
            if (dic.ContainsKey(filename))
            {
                List<FileEndPoint> ListOfFeps = dic[filename];
                ListOfFeps.Add(fep);
            }
            else
            {
                List<FileEndPoint> ListOfFeps = new List<FileEndPoint>();
                ListOfFeps.Add(fep);
                dic.Add(filename, ListOfFeps);
            }
        }

        private static List<FileEndPoint> SearchInDictionary(Dictionary<string, List<FileEndPoint>> dic, string filename)
        {
            if (dic.ContainsKey(filename))
            {
                return dic[filename];
            }

            return new List<FileEndPoint>();
        }

        // GET: api/Files
        [HttpGet]
        public IEnumerable<FileEndPoint> Get(string filename)
        {
            return dic[filename];
        }

        // GET: api/Files/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Files
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Files/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
