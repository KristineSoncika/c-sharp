using System;

namespace DragRace
{
    public class Car : ICar
    {
        public int CurrentSpeed { get; protected set; }
        public int SpeedChange { get; protected set; }
        public static readonly List<Car> Cars = new();

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

        public string ShowCurrentSpeed()
        {
            return CurrentSpeed.ToString();
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