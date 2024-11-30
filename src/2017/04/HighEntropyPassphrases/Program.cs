using HighEntropyPassphrases;

Console.WriteLine("--- Day 4: High-Entropy Passphrases ---");
var inputs = File.ReadAllLines("../../../Input.txt");
var passphrases = inputs.Select(x => new Passphrase(x));
var validPassphrases = passphrases.Count(x => x.IsValid());

Console.WriteLine("--- Part One ---");
Console.WriteLine(validPassphrases);

Console.WriteLine("--- Part Two ---");
Console.WriteLine();