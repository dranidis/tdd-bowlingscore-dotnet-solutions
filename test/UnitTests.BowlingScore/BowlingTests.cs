using BowlingScore;

namespace UnitTests.BowlingScore;

[TestClass]
public class BowlingTests
{
    [TestMethod]
    public void Given_NoRolls_GetScore_Returns_0()
    {
        Bowling bowling = new Bowling();

        var score = bowling.GetScore();

        Assert.AreEqual(0, score);
    }
}