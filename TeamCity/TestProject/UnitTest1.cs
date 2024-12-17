namespace UnitTests;

using static FermatTheorem;

[TestFixture]
public class Tests
{
    [Test]
    public void TestFalseSolution()
    {
        Assert.That(FindSolution(3, 100, out int a, out int b, out int c), Is.EqualTo(false));
    }

    [Test]
    public void TestFalseSolutions()
    {
        Assert.That(FindSolution(4, 100, out int a, out int b, out int c), Is.EqualTo(false));
        Assert.That(FindSolution(5, 100, out a, out b, out c), Is.EqualTo(false));
    }

    [Test]
    public void TestTrueSolution()
    {
        Assert.That(FindSolution(2, 100, out int a, out int b, out int c), Is.EqualTo(true));
        Assert.That(a, Is.EqualTo(3));
        Assert.That(b, Is.EqualTo(4));
        Assert.That(c, Is.EqualTo(5));
    }
}