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
    [DataRow(new int[] { 3, 5, 5, 2 }, 15)]
    [DataRow(new int[] { 10, 5, 2 }, 24)]
    [DataRow(new int[] { 10, 5 }, 20)]
    [DataRow(new int[] { 10, 5, 5, 5, 5, 3, 2 }, 20 + 15 + 13 + 5)]
    [DataRow(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, 300)]
    [DataRow(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 5, 5, 10 },
    210 + 25 + 20 + 20)]
    [DataRow(new int[] {
            5,5,5,5,5,5,5,5,5,5,
            5,5,5,5,5,5,5,5,5,5,
            5
        }, 150)]
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