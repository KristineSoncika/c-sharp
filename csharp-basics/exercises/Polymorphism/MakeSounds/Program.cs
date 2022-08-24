using System;

namespace MakeSounds
{
    class Program
    {
        private static void Main()
        {
            List<ISound> sounds = new();
            sounds.Add(new Firework());
            sounds.Add(new Parrot());
            sounds.Add(new Parrot());
            sounds.Add(new Radio());
            sounds.Add(new Firework());

            foreach(var sound in sounds)
            {
                sound.PlaySound();
            }
        }
    }
}