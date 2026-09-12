/******************************************************************************
 * Filename    = UnitTest1.cs
 *
 * Author      = Adwaith Nath R
 * 
 * Project     = UnitTestParcelDeliveryCalculator
 *
 * Description = Unit tests for the parcel delivery calculator.
 *****************************************************************************/

using ParcelDeliveryCalculator;

namespace UnitTestParcelDeliveryCalculator;

[TestClass]
public class DeliveryCalculatorTest
{
    DeliveryCalculator _deliveryCalculator = new DeliveryCalculator();

    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForQuoteForStandardDelivery()
    {
        StandardDelivery standardDelivery = new StandardDelivery();
        decimal weight = 300;
        decimal distance = 600;
        decimal costPerDay = _deliveryCalculator.Quote(standardDelivery, weight, distance);

        Assert.AreEqual(costPerDay, 300);
    }

    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForQuoteForExpressDelivery()
    {
        ExpressDelivery expressDelivery = new ExpressDelivery();
        decimal weight = 10;
        decimal distance = 800;
        decimal costPerDay = _deliveryCalculator.Quote(expressDelivery, weight, distance);

        Assert.AreEqual(costPerDay, 50);
    }

    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForQuoteForSameDayDelivery()
    {
        SameDayDelivery sameDayDelivery = new SameDayDelivery();
        decimal weight = 40;
        decimal distance = 140;
        decimal costPerDay = _deliveryCalculator.Quote(sameDayDelivery, weight, distance);

        Assert.AreEqual(costPerDay, 600);
    }

    // Quote method returns -1 if there is any Exception
    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForQuoteForNegativeWeight()
    {
        StandardDelivery standardDelivery = new StandardDelivery();
        decimal weight = -400;
        decimal distance = 600;
        decimal costPerDay = _deliveryCalculator.Quote(standardDelivery, weight, distance);

        Assert.AreEqual(costPerDay, -1);
    }

    // Quote method returns -1 if there is any Exception
    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForQuoteForNegativeDistance()
    {
        StandardDelivery standardDelivery = new StandardDelivery();
        decimal weight = 300;
        decimal distance = -600;
        decimal costPerDay = _deliveryCalculator.Quote(standardDelivery, weight, distance);

        Assert.AreEqual(costPerDay, -1);
    }

    // Quote method returns -1 if there is any Exception
    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForQuoteForDivisionByZero()
    {
        SameDayDelivery sameDayDelivery = new SameDayDelivery();
        decimal weight = 40;
        decimal distance = 400;
        decimal costPerDay = _deliveryCalculator.Quote(sameDayDelivery, weight, distance);

        Assert.AreEqual(costPerDay, -1);
    }

    // Quote method returns -1 if there is any Exception
    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForQuoteForNull()
    {
        SameDayDelivery sameDayDelivery = null;
        decimal weight = 40;
        decimal distance = 400;
        decimal costPerDay = _deliveryCalculator.Quote(sameDayDelivery, weight, distance);

        Assert.AreEqual(costPerDay, -1);
    }

}

[TestClass]
public class StandardDeliveryTests
{
    StandardDelivery _standardDelivery = new StandardDelivery();

    // CalculatePrice should return weight * 30
    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForPrice()
    {
        decimal weight = 30;
        decimal price = _standardDelivery.CalculatePrice(weight);
        Assert.AreEqual(price, 300);

    }

    // EstimateTime should return distance / 60
    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForEstimateTime()
    {
        decimal distance = 600;
        TimeSpan time = _standardDelivery.EstimateTime(distance);
        Assert.AreEqual(time, TimeSpan.FromHours(10));
    }

}

[TestClass]
public class ExpressDeliveryTests
{
    ExpressDelivery _expressDelivery = new ExpressDelivery();

    // CalculatePrice should return weight * 50
    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForPrice()
    {
        decimal weight = 10;
        decimal price = _expressDelivery.CalculatePrice(weight);
        Assert.AreEqual(price, 500);

    }

    // EstimateTime should return distance / 80
    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForEstimateTime()
    {
        decimal distance = 800;
        TimeSpan time = _expressDelivery.EstimateTime(distance);
        Assert.AreEqual(time, TimeSpan.FromHours(10));
    }
}

[TestClass]
public class SameDayDeliveryTests
{
    SameDayDelivery _sameDayDelivery = new SameDayDelivery();

    // CalculatePrice should return weight * 30
    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForPrice()
    {
        decimal weight = 40;
        decimal price = _sameDayDelivery.CalculatePrice(weight);
        Assert.AreEqual(price, 1200);

    }

    // EstimateTime should return distance / 70
    [TestMethod]
    [Owner("Adwaith Nath")]
    [Priority(1)]
    public void TestForEstimateTime()
    {
        decimal distance = 140;
        TimeSpan time = _sameDayDelivery.EstimateTime(distance);
        Assert.AreEqual(time, TimeSpan.FromHours(2));
    }
}

