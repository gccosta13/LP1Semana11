using MathDuel.Model;

namespace MathDuel.View
{
    public static class ConsoleView
    {
        public static void ShowProblem(Problem problem)
        {
            Console.WriteLine($"Problema: {problem.Expression}");
        }

        public static void ShowResult(bool correct)
        {
            Console.WriteLine(correct ? "Correto!" : "Errado!");
        }

        public static void ShowGameOver()
        {
            Console.WriteLine("Fim do jogo! Sem mais problemas.");
        }
    }
}
