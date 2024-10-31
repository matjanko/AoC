using InverseCaptcha;

Console.WriteLine("--- Day 1: InverseCaptcha ---");
var input = File.ReadAllText("../../../Input.txt");
var numbers = input.Select(x => int.Parse(x.ToString())).ToList();
var calculator = new CaptchaCalculator(numbers);

Console.WriteLine("--- Part One ---");
Console.WriteLine(calculator.Calculate());

Console.WriteLine("--- Part Two ---");
Console.WriteLine(calculator.Calculate(halfway: true));