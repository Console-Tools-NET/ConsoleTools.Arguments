namespace DustInTheWind.ConsoleTools.Arguments;

public class Argument
{
    public string? Name { get; init; }

    public string? Value { get; set; }

    public ArgumentType Type { get; set; }

    public override string ToString()
    {
        if (Name != null && Value != null)
            return $"{Name} = {Value} [{Type}]";

        if (Name != null)
            return $"{Name} [{Type}]";

        if (Value != null)
            return $"{Value} [{Type}]";

        return $"null [{Type}]";
    }
}