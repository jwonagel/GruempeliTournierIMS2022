using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruempeliTournier.Model;

namespace GruempeliTournier.Test.Model
{

    [TestClass]
    public class PlayerTest
    {

        [TestMethod]
        public void TestFullName()
        {
            // arrange 
            var player = new Player()
            {
                FirstName = "Max",
                Name = "Muster",
                BirthDate = new DateTime(2000, 8, 5)
            };

            // Act

            var fullName = player.GetFullName();

            // Assert

            Assert.AreEqual("Max Muster (05. Aug. 2000)", fullName);
        }

    }
}
