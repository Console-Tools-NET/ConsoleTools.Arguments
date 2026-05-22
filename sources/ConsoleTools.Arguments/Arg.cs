namespace DustInTheWind.ConsoleTools.Arguments;

internal class Arg
{
    public bool HasNameMarker { get; }

    public string? Value { get; }

    public Arg(string value)
    {
        HasNameMarker = value?.StartsWith("-") ?? false;
        Value = value?.TrimStart('-');
    }
}