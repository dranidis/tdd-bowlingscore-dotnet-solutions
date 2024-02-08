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
    [DataRow(new int[] { 5, 5, 3 }, 16, DisplayName = "Spare")]

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