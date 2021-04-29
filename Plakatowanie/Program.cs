using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plakatowanie
{
    public class Program
    {
        static void Main(string[] args)
        {
            var repository = new Repository();
            var listOfBuildings = repository.GetBuildings("pla0.in");
            var stickingPosters = new StickingPosters();


            Console.WriteLine(stickingPosters.CountThePosters(listOfBuildings));
        }
    }
}
