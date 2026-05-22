using System.Collections;

namespace DustInTheWind.ConsoleTools.Arguments;

public class Arguments : IEnumerable<Argument>
{
    public string[] UnderlyingArgs { get; }

    private readonly List<Argument> arguments = new();

    public int Count => arguments.Count;

    public Argument? this[int index]
    {
        get
        {
            bool isValidIndex = index >= 0 && index < arguments.Count;

            return isValidIndex
                ? arguments[index]
                : null;
        }
    }

    public Argument? this[string name] => arguments.FirstOrDefault(x => x.Name == name);

    public Arguments(string[] args)
    {
        UnderlyingArgs = args ?? throw new ArgumentNullException(nameof(args));

        IEnumerable<Argument> newArguments = Parse(args);
        arguments.AddRange(newArguments);
    }

    private static IEnumerable<Argument> Parse(IEnumerable<string> args)
    {
        Argument? argument = null;

        foreach (Arg arg in args.Select(x => new Arg(x)))
        {
            if (arg.HasNameMarker)
            {
                if (argument != null)
                    yield return argument;

                argument = new Argument
                {
                    Name = arg.Value,
                    Type = ArgumentType.Named
                };
            }
            else
            {
                argument ??= new Argument
                {
                    Type = ArgumentType.Ordinal
                };

                argument.Value = arg.Value;

                yield return argument;
                argument = null;
            }
        }

        if (argument != null)
            yield return argument;
    }

    public Argument? GetOrdinal(int index)
    {
        return arguments
            .Where(x => x.Type == ArgumentType.Ordinal)
            .Skip(index)
            .FirstOrDefault();
    }

    public IEnumerator<Argument> GetEnumerator()
    {
        return arguments.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}