namespace MathDuel.Model
{
    public class Problem
    {
        public string Expression { get; set; }
        public int Answer { get; set; }

        public Problem(string expression, int answer)
        {
            Expression = expression;
            Answer = answer;
        }
    }
}
