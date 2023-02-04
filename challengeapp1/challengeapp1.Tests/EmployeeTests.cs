namespace challengeapp1.Tests
{
    public class Tests
    {        
        [Test]
        public void StatisticsShouldBeTheSameAsExpected()
        {
            //arrange
            var employee = new Employee("Irek", "Œmierdzigirek");
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(-5);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(-5,statistics.Min);
            Assert.AreEqual(3,statistics.Max);
            Assert.AreEqual(0, statistics.Average);
           
        }

        [Test]
        public void IfNoGradesStatisticsMinAndMaxShouldBeZero()
        {
            //arrange
            var employee = new Employee("Irek", "Œmierdzigirek");
            
            //act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(0, statistics.Min);
            Assert.AreEqual(0, statistics.Max);
        }
    }
}