using System;

namespace GamblerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom Gambling Stimulation Progarm \n");
            
            Game game = new Game();

            game.GamblerWinOrLoss();

        }
    }
}
