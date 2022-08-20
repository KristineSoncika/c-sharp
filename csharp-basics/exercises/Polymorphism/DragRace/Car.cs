using System;

namespace DragRace
{
    public abstract class Car : ICar
    {
        public int CurrentSpeed { get; protected set; }
        protected int SpeedChange;

        public Car(int speed)
        {
            CurrentSpeed = 0;
            SpeedChange = speed;
        }

        public void SpeedUp()
        {
            CurrentSpeed += SpeedChange;
        }

        public void SlowDown()
        {
            CurrentSpeed -= SpeedChange;
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}