

namespace ChallengeApp.test
{
    public class TypeTests
    {

        [Test]
        public void CompareTwoNumberS()
        {
            //Arrange
            int number1 = 1;
            int number2 = 3;

            //Assert
            Assert.AreNotEqual(number1, number2);

        }

        [Test]
        public void CheckStringAreNotTheSame()
        {
            //Arrange
            string number1 = "14";
            string number2 = "15";

            //Assert
            Assert.AreNotEqual(number1, number2);

        }

        [Test]
        public void CHeckWithFloatIsSmaller()
        {
            //Arrange
            float number1 = 1.5f;
            float number2 = 2.3f;

            //Assert
            Assert.Less(number1, number2);
        }

        [Test]
        public void CompareEmployeesAreTheSameName()
        {
            // Arrange
            var employee1 = GetEmployee("Marek");
            var employee2 = GetEmployee("Marek");

            // Assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }


        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}