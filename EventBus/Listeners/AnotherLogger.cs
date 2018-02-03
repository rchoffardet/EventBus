using System;
using EventBus.Events.Contracts;

namespace EventBus.Listeners
{
    public class AnotherLogger : Listener<Loggable>
    {
        public void Handle(Loggable payload)
        {
            Console.WriteLine(payload.ToLog() + " in another log.");
        }
    }
}