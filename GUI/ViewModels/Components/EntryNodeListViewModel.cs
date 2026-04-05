using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CircuitScriptGenerator.GUI.ViewModels.Components;

public partial class EntryNodeListViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isPaneOpen = true;

    [RelayCommand]
    public void TogglePane() => IsPaneOpen = !IsPaneOpen;
}
