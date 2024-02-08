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

    [TestMethod]
    public void Given_OneRollOf5_GetScore_Returns_5()
    {
        // Arrange
        Bowling bowling = new Bowling();

        // Act
        bowling.Roll(5);
        var score = bowling.GetScore();

        // Assert
        Assert.AreEqual(5, score);
    }
}