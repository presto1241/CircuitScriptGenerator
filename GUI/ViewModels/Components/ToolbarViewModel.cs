using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Platform.Storage;
using CircuitScriptGenerator.Core;
using CircuitScriptGenerator.Core.Api.Logging;
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

        var files = await topLevel.StorageProvider.OpenFilePickerAsync(new Avalonia.Platform.Storage.FilePickerOpenOptions
        {
            Title = "Open a file",
            AllowMultiple = false
        });

        // @todo: Open an error notification to select a file.
        if (files.Count <= 0)
        {
            Logger.Log("ToolbarViewModel", "No file was selected.", LogLevel.Warn);
        }

        string filePath = files[0].Path.AbsolutePath.Replace("%20", " ");

        Logger.Log("ToolbarViewModel", "Going to load file: " + filePath);
        CircuitsInstance.Load(filePath, out var circuitsInstance);
        Logger.Log("ToolbarViewModel", "Loaded file: " + filePath);
    }
}
