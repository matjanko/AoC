namespace CalorieCounting;

internal class ElvesFactory(string[] inputs)
{
    public IEnumerable<Elf> CreateElves()
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