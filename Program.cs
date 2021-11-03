using BalancedExpressionsUsingStack;

BalanceExpressionChecker balanceExpressionChecker = new();

string str1 = "(( 1 + 2>";
bool isBalanced1 = balanceExpressionChecker.IsBalanced(str1);
Console.WriteLine($"Is {str1} Balanced: {isBalanced1}");

string str2 = "(( 1 + 2)<>";
bool isBalanced2 = balanceExpressionChecker.IsBalanced(str2);
Console.WriteLine($"Is {str2} Balanced: {isBalanced2}");


string str3 = "<> ([1] + 2)";
bool isBalanced3 = balanceExpressionChecker.IsBalanced(str3);
Console.WriteLine($"Is {str3} Balanced: {isBalanced3}");

string str4 = "<> (1) + (2)";
bool isBalanced4 = balanceExpressionChecker.IsBalanced(str4);
Console.WriteLine($"Is {str4} Balanced: {isBalanced4}");
