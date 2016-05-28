using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient();
            var db = client.GetDatabase("test");
            var col = db.GetCollection<Pessoa>("pessoa");

            var pessoa = col.Find(x => x.name.StartsWith("Elton")).FirstOrDefault();
        }
    }

    public class Pessoa
    {
        public int _id { get; set; }
        public string name { get; set; }
        public string profession { get; set; }
        public int age { get; set; }
    }

}
