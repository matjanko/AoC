using CalorieCounting;

Console.WriteLine("--- Day 1: Calorie Counting ---");
var inputs = File.ReadAllLines("../../../Input.txt");
var elves = new ElvesFactory(inputs).CreateElves().ToList();
var maxCalories = elves.Max(x => x.Calories);

Console.WriteLine("--- Part One ---");
Console.WriteLine(maxCalories);

Console.WriteLine("--- Part Two ---");
var calories = elves.OrderByDescending(x => x.Calories).Take(3).Sum(x => x.Calories);
Console.WriteLine(calories);