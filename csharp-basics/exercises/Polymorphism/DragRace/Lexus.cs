using System;

namespace DragRace
{
    public class Lexus : Car, IBoost
    {
        public int Boost { get; private set; }

        public Lexus(int speed) : base(speed)
        {
            Boost = 10;
        }

        public void UseNitrousOxideEngine()
        {
            CurrentSpeed += Boost;
        }
    }
}