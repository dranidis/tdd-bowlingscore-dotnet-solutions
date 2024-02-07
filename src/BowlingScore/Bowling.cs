
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
            int frameNr = 1;

            while (i < list.Count && frameNr <= 10)
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
                    frameNr++;
                    continue;
                }

                var frameScore = roll1 + list[i + 1];

                if (frameScore == 10)
                {
                    score += 10 + (i + 2 < list.Count ? list[i + 2] : 0);
                }
                else
                {
                    score += frameScore;
                }
                i += 2;
                frameNr++;
            }

            return score;
        }
    }
}
