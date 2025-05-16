using MathDuel.Model;
using MathDuel.View;

namespace MathDuel.Controller
{
    public class GameController
    {
        private Queue<Problem> problems;

        public GameController(string filePath)
        {
            problems = LoadProblems(filePath);
        }

        private Queue<Problem> LoadProblems(string filePath)
        {
            var list = new Queue<Problem>();
            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('=');
                if (parts.Length == 2 && int.TryParse(parts[1], out int result))
                {
                    list.Enqueue(new Problem(parts[0].Trim(), result));
                }
            }
            return list;
        }

        public void Start()
        {
            while (problems.Count > 0)
            {
                var current = problems.Dequeue();
                ConsoleView.ShowProblem(current);
                Console.Write("Resposta: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int answer))
                    ConsoleView.ShowResult(answer == current.Answer);
                else
                    Console.WriteLine("Entrada inválida!");
            }

            ConsoleView.ShowGameOver();
        }
    }
}
