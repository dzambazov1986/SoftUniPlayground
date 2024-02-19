namespace ConsoleAppSummator.Tests
{
    public class AppSummatorTest
    {
        [SetUp]
        public void Setup() 
        {
            ;
        }
        [TearDown]

        public void Teardown()
        {
            ;
        }

        [Test]
        public void ProgramSumShowReturnSummedNumbers()
        {
          int sumOfArray =  Program.Sum(new int[] { 1, 2, 3 });
            Assert.AreEqual(6, sumOfArray);
        }

        [Test]
        public void ProgramSumShouldReturb0ifNothingPassed()
        {
            int sumOfArray = Program.Sum(new int[0]);
            Assert.That(sumOfArray == 0);   
        }







    }

    }

