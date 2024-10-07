using CalorieCounting;

Console.WriteLine("--- Day 1: Calorie Counting ---");
var inputs = File.ReadAllLines("../../../Input.txt");
var expedition = new Expedition(inputs);

Console.WriteLine("--- Part One ---");
Console.WriteLine(expedition.MaxCalories.ToString());

Console.WriteLine("--- Part Two ---");
Console.WriteLine(expedition.ThreeHighestCaloriesSum);