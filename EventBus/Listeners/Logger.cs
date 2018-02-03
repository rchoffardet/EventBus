using System;
using EventBus.Events.Contracts;

namespace EventBus.Listeners
{
    public class Logger : Listener<Loggable>
    {
        public void Handle(Loggable payload)
        {
            Console.WriteLine(payload.ToLog() + " in log.");
        }
    }
}