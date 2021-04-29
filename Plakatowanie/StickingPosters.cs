using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plakatowanie
{
    public class StickingPosters
    {
        public int CountThePosters(List<Building> buildings)
        {
            int stackPosition = 0, numberOfPosters = 0;
            int[] buildingHight = new int[buildings.Count()];

            buildingHight[0] = buildings.First(x => x.Id == 0).Hight;

            for (int i = 1; i < buildings.Count(); i++)
            {

                while (buildings.First(x => x.Id == i).Hight < buildingHight[stackPosition])
                {
                    numberOfPosters++;
                    stackPosition--;

                    if (stackPosition == -1)
                    {
                        buildingHight[0] = buildings.First(x => x.Id == i).Hight;
                        stackPosition = 0;
                    }
                }
                if (buildings.First(x => x.Id == i).Hight > buildingHight[stackPosition])
                {
                    stackPosition++;
                    buildingHight[stackPosition] = buildings.First(x => x.Id == i).Hight;
                }
            }

            numberOfPosters += stackPosition + 1;

            return numberOfPosters;
        }



    }
}
