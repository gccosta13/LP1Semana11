using MathDuel.Controller;

namespace MathDuel
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Por favor, indique o ficheiro de problemas como argumento.");
                return;
            }

            var game = new GameController(args[0]);
            game.Start();
        }
    }
}
