using System;

namespace DelegatesAndEvents
{
    class Knight
    {
        public Knight()
        {
            // Use the = operator to register a single method to a delegate.
            // Use the += operator to register multiple methods to a delegate.
            General.AttackOrdered += Attack;
            General.MotivationelSpeechHeld += RespondToMotivation;

            // Delegates can be implemented by anonymous methods.
            // Anonymous methods reduce code overhead when a seperate method is not needed.
            General.DemotivationalSpeechHeld += delegate(int effect) 
            { 
                Console.WriteLine("Knight lost " + effect + " motivation"); 
            };

            // Use the += operator to register methods to an event.
            King.SaluteOrdered += RespondToSaluteOrder;
        }

        void RespondToSaluteOrder()
        {
            Console.WriteLine("Strikes his sword to the air!");
        }

        private void RespondToMotivation(int effect)
        {
            Console.WriteLine("Knight got " + effect + " motivation");
        }

        private void Attack()
        {
            Console.WriteLine("I am going to attack, sir!");
        }

        public void Destroy()
        {
            // Delegates grant full access from outside the class.
            General.MotivationelSpeechHeld = null;

            // Access to events is restricted to the containing class.
            // King.SaluteOrdered = null;        <- not possible

            // Use then -= operator to unsubscribe from an event.
            General.AttackOrdered -= Attack;
            King.SaluteOrdered -= RespondToSaluteOrder;
        }
    }
}
