namespace CorruptionChecksum;

internal class Spreadsheet
{
    private readonly IReadOnlyList<SpreadsheetRow> _rows;

    public Spreadsheet(string[] inputs)
    {
        _rows = inputs
            .Select(x => new SpreadsheetRow(x.Split('\t').Select(int.Parse).ToList()))
            .ToList();
    }

    public int GetChecksum() => _rows.Select(x => x.GetDifference()).Sum();
    public int GetDivisibleChecksum() => _rows.Select(x => x.GetDivision()).Sum();
}