using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace BowlingScore
{
    public class Bowling
    {
        private readonly List<int> rolls = [];
        private Frame currentFrame = new();
        private Frame previousFrame;
        private Frame previousFrame2;
        private readonly List<Frame> frames = [];

        public Bowling()
        {
            frames.Add(currentFrame);
        }

        public void Roll(int pins)
        {
            currentFrame.AddRoll(pins);

            if (previousFrame != null && (previousFrame.IsSpare() || previousFrame.IsStrike()))
            {
                previousFrame.AddBonus(pins);
            }

            if (previousFrame2 != null && previousFrame2.IsStrike())
            {
                previousFrame2.AddBonus(pins);
            }

            if (currentFrame.IsComplete())
            {
                previousFrame2 = previousFrame;
                previousFrame = currentFrame;
                currentFrame = new();
                frames.Add(currentFrame);
            }
        }

        public int GetScore()
        {
            return frames.Sum(f => f.GetScore());
        }
    }
}
