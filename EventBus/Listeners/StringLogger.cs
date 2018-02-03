using System;

namespace EventBus.Listeners
{
    public class StringLogger : Listener<string>
    {
        public void Handle(string payload)
        {
            Console.WriteLine(payload);
        }
    }
}