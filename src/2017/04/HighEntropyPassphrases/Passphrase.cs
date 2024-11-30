namespace HighEntropyPassphrases;

public class Passphrase(string input)
{
    private readonly IReadOnlyList<string> _words = input.Split(" ");

    public bool IsValid() => !_words.Where((t1, i) => _words.Where((t2, j) => i != j).Any(t => t1 == t)).Any();
}