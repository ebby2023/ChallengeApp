

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



        public void WhenEmployeeGetPoint_ShouldReceivedCorrectNumber()
        {
            // arrange
            var employee = new Employee("Adam", "Malysz");
            employee.AddGrade(90);
            employee.AddGrade('b');
            employee.AddGrade('c');

            //act
            var statistick = employee.GetStatistics();

            // assert

            Assert.AreEqual('B', statistick.AverageLetter);

        }
        [Test]
        public void EmployeeGetGrades_ShouldReturnedGoodMaxAndMinValue()
        {
            //arrange
            var employee = new Employee("Marek", "Bak");
            employee.AddGrade(60);
            employee.AddGrade("60");
            employee.AddGrade("A");
            employee.AddGrade('a');

            //act
            var statistick = employee.GetStatistics();

            //assert
            Assert.AreEqual(100, statistick.Max);
            Assert.AreEqual(60, statistick.Min);


        }
    }

}