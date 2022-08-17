using System;

namespace DragRace
{
    interface ICar
    {
        int CurrentSpeed { get; }
        void SpeedUp();
        void SlowDown();
        string ShowCurrentSpeed();
        void StartEngine();
    }
}