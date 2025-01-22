string[] words =
{
    "home",
    "programming",
    "victory",
    "C#",
    "football",
    "sport",
    "book",
    "learn",
    "dream",
    "fun"
};

var ch = char.Parse(Console.ReadLine());

Console.WriteLine();

foreach (string word in words)
{
    if (word.Contains(ch))
    {
        Console.WriteLine(word);
    } else
    {
        Console.WriteLine("No match");
    }
}