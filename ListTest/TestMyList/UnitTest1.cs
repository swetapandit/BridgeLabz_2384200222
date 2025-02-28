using NUnit.Framework;
using ListOperation;
namespace TestMyList;

public class Tests
{
    private List1 list;
    [SetUp]
    public void Setup()
    {
        List<int> value = new List<int>();
        list = new List1(value);
    }

    [Test]
    public void TestAdd()
    {
        int val = 4;
        int expected = list.GetSize();
        list.AddElement(val);
        int actual = list.GetSize();
        Assert.AreEqual(expected+1, actual);
    }
    [Test]
    public void TestRemove()
    {
        int val = 4;
        int expected = list.GetSize();
        bool check = list.RemoveElement(val);
        int actual = list.GetSize();
        if(check) Assert.AreEqual(expected - 1, actual);
        else Assert.AreEqual(expected , actual);
    }
}
