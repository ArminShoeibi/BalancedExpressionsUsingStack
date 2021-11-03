namespace BalancedExpressionsUsingStack;

public class BalanceExpressionChecker
{
    private readonly List<char> leftBrackets = new() { '(', '[', '<', '{' };
    private readonly List<char> rightBrackets = new() { ')', ']', '>', '}' };
    public bool IsBalanced(string input)
    {
        Stack<char> stack = new();
        foreach (char ch in input)
        {
            if (IsLeftBracket(ch))
                stack.Push(ch);
            if (IsRightBracket(ch))
            {
                if (stack.Count == 0) return false;

                char top = stack.Pop();
                if (BracketsMatch(top, ch) is false) return false;
            }

        }
        return stack.Count == 0;

        bool IsLeftBracket(char ch) => leftBrackets.Contains(ch);
        bool IsRightBracket(char ch) => rightBrackets.Contains(ch);
        bool BracketsMatch(char left, char right) => leftBrackets.IndexOf(left) == rightBrackets.IndexOf(right);
    }
}
