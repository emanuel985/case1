using calculatorexc1.classes;

namespace Testcalculator
{
    public class Test_Calculator
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            calculator calc = new calculator();

            Assert.That(calc.Subtract(8, 2),Is.EqualTo(6));
        }
    }
}