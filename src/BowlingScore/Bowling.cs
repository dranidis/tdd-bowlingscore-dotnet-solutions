
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
                        + GetRoll(i + 1, list)
                        + GetRoll(i + 2, list);
                    i++;
                    frameNr++;
                    continue;
                }

                var frameScore = roll1 + list[++i];
                score += frameScore;

                if (frameScore == 10)
                {
                    score += GetRoll(i + 1, list);
                }
                i++;
                frameNr++;
            }

            return score;
        }

        private int GetRoll(int i, List<int> list)
        {
            return i < list.Count ? list[i] : 0;
        }
    }
}
