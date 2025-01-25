using MauiLibAppPoC.ViewModels;
using Shouldly;

namespace MauiAppPoC.UnitTests;

[TestClass]
public sealed class MainPageViewModelTests
{
    private MainPageViewModel? _sut;

    [TestInitialize]
    public void TestInit()
    {
        // This method is called before each test method.
        _sut = new MainPageViewModel();
    }

    [TestCleanup]
    public void TestCleanup()
    {
        // This method is called after each test method.
        _sut = null;
    }

    [TestMethod]
    public void Counter_should_increment()
    {
        // Arrange
        int expected = _sut!.Counter + 1;
        // Act
        _sut.ButtonClickedCommand.Execute(null);
        // Assert
        _sut.Counter.ShouldBe(expected);
    }
}