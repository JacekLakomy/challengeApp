using System.Reflection.Metadata;

namespace challengeapp1.Tests
{
    public class Tests
    {
        
        [Test]
        public void WhenUserCollectPositiveAndNegativePoints_ShouldCorrectResult()
        {
            //arrange
            var user = new Employee("Gra¿yna", "Ba¿yna");
            user.AddRating(5);
            user.AddRating(6);
            user.PenaltyPoints(10);
            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(1, result);
           
        }
    }
}