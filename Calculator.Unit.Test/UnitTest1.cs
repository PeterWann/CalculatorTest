using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;


namespace Calculator.Unit.Test
{
    public class Tests
    {
        private Calculator _uut;
        [SetUp]

        public void Setup()
        {
            _uut = new Calculator();
        }

        [Test]
        public void Add_AddTwoNumbersTogether_CorrectOutput()
        {
            // Act + Assert

            Assert.That(_uut.Add(5, 6), Is.EqualTo(11));

        }

        [Test]
        public void Subtract_SubtractTwoNumbers_CorrectOutput()
        {
            // Act + Assert

            Assert.That(_uut.Subtract(7,4),Is.EqualTo(3));
            
        }

        [Test]

        public void Multiply_MultiplyTwoNumbersTogether_CorrectOutput()
        {
            // Act + Assert

            Assert.That(_uut.Multiply(5,5),Is.EqualTo(25));
        }

        [Test]

        public void Power_PowerInExp_CorrectOutput()
        {
            // Act + Assert

            Assert.That(_uut.Power(3,4),Is.EqualTo(81));
        }

    }
}