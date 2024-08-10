using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppLiveYoutube.ViewModels;

internal partial class TestViewModel : ObservableObject
{
    [ObservableProperty]
    private string? text;

    [RelayCommand]
    public void CambiarTexto()
    {
        Text = "Hola gente!!!";
    }
}
