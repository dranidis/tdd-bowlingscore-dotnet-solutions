using System.Runtime.InteropServices;

namespace BowlingScore
{
    public class Bowling
    {
        private readonly List<int> rolls = [];

        public void Roll(int pins)
        {
            rolls.Add(pins);
        }

        public int GetScore()
        {
            var score = 0;
            var previousRoll = 0;
            for (var i = 0; i < rolls.Count; i++)
            {
                if (rolls[i] + previousRoll == 10)
                {
                    score += rolls[i] + rolls[i + 1];
                }
                else
                {
                    score += rolls[i];
                }
                previousRoll = rolls[i];
            }

            return score;
        }
    }
}
