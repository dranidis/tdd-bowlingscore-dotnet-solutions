

namespace BowlingScore
{
    public class Frame
    {
        private int roll1 = -1;
        private int roll2 = -1;
        private int bonus1 = -1;

        internal void AddBonus(int pins)
        {
            bonus1 = pins;
        }

        internal void AddRoll(int pins)
        {
            if (roll1 == -1)
            {
                roll1 = pins;
            }
            else
            {
                roll2 = pins;
            }
        }

        internal int GetScore()
        {
            if (roll1 == -1)
            {
                return 0;
            }

            if (roll2 == -1)
            {
                return roll1;
            }

            if (bonus1 != -1)
            {
                return roll1 + roll2 + bonus1;
            }

            return roll1 + roll2;
        }

        internal bool IsComplete()
        {
            return roll1 != -1 && roll2 != -1;
        }

        internal bool IsSpare()
        {
            return IsComplete() && roll1 + roll2 == 10;
        }
    }
}
