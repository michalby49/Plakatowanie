using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plakatowanie.UnitTests
{
    public class StickingPostersTests
    {
        [Test]
        public void CountThePosters_WhenInputFileIsPla1ain_ResoultFromPla1aout ()
        {
            //Arrange
            var stickingPosters = new StickingPosters();
            var repository = new Repository();
            string pathInput = "pla1a.in", pathResoult = "pla1a.out";
            var buildings = repository.GetBuildings(pathInput);

            //Act
            int result = stickingPosters.CountThePosters(buildings);

            //Assert
            Assert.AreEqual(result, repository.GetResult(pathResoult));

        }

        [Test]
        public void CountThePosters_WhenInputFileIsPla1bin_ResoultFromPla1bout()
        {
            //Arrange
            var stickingPosters = new StickingPosters();
            var repository = new Repository();
            string pathInput = "pla1b.in", pathResoult = "pla1b.out";
            var buildings = repository.GetBuildings(pathInput);

            //Act
            int result = stickingPosters.CountThePosters(buildings);

            //Assert
            Assert.AreEqual(result, repository.GetResult(pathResoult));

        }

        [Test]
        public void CountThePosters_WhenInputFileIsPla1cin_ResoultFromPla1cout()
        {
            //Arrange
            var stickingPosters = new StickingPosters();
            var repository = new Repository();
            string pathInput = "pla1c.in", pathResoult = "pla1c.out";
            var buildings = repository.GetBuildings(pathInput);

            //Act
            int result = stickingPosters.CountThePosters(buildings);

            //Assert
            Assert.AreEqual(result, repository.GetResult(pathResoult));

        }

        [Test]
        public void CountThePosters_WhenInputFileIsPla3ain_ResoultFromPla3aout()
        {
            //Arrange
            var stickingPosters = new StickingPosters();
            var repository = new Repository();
            string pathInput = "pla3a.in", pathResoult = "pla3a.out";
            var buildings = repository.GetBuildings(pathInput);

            //Act
            int result = stickingPosters.CountThePosters(buildings);

            //Assert
            Assert.AreEqual(result, repository.GetResult(pathResoult));

        }
    }
}
