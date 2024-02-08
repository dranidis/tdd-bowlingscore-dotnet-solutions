using System.ComponentModel;
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
    [DataRow(new int[] { 5 }, 5)]
    [DataRow(new int[] { 5, 4 }, 9)]
    [DataRow(new int[] { 5, 4, 3 }, 12)]
    [DataRow(new int[] { 5, 5 }, 10, DisplayName = "Spare with no next roll yet")]
    [DataRow(new int[] { 5, 5, 3 }, 16, DisplayName = "Spare")]
    [DataRow(new int[] { 3, 5, 5, 2 }, 15, DisplayName = "No Spare, different frames")]
    [DataRow(new int[] { 10, 5, 1 }, 22, DisplayName = "Strikes two bonus rolls")]
    [DataRow(new int[] { 10, 10, 10 }, 30 + 20 + 10, DisplayName = "Three strikes in a row")]
    [DataRow(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, 300, DisplayName = "Perfect game")]


    public void Given_SomeRolls_Returns_TheCorrectScore(int[] rolls, int expected)
    {
        // Arrange
        var bowling = new Bowling();
        foreach (var roll in rolls)
        {
            bowling.Roll(roll);
        }

        // Act
        var result = bowling.GetScore();

        // Assert
        Assert.AreEqual(expected, result);
    }
}