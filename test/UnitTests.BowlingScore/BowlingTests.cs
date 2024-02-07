using BowlingScore;

namespace UnitTests.BowlingScore;

[TestClass]
public class BowlingTests
{
    [TestMethod]
    public void GetScore_Returns_0_Given_EmptyList()
    {
        // Arrange
        var bowling = new Bowling();

        // Act
        var result = bowling.GetScore(new List<int>());

        // Assert
        Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetScore_Returns_5_Given_Rolls_5()
    {
        // Arrange
        var bowling = new Bowling();

        // Act
        var result = bowling.GetScore([5]);

        // Assert
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void GetScore_Returns_9_Given_Rolls_5_4()
    {
        // Arrange
        var bowling = new Bowling();

        // Act
        var result = bowling.GetScore([5, 4]);

        // Assert
        Assert.AreEqual(9, result);
    }
}