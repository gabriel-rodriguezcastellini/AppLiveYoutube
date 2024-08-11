using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppLiveYoutube.ViewModels;

internal partial class TestViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _text;

    [RelayCommand]
    public void CambiarTexto()
    {
        Text = "Hola gente!!!";
    }
}
