using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Search search = new Search();
            search.DFS();
            Console.ReadKey();
        }
    }
}
