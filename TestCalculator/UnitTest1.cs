using Calculator;
using NUnit.Framework;

namespace TestCalculator;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestAdd()
    {
        Operation operation = new Operation(10, 2);
        int expected = 12;
        int actual = operation.Add();
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void TestSub()
    {
        Operation operation = new Operation(10, 2);
        int expected = 8;
        int actual = operation.Subtract();
        Assert.AreEqual(expected, actual);

    }
    [Test]
    public void TestMul()
    {
        Operation operation = new Operation(10, 2);
        int expected = 20;
        int actual = operation.Multiply();
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void TestDiv()
    {
        Operation operation = new Operation(10, 2);
        int expected = 5;
        int actual = operation.Divide();
        Assert.AreEqual(expected, actual);
    }
}
