using System;

namespace DragRace
{
    public class Bmw : Car, IBoost
    {
        public int Boost { get; private set; }

        public Bmw(int speed) : base(speed)
        {
            Boost = 10;
        }

        public void UseNitrousOxideEngine()
        {
            CurrentSpeed += Boost;
        }
    }
}