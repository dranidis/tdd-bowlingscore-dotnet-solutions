
namespace BowlingScore
{
    public class Bowling
    {
        public int GetScore(List<int> list)
        {
            if (list.Count == 0)
                return 0;

            if (list.Count == 1)
                return list.FirstOrDefault();

            return list.First() + list.Last();
        }
    }
}
