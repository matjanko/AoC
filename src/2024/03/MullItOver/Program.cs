using System.Text.RegularExpressions;
using MullItOver;

Console.WriteLine("--- Day 3: Mull It Over ---");
var input = File.ReadAllText("../../../Input.txt");
var instructions = ParseInstructions(input).ToList();
var result = instructions.Sum(x => x.Result);

Console.WriteLine("--- Part One ---");
Console.WriteLine(result);

var correctInput = Regex.Replace(input, @"don't\(.*?do\(\)", "", RegexOptions.Singleline);
instructions = ParseInstructions(correctInput).ToList();
result = instructions.Sum(x => x.Result);

Console.WriteLine("--- Part Two ---");
Console.WriteLine(result);

return;


static IEnumerable<Instruction> ParseInstructions(string input)
{
    return Regex.Matches(input, @"mul\(\d+,\s*\d+\)").Select(x => new Instruction(x.Value));
}