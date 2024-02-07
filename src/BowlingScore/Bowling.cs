
namespace BowlingScore
{
    public class Bowling
    {
        public int GetScore(List<int> list)
        {
            if (list.Count == 0)
                return 0;

            var score = 0;

            int i = 0;

            while (i < list.Count)
            {
                var roll1 = list[i];

                if (i + 1 >= list.Count)
                {
                    return score + roll1;
                }

                if (roll1 == 10)
                {
                    score += 10
                        + (i + 1 < list.Count ? list[i + 1] : 0)
                        + (i + 2 < list.Count ? list[i + 2] : 0);
                    i++;
                    continue;
                }

                var frame = roll1 + list[i + 1];

                if (frame == 10)
                {
                    score += 10 + (i + 2 < list.Count ? list[i + 2] : 0);
                }
                else
                {
                    score += frame;
                }
                i += 2;
            }

            return score;
        }
    }
}
