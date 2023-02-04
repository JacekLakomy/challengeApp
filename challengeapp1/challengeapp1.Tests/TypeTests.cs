namespace challengeapp1.Tests
{
    public class TypeTests
    {
        [Test]

        public void TheSameStringsValueShouldBeEqual()
        {
            //arrange
            string text1 = "c";
            string text2 = "c";

            //act

            //assert
            Assert.AreEqual(text1, text2);
        }

        [Test]

        public void DifferentStringsValueShouldBeNotEqual()
        {
            string text1 = "a";
            string text2 = "b";

            Assert.AreNotEqual(text1, text2);
        }

        [Test]

        public void TheSameCharValueShouldBeEqual()
        {
            char letter1 = 'i';
            char letter2 = 'i';

            Assert.AreEqual(letter1, letter2);
        }

        [Test]

        public void DifferentCharValueShouldBeNotEqual()
        {
            char letter1 = 'i';
            char letter2 = 'j';

            Assert.AreNotEqual(letter1, letter2);
        }

        [Test]

        public void TheSameIntValueShouldBeEqual()
        {
            int number1 = 1;
            int number2 = 1;

            Assert.AreEqual(number1, number2);
        }

        [Test]

        public void DifferentIntValueShouldBeNotEqual()
        {
            int number1 = 1;
            int number2 = 3;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void TheSameFloatValueShouldBeEqual()
        {
            float number1 = 1.545644f;
            float number2 = 1.545644f;

            Assert.AreEqual(number1, number2);
        }


        [Test]
        public void DifferentFloatValueShouldBeNotEqual()
        {
            float number1 = 1.545644f;
            float number2 = 10.525844f;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void TheSameDoubleValueShouldBeEqual()
        {
            double number1 = 1.545644987;
            double number2 = 1.545644987;

            Assert.AreEqual(number1, number2);
        }


        [Test]
        public void DifferentDoubleValueShouldBeNotEqual()
        {
            double number1 = 1.545644415646;
            double number2 = 10.525844545454;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void GetUserShouldReturnDiffrentObjects()
        {
            //arrange
            var employee1 = GetEmployee("Adam", "Adamski");
            var employee2 = GetEmployee("Adam", "Adamski");

            //act
          
            //assert
            
            Assert.AreNotEqual(employee1, employee2);
        }
        
        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }

        [Test]

        public void TreesWithTheSameParametersShouldBeDifferentTrees()
        {          
            var tree1 = new Tree("Sprouce", 23);
            var tree2 = new Tree("Sprouce", 23);
                  
            //act
                        
            //assert
            Assert.AreNotEqual(tree1, tree2);




        }
    }
}
