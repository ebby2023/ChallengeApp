

namespace ChallengeApp.test
{
    public class EmployeeTest
    {

        [Test]
        public void WhenUsedStatistics_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Marek", "Duzy");
            employee.AddGrade(3);
            employee.AddGrade(6);
            employee.AddGrade(3);

            // act

            var result = employee.GetStatistics();

            // assert 

            Assert.AreEqual(6, result.Max);


        }
        [Test]
        public void WhenUsedStatistics_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new Employee("Michal", "Break");
            employee.AddGrade(3);
            employee.AddGrade(8);
            employee.AddGrade(1);

            // act 
            var result = employee.GetStatistics();

            // assert

            Assert.AreEqual(1, result.Min);
        }
        [Test]
        public void WhenUsedStatistics_ShouldReturnCorrectAvarage()
        {
            // arrange
            var employee = new Employee("Marian", "Lyzwa");
            employee.AddGrade(7);
            employee.AddGrade(1);
            employee.AddGrade(2);

            // act
            var result = employee.GetStatistics();

            // assert

            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(result.Average, 2));
        }

    }
}