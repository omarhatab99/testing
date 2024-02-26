using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WeightCalculator;

namespace WeightCalculatorTest
{
    [TestClass]
    public class WeightCalculationTest
    {
        [TestMethod]
        [Description("")]
        [Owner("Alyaa")]
        [Priority(1)]
        [TestCategory("Gender")]
        //[Ignore]
        public void GetWeight_Height_162_Gender_f_return_56()
        {   //Arrange
            WeightCalculation sut = new WeightCalculation
            {
                Height = 162,
                Gender = 'f'
            };

            //Act
            double actual = sut.GetWeight();
            double expected = 56;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //[TestMethod]
        //[TestCategory("Gender")]
        //public void GetWeight_Height_180_Gender_m_return_72_5()
        //{   //Arrange
        //    WeightCalculation sut = new WeightCalculation
        //    {
        //        Height = 180,
        //        Gender = 'm'
        //    };

        //    //Act
        //    double actual = sut.GetWeight();
        //    double expected = 72.5;

        //    //Assert
        //    Assert.AreEqual(expected, actual);

        //}


        //[TestMethod]
        //public void Assert_Test()
        //{
        //    //Assert.AreEqual(100, 100);
        //    //WeightCalculation calc1 = new WeightCalculation();
        //    //WeightCalculation calc2 = new WeightCalculation();
        //    //Assert.AreNotSame(calc1, calc2);

        //    //WeightCalculation calc2 = new WeightCalculation();
        //    ////Assert.IsInstanceOfType(calc2,typeof(WeightCalculation) );
        //    //calc2 = null;
        //    //Assert.IsNotNull(calc2);

        //    Assert.IsFalse(100 == 56);


        //}

        //[TestMethod]
        //public void String_Assert_Test()
        //{
        //    string name = "Omar";
        //    //StringAssert.Contains(name,"m");
        //    //StringAssert.EndsWith(name, "ar");
        //    //StringAssert.StartsWith(name, "O");



        //}

        //[TestMethod]
        //public void Fluent_Assert_Test()
        //{
        //    string name = "Omar";
        //    name.Should().StartWith("O");
        //    name.Should().Contain("O");

        //}
    }
}
