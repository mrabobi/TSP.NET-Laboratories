using System;


namespace CustomEvent
{
    class Raising
    {
        public event EventHandler<MeetingEvent> RaiseEvent;

        public void CustomEventFct() => OnRaiseCustomEvent(new MeetingEvent("My first custom event"));

        protected virtual void OnRaiseCustomEvent(MeetingEvent e)
        {
            EventHandler<MeetingEvent> handler = RaiseEvent;

            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
