using EventBus.Events.Contracts;

namespace EventBus.Events
{
    public class Event : Loggable, Mailable
    {
        private string payload;
        
        public Event(string payload)
        {
            this.payload = payload;
        }
        
        public string ToLog()
        {
            return payload;
        }

        public string ToMail()
        {
            return payload;
        }
    }
}