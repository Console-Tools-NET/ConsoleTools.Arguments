using FluentAssertions;

namespace DustInTheWind.ConsoleTools.Arguments.Tests.ArgumentsTests;

public class IndexerByIndexTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(10)]
    [InlineData(-1)]
    public void HavingArgumentsInstanceWithNoArgument_WhenRetrievingNonexistentItem_ThenReturnsNull(int index)
    {
        Arguments arguments = new(Array.Empty<string>());

        Argument? argument = arguments[index];

        argument.Should().BeNull();
    }

    [Fact]
    public void HavingArgumentsInstanceWithOneArgument_WhenRetrievingIt_ThenReturnsTheArgument()
    {
        Arguments arguments = new(new[] { "argument1" });

        Argument? argument = arguments[0];

        argument.Value.Should().Be("argument1");
    }

    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    [InlineData(-1)]
    public void HavingArgumentsInstanceWithOneArgument_WhenRetrievingNonexistentItem_ThenReturnsNull(int index)
    {
        Arguments arguments = new(new[] { "argument1" });

        Argument? argument = arguments[index];

        argument.Should().BeNull();
    }

    [Theory]
    [InlineData(2)]
    [InlineData(10)]
    [InlineData(-1)]
    public void HavingArgumentsInstanceWithTwoArguments_WhenRetrievingNonexistentItem_ThenReturnsNull(int index)
    {
        Arguments arguments = new(new[] { "argument1", "argument2" });

        Argument? argument = arguments[index];

        argument.Should().BeNull();
    }
}