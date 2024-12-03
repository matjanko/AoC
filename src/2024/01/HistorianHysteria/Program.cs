using HistorianHysteria;

Console.WriteLine("--- Day 1: Historian Hysteria ---");
var inputs = File.ReadAllLines("../../../Input.txt");
var calculator = new LocationsCalculator(inputs);

Console.WriteLine("--- Part One ---");
Console.WriteLine(calculator.CalculatePartOne());

Console.WriteLine("--- Part Two ---");
Console.WriteLine(calculator.CalculatePartTwo());