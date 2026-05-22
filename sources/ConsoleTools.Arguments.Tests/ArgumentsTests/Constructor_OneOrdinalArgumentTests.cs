using FluentAssertions;

namespace DustInTheWind.ConsoleTools.Arguments.Tests.ArgumentsTests;

public class Constructor_OneOrdinalArgumentTests
{
    private readonly Arguments arguments;

    public Constructor_OneOrdinalArgumentTests()
    {
        string[] args = { "param1" };

        arguments = new Arguments(args);
    }

    [Fact]
    public void HavingArgsStringWithOneOrdinalArgument_WhenParsed_ThenArgumentsContainsOneItem()
    {
        arguments.Count.Should().Be(1);
    }

    [Fact]
    public void HavingArgsStringWithOneOrdinalArgument_WhenParsed_ThenArgumentHasTypeOrdinal()
    {
        arguments[0].Type.Should().Be(ArgumentType.Ordinal);
    }

    [Fact]
    public void HavingArgsStringWithOneOrdinalArgument_WhenParsed_ThenArgumentHasNullName()
    {
        arguments[0].Name.Should().BeNull();
    }

    [Fact]
    public void HavingArgsStringWithOneOrdinalArgument_WhenParsed_ThenArgumentHasCorrectValue()
    {
        arguments[0].Value.Should().Be("param1");
    }
}