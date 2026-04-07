/*
 * Filename: FileLoader.cs
 * Created Date: Tuesday, April 7th 2026, 12:49:48 am
 * Author: Preston
 * 
 * Description: Load circuits data from zip file.
 */

using System.IO.Compression;
using CircuitScriptGenerator.Core.Api.Logging;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Api.Files;

public static class FileLoader
{
    private static readonly string[] ValidExtensions =
    {
        ".zip"
    };

    public static List<Graph> LoadGraphDataFromZip(string filePath)
    {
        if (!ValidExtensions.Contains(Path.GetExtension(filePath)))
        {
            throw new FileLoadException($"File must be any of type [{string.Join(", ", ValidExtensions)}]");
        }
        
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException();
        }

        List<Graph> loadedGraphs = new();
        FileStream zipFileStream = new FileStream(filePath, FileMode.Open);
        ZipArchive zipArchive = new ZipArchive(zipFileStream, ZipArchiveMode.Read);

        Logger.Log("FileLoader", $"Loaded archive with contents: {string.Join(", ", zipArchive.Entries.Select(v => v.FullName))}");

        return loadedGraphs;
    } 
}
