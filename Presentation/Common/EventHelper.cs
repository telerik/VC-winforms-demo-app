using System;

namespace Presentation.Common
{
    public class EventHelper
    {
        public static void RaiseEvent(Object objectRaisingEvent,
                                      EventHandler<AccessTypeEventArgs> eventHandlerRaised,
                                      AccessTypeEventArgs accessTypeEventArgs)
        {
            eventHandlerRaised?.Invoke(objectRaisingEvent, accessTypeEventArgs); //Notify all subscribers
        }

        public static void RaiseEvent(Object objectRaisingEvent,
                                      EventHandler eventHandlerRaised,
                                      EventArgs eventArgs)
        {
            eventHandlerRaised?.Invoke(objectRaisingEvent, eventArgs); //Notify all subscribers
        }
    }
}
