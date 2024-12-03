namespace MullItOver;

internal class Instruction(string input)
{
    private readonly int _numberOne = ParseToNumber(input, 0);
    private readonly int _numberTwo = ParseToNumber(input, 1);

    public int Result => _numberOne * _numberTwo;
    private static int ParseToNumber(string input, int index)
    {
        return int.Parse(input.Replace("mul(", "").Replace(")", "").Split(",")[index]);
    }
}