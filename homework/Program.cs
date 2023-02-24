string[] test1 = {"hello", "2", "world", ":-)"};
string[] test2 = {"1234", "1567", "-2", "computer science"};
string[] test3 = {"Russia", "Denmark", "Kazan"};

string[] SortStringArray(string[] test, int n)
{
    string result = string.Empty;

    for (int i = 0; i < test.Length; i ++)
        if (test[i].Length <= n) result += "," + test[i] ;

    if (result == string.Empty) return new string[0];

    return result.Substring(1).Split(',');
}

Console.Write("[" + string.Join(", ", test1) + "]" + " -> ");
Console.WriteLine("[" + string.Join(", ", SortStringArray(test1, 3)) + "]");

Console.Write("[" + string.Join(", ", test2) + "]" + " -> ");
Console.WriteLine("[" + string.Join(", ", SortStringArray(test2, 3)) + "]");

Console.Write("[" + string.Join(", ", test3) + "]" + " -> ");
Console.WriteLine("[" + string.Join(", ", SortStringArray(test3, 3)) + "]");