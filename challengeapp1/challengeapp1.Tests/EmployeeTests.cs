namespace challengeapp1.Tests
{
    public class Tests
    {
        [Test]
        public void GradeAsLetterAShouldReturnCorrectStatistics()
        {
            //arrange
            var employee = new Employee("Jacek", "£akomy");

            employee.AddGrade("a");
            employee.AddGrade("A");
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(100, statistics.Min);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(100, statistics.Average);
            Assert.AreEqual('A', statistics.AverageLetter);
        }

        [Test]
        public void GradeAsLetterBShouldReturnCorrectStatistics()
        {
            //arrange
            var employee = new Employee("Jacek", "£akomy");

            employee.AddGrade("b");
            employee.AddGrade("B");
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(80, statistics.Min);
            Assert.AreEqual(80, statistics.Max);
            Assert.AreEqual(80, statistics.Average);
            Assert.AreEqual('A', statistics.AverageLetter);
        }

        [Test]
        public void GradeAsLetterCShouldReturnCorrectStatistics()
        {
            //arrange
            var employee = new Employee("Jacek", "£akomy");

            employee.AddGrade("c");
            employee.AddGrade("C");
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(60, statistics.Min);
            Assert.AreEqual(60, statistics.Max);
            Assert.AreEqual(60, statistics.Average);
            Assert.AreEqual('B', statistics.AverageLetter);
        }

        [Test]
        public void GradeAsNumberCShouldReturnCorrectStatistics()
        {
            //arrange
            var employee = new Employee("Jacek", "£akomy");

            employee.AddGrade("100");
            employee.AddGrade("0");
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(0, statistics.Min);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(50, statistics.Average);
            Assert.AreEqual('C', statistics.AverageLetter);
        }
    }
}