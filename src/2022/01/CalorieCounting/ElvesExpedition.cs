namespace CalorieCounting;

internal class Expedition(string[] inputs)
{
    private IReadOnlyList<Elf> Elves { get; } = CreateElves(inputs).ToList();

    public int MaxCalories => Elves.Max(x => x.Calories);
    public int ThreeHighestCaloriesSum => Elves.OrderByDescending(x => x.Calories).Take(3).Sum(x => x.Calories);

    private static IEnumerable<Elf> CreateElves(string[] inputs)
    {
        var calories = 0;
        foreach (var input in inputs)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                yield return CreateElf(calories);
                calories = 0;
            }
            else
            {
                calories += int.Parse(input);
            }
        }

        if (calories > 0)
        {
            yield return CreateElf(calories);
        }
    }

    private static Elf CreateElf(int calories) => new(calories);
}