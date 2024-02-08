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
            return rolls.FirstOrDefault();
        }
    }
}
