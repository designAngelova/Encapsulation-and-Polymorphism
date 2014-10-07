using System;

namespace Game.Interfaces
{
    public interface ITimeoutable
    {
        int Timeout { get; set; }
        int Countdown { get; set; }
        bool HasTimedOut { get; set; }
    }
}
