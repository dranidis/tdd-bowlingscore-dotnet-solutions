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
            if (rolls.Count == 0)
                return 0;

            if (rolls.Count == 1)
                return rolls.First();

            return rolls.First() + rolls.Last();
        }
    }
}
