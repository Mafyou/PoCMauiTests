using Shouldly;

namespace MauiAppPoC.UnitTests;

public class MainPageUnitTests
{
    private readonly MainPage _sut;
    public MainPageUnitTests()
    {
        _sut = Moq.Mock.Of<MainPage>();
    }
    [Fact]
    public void MainPage_should_count()
    {
        // Act
        _sut.OnCounterClicked(null, null);

        // Assert
        _sut.count.ShouldBe(1);
    }
}
