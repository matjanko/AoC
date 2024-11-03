using CorruptionChecksum;

Console.WriteLine("--- Day 1: InverseCaptcha ---");
var inputs = File.ReadAllLines("../../../Input.txt");
var spreadsheet = new Spreadsheet(inputs);

Console.WriteLine("--- Part One ---");
Console.WriteLine(spreadsheet.GetChecksum());

Console.WriteLine("--- Part Two ---");
Console.WriteLine(spreadsheet.GetDivisibleChecksum());