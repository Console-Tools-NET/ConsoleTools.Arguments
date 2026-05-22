using FluentAssertions;

namespace DustInTheWind.ConsoleTools.Arguments.Tests.ArgumentsTests;

public class Constructor_OneNamedArgumentTests
{
    private readonly ConsoleTools.Arguments.Arguments arguments;

    public Constructor_OneNamedArgumentTests()
    {
        string[] args = { "-param1", "value1" };

        arguments = new Arguments(args);
    }

    [Fact]
    public void HavingArgsStringWithOneNamedArgument_WhenParsed_ThenArgumentsContainsOneItem()
    {
        arguments.Count.Should().Be(1);
    }

    [Fact]
    public void HavingArgsStringWithOneNamedArgument_WhenParsed_ThenArgumentHasTypeNamed()
    {
        arguments[0].Type.Should().Be(ArgumentType.Named);
    }

    [Fact]
    public void HavingArgsStringWithOneNamedArgument_WhenParsed_ThenArgumentHasCorrectName()
    {
        arguments[0].Name.Should().Be("param1");
    }

    [Fact]
    public void HavingArgsStringWithOneNamedArgument_WhenParsed_ThenArgumentHasCorrectValue()
    {
        arguments[0].Value.Should().Be("value1");
    }
}