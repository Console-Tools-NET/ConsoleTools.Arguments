using FluentAssertions;

namespace DustInTheWind.ConsoleTools.Arguments.Tests.ArgumentsTests;

public class Constructor_TwoOrdinalArgumentsTests
{
    private readonly Arguments arguments;

    public Constructor_TwoOrdinalArgumentsTests()
    {
        string[] args = { "param1", "param2" };

        arguments = new Arguments(args);
    }

    [Fact]
    public void HavingArgsStringWithTwoOrdinalArguments_WhenParsed_ThenArgumentsContainsTwoItems()
    {
        arguments.Count.Should().Be(2);
    }

    [Fact]
    public void HavingArgsStringWithTwoOrdinalArguments_WhenParsed_ThenSecondArgumentHasTypeOrdinal()
    {
        arguments[1].Type.Should().Be(ArgumentType.Ordinal);
    }

    [Fact]
    public void HavingArgsStringWithOneOrdinalArgument_WhenParsed_ThenSecondArgumentHasNullName()
    {
        arguments[1].Name.Should().BeNull();
    }

    [Fact]
    public void HavingArgsStringWithOneOrdinalArgument_WhenParsed_ThenSecondArgumentHasCorrectValue()
    {
        arguments[1].Value.Should().Be("param2");
    }
}