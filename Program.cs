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

bool nomatch = true;

foreach (string word in words)
{
    if (word.Contains(ch))
    {
        Console.WriteLine(word);
        nomatch = false;
    }
}

if (nomatch) Console.WriteLine("No match");