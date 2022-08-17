using System;

namespace DragRace
{
    public class Tesla : Car
    {
        public Tesla(int speed) : base(speed)
        {
        }

        public override void StartEngine()
        {
            Console.WriteLine("-- silence ---");
        }
    }
}