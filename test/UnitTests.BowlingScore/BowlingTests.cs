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
        bowling.Roll(5);

        // Act
        var score = bowling.GetScore();

        // Assert
        Assert.AreEqual(5, score);
    }

    [TestMethod]
    public void Given_RollsOf_5_4_GetScore_Returns_9()
    {
        // Arrange
        Bowling bowling = new Bowling();
        bowling.Roll(5);
        bowling.Roll(4);

        // Act
        var score = bowling.GetScore();

        // Assert
        Assert.AreEqual(9, score);
    }
}