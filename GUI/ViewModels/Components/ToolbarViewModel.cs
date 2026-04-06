using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using CircuitScriptGenerator.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CircuitScriptGenerator.GUI.ViewModels.Components;

public partial class ToolbarViewModel : ViewModelBase
{
    public ICommand OpenFileCommand { get; }

    public ToolbarViewModel()
    {
        OpenFileCommand = new AsyncRelayCommand<TopLevel>(OpenFile);
    }
    
    private async Task OpenFile(TopLevel? topLevel)
    {
        if (topLevel == null) return;

        List<FilePickerFileType> types = new ()
        {
            new FilePickerFileType(".protobuf"),
            new FilePickerFileType(".json")
        };

        var files = await topLevel.StorageProvider.OpenFilePickerAsync(new Avalonia.Platform.Storage.FilePickerOpenOptions
        {
            Title = "Open a file",
            FileTypeFilter = types,
            AllowMultiple = false
        });

        // @todo: Open an error notification to select a file.
        if (files.Count <= 1) return;

        await CircuitsInstance.LoadAsync(files[0].Path.AbsolutePath);
    }
}
