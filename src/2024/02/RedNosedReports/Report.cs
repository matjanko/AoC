namespace RedNosedReports;

public class Report(string input)
{
    private readonly IReadOnlyList<int> _levels = input.Split(" ").Select(int.Parse).ToList();

    public bool IsSave()
    {
        return IsAllIncreasing(_levels) || IsAllDecreasing(_levels);
    }

    public bool IsSaveWithSingleBadLevel()
    {
        var isSave = IsAllIncreasing(_levels) || IsAllDecreasing(_levels);
        if (isSave)
        {
            return true;
        }

        for (var i = 0; i < _levels.Count; i++)
        {
            var levels = new List<int>(_levels);
            levels.RemoveAt(i);
            isSave = IsAllIncreasing(levels) || IsAllDecreasing(levels);
            if (isSave)
            {
                return true;
            }
        }
        return false;
    }

    private static bool IsAllIncreasing(IReadOnlyList<int> levels)
    {
        return levels
            .Zip(levels.Skip(1), (current, next) => next - current)
            .All(delta => delta is > 0 and <= 3);
    }

    private static bool IsAllDecreasing(IReadOnlyList<int> levels)
    {
        return levels
            .Zip(levels.Skip(1), (current, next) => current - next)
            .All(delta => delta is > 0 and <= 3);
    }
}