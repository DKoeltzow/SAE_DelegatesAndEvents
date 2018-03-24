using System;

namespace DelegatesAndEvents
{
    class King
    {
        // Use the event keyword to declare an event.
        // Classes that call/raise events are called publishers,
        // classes that receive/handle events are called subscribers. 
        public delegate void OrderEventHandler();
        public static event OrderEventHandler SaluteOrdered;

        // Use EventArgs to pass arguments to subscribers.
        public delegate void SpeechEventHandler(EventArgs e);
        public static event SpeechEventHandler SpeechHeld;

        public void OrderSalute()
        {
            if (SaluteOrdered != null)
            {
                SaluteOrdered();
            }
        }

        public void HoldSpeech()
        {
            if (SpeechHeld != null)
            {
                SpeechHeld(new EventArgs());
            }
        }
    }
}
