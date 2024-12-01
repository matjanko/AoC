namespace HistorianHysteria;

internal class LocationsPair(int locationLeft, int locationRight)
{
    public int GetDistanceBetweenLocations() => Math.Abs(locationLeft - locationRight);
}