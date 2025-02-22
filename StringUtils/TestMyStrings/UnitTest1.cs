using MyStrings;
using NUnit.Framework;
namespace TestMyStrings;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestReverse()
    {
        StringClass stringClass = new StringClass();
        string expected = "racecar";
        string actual = stringClass.Reverse("racecar");
        Assert.AreEqual(expected, actual);
    }
    [Test]
    //for True
    public void TestIsPalindromeT()
    {
        StringClass stringClass = new StringClass();
        bool expected = true;
        bool actual = stringClass.IsPalindrome("racecar");
        Assert.AreEqual(expected, actual);
    }
    [Test]
    //for False
    public void TestIsPalindromeF()
    {
        StringClass stringClass = new StringClass();
        bool expected = false;
        bool actual = stringClass.IsPalindrome("raceca");
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public void TestToUpperCase()
    {
        StringClass stringClass = new StringClass();
        string expected = "RACECAR";
        string actual = stringClass.ToUpperCase("racecar");
        Assert.AreEqual(expected, actual);
    }
}