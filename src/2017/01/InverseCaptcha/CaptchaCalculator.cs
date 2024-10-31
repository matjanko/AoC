namespace InverseCaptcha;

internal class CaptchaCalculator(IReadOnlyList<int> numbers)
{
    public int Calculate(bool? halfway = false)
    {
        var s = halfway == true ? numbers.Count / 2 : 1;
        return numbers
            .Where((number, i) => number == numbers[(i + s) % numbers.Count])
            .Sum();
    }
}