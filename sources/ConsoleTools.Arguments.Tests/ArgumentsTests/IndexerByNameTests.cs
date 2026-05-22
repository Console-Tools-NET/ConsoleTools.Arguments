using FluentAssertions;

namespace DustInTheWind.ConsoleTools.Arguments.Tests.ArgumentsTests;

public class IndexerByNameTests
{
    [Fact]
    public void HavingArgumentsInstanceWithNoArgument_WhenRetrievingNonexistentItem_ThenReturnsNull()
    {
        Arguments arguments = new(Array.Empty<string>());

        Argument? argument = arguments["nonexistent"];

        argument.Should().BeNull();
    }

    [Fact]
    public void HavingArgumentsInstanceWithOneNamedArgument_WhenRetrievingNonexistentItem_ThenReturnsNull()
    {
        Arguments arguments = new(new[] { "-argument1", "value1" });

        Argument? argument = arguments["nonexistent"];

        argument.Should().BeNull();
    }

    [Fact]
    public void HavingArgumentsInstanceWithOneNamedArgument_WhenRetrievingIt_ThenReturnsTheArgument()
    {
        Arguments arguments = new(new[] { "-argument1", "value1" });

        Argument? argument = arguments["argument1"];

        argument.Name.Should().Be("argument1");
    }

    [Fact]
    public void HavingArgumentsInstanceWithTwoNamedArguments_WhenRetrievingNonexistentItem_ThenReturnsNull()
    {
        Arguments arguments = new(new[] { "-argument1", "value1", "-argument2", "value2" });

        Argument? argument = arguments["nonexistent"];

        argument.Should().BeNull();
    }

    [Theory]
    [InlineData("argument1")]
    [InlineData("argument2")]
    public void HavingArgumentsInstanceWithTwoNamedArguments_WhenRetrievingOneItem_ThenReturnsCorrectArgument(string name)
    {
        Arguments arguments = new(new[] { "-argument1", "value1", "-argument2", "value2" });

        Argument? argument = arguments[name];

        argument.Name.Should().Be(name);
    }

    [Fact]
    public void HavingArgumentsInstanceWithTwoUnnamedArguments_WhenRetrievingNonexistentItem_ThenReturnsNull()
    {
        Arguments arguments = new(new[] { "argument1", "argument2" });

        Argument? argument = arguments["nonexistent"];

        argument.Should().BeNull();
    }
}