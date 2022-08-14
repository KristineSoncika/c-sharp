using System;

namespace Exercise_12
{
    interface IStudent
    {
        string[] TestsTaken { get; }
        void TakeTest(Testpaper paper, string[] answers);
    }
}