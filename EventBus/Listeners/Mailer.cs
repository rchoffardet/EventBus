using System;
using EventBus.Events.Contracts;

namespace EventBus.Listeners
{
    public class Mailer : Listener<Mailable>
    {
        public void Handle(Mailable payload)
        {
            Console.WriteLine(payload.ToMail() + " through mail.");
        }
    }
}