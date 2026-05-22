using FluentAssertions;

namespace DustInTheWind.ConsoleTools.Arguments.Tests.ArgumentsTests;

public class Constructor_TwoNamedArgumentsTests
{
    private readonly Arguments arguments;

    public Constructor_TwoNamedArgumentsTests()
    {
        string[] args = { "-param1", "value1", "-param2", "value2" };

        arguments = new Arguments(args);
    }

    [Fact]
    public void HavingArgsStringWithTwoNamedArgument_WhenParsed_ThenSecondArgumentsContainsTwoItems()
    {
        arguments.Count.Should().Be(2);
    }

    [Fact]
    public void HavingArgsStringWithTwoNamedArgument_WhenParsed_ThenSecondArgumentHasTypeNamed()
    {
        arguments[1].Type.Should().Be(ArgumentType.Named);
    }

    [Fact]
    public void HavingArgsStringWithTwoNamedArgument_WhenParsed_ThenSecondArgumentHasCorrectName()
    {
        arguments[1].Name.Should().Be("param2");
    }

    [Fact]
    public void HavingArgsStringWithTwoNamedArgument_WhenParsed_ThenSecondArgumentHasCorrectValue()
    {
        arguments[1].Value.Should().Be("value2");
    }
}