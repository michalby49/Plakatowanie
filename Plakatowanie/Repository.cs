using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plakatowanie
{
    public class Repository
    {
        public List<Building> GetBuildings(string filePath)
        {
            var listOfbuildings = new List<Building>();
            var streamReader = new StreamReader(filePath);

            int count = int.Parse(streamReader.ReadLine());

            for (int i = 0; i < count; i++)
            {
                listOfbuildings.Add(new Building
                {
                    Id = i,
                    Hight = int.Parse(streamReader.ReadLine().Split(' ').Last())
                });
            }
            return listOfbuildings;
        }

        public int GetResult(string filePath)
        {
            var streamReader = new StreamReader(filePath);

            return int.Parse(streamReader.ReadLine());
        }

    }
}
