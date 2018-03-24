using System;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            King mike = new King();
            General general = new General();

            Knight peter = new Knight();
            Knight paul = new Knight();
            Knight marry = new Knight();

            peter.Destroy();

            
            general.HoldSpeech(10, General.MotivationelSpeechHeld);
            
            mike.OrderSalute();
            general.GiveAttackOrder();
            
            Console.Read();
        }
    }
}
