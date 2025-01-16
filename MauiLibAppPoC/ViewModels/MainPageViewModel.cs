using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiLibAppPoC.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private int counter = 0;
    [RelayCommand]
    private void OnButtonClicked()
    {
        Counter++;
    }
}