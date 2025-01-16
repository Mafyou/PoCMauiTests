using MauiLibAppPoC.ViewModels;
using Shouldly;

namespace MauiAppPoC.UnitTests;

[TestClass]
public sealed class MainPageViewModelTests
{
    private MainPageViewModel? _viewModel;

    [TestInitialize]
    public void TestInit()
    {
        // This method is called before each test method.
        _viewModel = new MainPageViewModel();
    }

    [TestCleanup]
    public void TestCleanup()
    {
        // This method is called after each test method.
        _viewModel = null;
    }

    [TestMethod]
    public void Counter_should_increment()
    {
        // Arrange
        int expected = _viewModel!.Counter + 1;
        // Act
        _viewModel.ButtonClickedCommand.Execute(null);
        // Assert
        _viewModel.Counter.ShouldBe(expected);
    }
}