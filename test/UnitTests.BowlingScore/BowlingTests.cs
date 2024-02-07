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
    [DataRow(new int[] { 5 }, 5)]
    [DataRow(new int[] { 5, 4 }, 9)]
    [DataRow(new int[] { 5, 4, 3 }, 12)]
    [DataRow(new int[] { 5, 5, 3 }, 16)]
    [DataRow(new int[] { 5, 5 }, 10)]
    public void GetScore_Returns_Expected_Given_Rolls(int[] rolls, int expected)
    {
        // Arrange
        var bowling = new Bowling();

        // Act
        var result = bowling.GetScore([.. rolls]);

        // Assert
        Assert.AreEqual(expected, result);
    }
}