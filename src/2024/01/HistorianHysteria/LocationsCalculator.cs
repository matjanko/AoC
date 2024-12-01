namespace HistorianHysteria;

internal class LocationsCalculator(string[] inputs)
{
    private readonly IReadOnlyList<int> _leftLocationIds = PaseLocationIds(inputs, 0);
    private readonly IReadOnlyList<int> _rightLocationIds = PaseLocationIds(inputs, 1);

    public int CalculatePartOne()
    {
        var sortedLeftLocationIds = _leftLocationIds.OrderByDescending(x => x).ToList();
        var sortedRightLocationIds = _rightLocationIds.OrderByDescending(x => x).ToList();

        return sortedLeftLocationIds
            .Zip(sortedRightLocationIds, (leftId, rightId) => new LocationsPair(leftId, rightId))
            .Sum(pair => pair.GetDistanceBetweenLocations());
    }

    public int CalculatePartTwo()
    {
        return _leftLocationIds
            .Select(locationId => locationId * _rightLocationIds.Count(x => x == locationId))
            .Sum();
    }

    private static IReadOnlyList<int> PaseLocationIds(string[] inputs, int index)
    {
        return inputs
            .Select(input => input.Split("   ")[index])
            .Select(int.Parse)
            .ToList();
    }
}