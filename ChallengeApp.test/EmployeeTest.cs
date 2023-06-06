namespace ChallengeApp.test
{
    public class EmployeeTest
    {

        [Test]
        public void WhenEmployeeAddedScoreAndGetCorrectResult()
        {
            // Arrange
            var employee = new Employee("Adam", "Duzy", 25);
            employee.AddScore(4);
            employee.AddScore(3);
            employee.AddScore(7);
            employee.AddScore(2);
            employee.AddScore(4);

            // Act
            var result = employee.Result;

            // Assert

            Assert.AreEqual(20, result);
        }
        [Test]
        public void WhenEmployessAddeNegativeScoreAndGetCorrectResult()
        {
            //Arange
            var employee = new Employee("Michal", "Materla", 35);
            employee.AddScore(4);
            employee.AddScore(-2);
            employee.AddScore(-1);
            employee.AddScore(4);
            employee.AddScore(5);

            // Act
            var result = employee.Result;

            // Arrange
            Assert.AreEqual(10, result);
        }

    }
}