namespace UnitTests;

using static FermatTheorem;

public class Tests
{
    [Test]
    public void TestFalseSolution()
    {
        Assert.IsFalse(FindSolution(3, 100, out int a, out int b, out int c));
    }

    [Test]
    public void TestFalseSolutions()
    {
        Assert.IsFalse(FindSolution(4, 100, out int a, out int b, out int c));
        Assert.IsFalse(FindSolution(5, 100, out a, out b, out c));
    }

    [Test]
    public void TestTrueSolution()
    {
        Assert.IsTrue(FindSolution(2, 100, out int a, out int b, out int c));
        Assert.That(a, Is.EqualTo(3));
        Assert.That(b, Is.EqualTo(4));
        Assert.That(c, Is.EqualTo(5));
    }
}