using MauiLibAppPoC.ViewModels;

namespace MauiAppPoC;

public partial class MainPage : ContentPage
{
    //internal int count = 0;

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}
