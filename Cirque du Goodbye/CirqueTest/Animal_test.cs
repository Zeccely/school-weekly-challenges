using Cirque_du_Goodbye;

namespace CirqueTest
{
    [TestClass]
    public class Animal_test
    {
        private Animal Lion;
        private Animal Giraffe;
        private Animal Goat;

        [TestInitialize]
        public void Initialize()
        {
            Lion = new Animal(Size.Medium, Diet.Carnivore);
            Giraffe = new Animal(Size.Large, Diet.Herbivore);
            Goat = new Animal(Size.Small, Diet.Herbivore);
        }

        [TestMethod]
        public void TestCanEat()
        {  
            Assert.IsTrue(Lion.CanEat(Goat));
        }
        [TestMethod]
        public void TestCanEat2()
        {
            Assert.IsFalse(Lion.CanEat(Giraffe));
        }

        [TestMethod]
        public void TestCanEat3()
        {
            Assert.IsTrue(Lion.CanEat(Lion));
        }
    }

}
