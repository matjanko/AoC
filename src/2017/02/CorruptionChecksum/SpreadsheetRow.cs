namespace CorruptionChecksum;

internal class SpreadsheetRow(IReadOnlyList<int> numbers)
{
    private int GetLargestValue() => numbers.Max();
    private int GetSmallestValue() => numbers.Min();

    public int GetDifference() => GetLargestValue() - GetSmallestValue();

    public int GetDivision()
    {
        foreach (var x in numbers)
        {
            foreach (var y in numbers)
            {
                if (x != 0 && x != y && x % y == 0)
                {
                    return x / y;
                }
            }
        }

        throw new InvalidOperationException("No divisible pair found in the list.");
    }
}