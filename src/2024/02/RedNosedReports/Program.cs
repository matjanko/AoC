using RedNosedReports;

Console.WriteLine("--- Day 2: Red-Nosed Reports ---");
var inputs = File.ReadAllLines("../../../Input.txt");
var reports = inputs.Select(x => new Report(x)).ToList();
var saveReportsCount = reports.Count(x => x.IsSave());

Console.WriteLine("--- Part One ---");
Console.WriteLine(saveReportsCount);

saveReportsCount = reports.Count(x => x.IsSaveWithSingleBadLevel());
Console.WriteLine("--- Part Two ---");
Console.WriteLine(saveReportsCount);