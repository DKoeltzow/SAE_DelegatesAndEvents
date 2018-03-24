using System;

namespace DelegatesAndEvents
{
    class General
    {
        // A delegate is a type that is used to reference a method with a specific signature.
        // In the context of delegates, the signature includes the return value.
        // Delegates are ideal for callback methods.
        public delegate void OrderEventHandler();
        public static OrderEventHandler AttackOrdered;

        public delegate void SpeechEventHandler(int effect);
        public static SpeechEventHandler MotivationelSpeechHeld;
        public static SpeechEventHandler DemotivationalSpeechHeld;

        public void GiveAttackOrder()
        {
            // Check a delegate for null to avoid null reference exceptions.
            if (AttackOrdered != null)
            {
                AttackOrdered();
            }
        }

        // Delegates can be used as arguments.
        public void HoldSpeech(int number, SpeechEventHandler speechCallback)
        {
            if (speechCallback != null)
            {
                speechCallback(number);
            }
        }

    }
}
