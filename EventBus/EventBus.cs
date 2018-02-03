using System;
using System.Collections.Generic;
using EventBus.Listeners;

namespace EventBus
{
    public class EventBus
    {
        private Dictionary<Type, List<object>> listeners;

        public EventBus()
        {
            listeners = new Dictionary<Type, List<object>>();
        }
        
        public void Subscribe<T>(Listener<T> listener)
        {
            var interfaceType = typeof(T);
            if (!listeners.ContainsKey(interfaceType))
            {
                listeners.Add(interfaceType, new List<object>() { listener });
            }
            else
            {
                listeners[interfaceType].Add(listener);
            }
        }
        
        public void Raise(dynamic payload)
        {
            var interfacesType = payload.GetType().GetInterfaces();

            foreach (var interfaceType in interfacesType)
            {
                if (listeners.ContainsKey(interfaceType))
                {
                    foreach (var listener in listeners[interfaceType])
                    {
                        listener.Handle(payload);
                    }
                }
            }
        }
    }
}