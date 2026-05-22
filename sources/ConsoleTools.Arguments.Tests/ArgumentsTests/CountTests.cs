using FluentAssertions;

namespace DustInTheWind.ConsoleTools.Arguments.Tests.ArgumentsTests;

public class CountTests
{
    [Fact]
    public void HavingArgumentsInstanceWithNoArgument_ThenCountIs0()
    {
        Arguments arguments = new(Array.Empty<string>());

        arguments.Count.Should().Be(0);
    }

    [Fact]
    public void HavingArgumentsInstanceWithOneArgument_ThenCountIs1()
    {
        Arguments arguments = new(new[] { "argument1" });

        arguments.Count.Should().Be(1);
    }

    [Fact]
    public void HavingArgumentsInstanceWithTwoArguments_ThenCountIs2()
    {
        Arguments arguments = new(new[] { "argument1", "argument2" });

        arguments.Count.Should().Be(2);
    }

    [Fact]
    public void HavingArgumentsInstanceWithThreeArguments_ThenCountIs3()
    {
        Arguments arguments = new(new[] { "argument1", "argument2", "argument3" });

        arguments.Count.Should().Be(3);
    }
}