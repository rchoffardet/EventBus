using System;
using EventBus.Events;
using EventBus.Events.Contracts;
using EventBus.Listeners;

namespace EventBus
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = new EventBus();
            
            bus.Subscribe<Loggable>(new Logger());
            bus.Subscribe<Loggable>(new AnotherLogger());
            bus.Subscribe<Mailable>(new Mailer());
            
            bus.Raise(new Event("I am an event"));
            
            Console.ReadLine();
        }
    }
}