


namespace BowlingScore
{
    public class Frame
    {
        private int roll1 = -1;
        private int roll2 = -1;
        private int bonus1 = -1;
        private int bonus2 = -1;

        internal void AddBonus(int pins)
        {
            if (IsSpare() && bonus1 == -1)
            {
                bonus1 = pins;
            }
            else if (IsStrike())
            {
                if (bonus1 == -1)
                {
                    bonus1 = pins;
                }
                else if (bonus2 == -1)
                {
                    bonus2 = pins;
                }
            }
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
            if (IsStrike())
            {
                return 10 + GetValue(bonus1) + GetValue(bonus2);
            }

            if (IsSpare())
            {
                return 10 + GetValue(bonus1);
            }

            return GetValue(roll1) + GetValue(roll2);

        }

        internal bool IsComplete()
        {
            return roll1 != -1 && roll2 != -1 || IsStrike();
        }

        internal bool IsSpare()
        {
            // check for [0 10]
            return IsComplete() && roll1 + roll2 == 10;
        }

        internal bool IsStrike()
        {
            return roll1 == 10;
        }

        private int GetValue(int roll)
        {
            if (roll == -1)
            {
                return 0;
            }
            return roll;
        }
    }
}
