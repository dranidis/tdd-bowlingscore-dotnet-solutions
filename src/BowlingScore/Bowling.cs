
namespace BowlingScore
{
    public class Bowling
    {
        public int GetScore(List<int> list)
        {
            if (list.Count == 0)
                return 0;

            var score = 0;
            foreach (var roll in list)
            {
                score += roll;
            }

            return score;
        }
    }
}
