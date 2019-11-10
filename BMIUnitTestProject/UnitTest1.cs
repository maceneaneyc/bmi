using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMICalculator;
using System;

namespace BMIUnitTestProject
{
    [TestClass]
    public class UnitTestBMICategory
    {
        [TestMethod]
        public void TestUnderweightBMICategoryMethod()
        {
            //Arrange
            BMI bmi = new BMI() { WeightStones = 6, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            int expectedResult = 0;

            //Act
            int actualResult = Convert.ToInt32(bmi.BMICategory);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
        [TestMethod]
        public void TestNormalBMICategoryMethod()
        {
            //Arrange
            BMI bmi = new BMI() { WeightStones = 12, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            int expectedResult = 1;

            //Act
            int actualResult = Convert.ToInt32(bmi.BMICategory);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestOverweightBMICategoryMethod()
        {
            //Arrange
            BMI bmi = new BMI() { WeightStones = 14, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            int expectedResult = 2;

            //Act
            int actualResult = Convert.ToInt32(bmi.BMICategory);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestMethod]
        public void TestObeseBMICategoryMethod()
        {
            //Arrange
            BMI bmi = new BMI() { WeightStones = 16, WeightPounds = 0, HeightFeet = 5, HeightInches = 10 };
            int expectedResult = 3;

            //Act
            int actualResult = Convert.ToInt32(bmi.BMICategory);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
