
namespace BowlingScore
{
    public class Bowling
    {
        public int GetScore(List<int> list)
        {
            if (list.Count == 0)
                return 0;

            var score = 0;
            var previousRoll = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var roll = list[i];
                if (roll + previousRoll == 10)
                {
                    score += roll + (i + 1 < list.Count ? list[i + 1] : 0);
                }
                else
                {
                    score += roll;
                }

                previousRoll = roll; ;
            }

            return score;
        }
    }
}
