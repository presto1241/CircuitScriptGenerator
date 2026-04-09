/*
 * Filename: FileLoader.cs
 * Created Date: Tuesday, April 7th 2026, 12:49:48 am
 * Author: Preston
 * 
 * Description: Load circuits data from zip file.
 */

using System.IO.Compression;
using System.Reflection;
using CircuitScriptGenerator.Core.Api.Logging;
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Api.Parsing;

public static class FileLoader
{
    private static readonly string[] ValidExtensions =
    {
        ".zip"
    };

    public static List<Graph>? LoadGraphDataFromZip(string filePath)
    {
        if (!ValidExtensions.Contains(Path.GetExtension(filePath)))
        {
            throw new FileLoadException($"File must be any of type [{string.Join(", ", ValidExtensions)}]");
        }
        
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException();
        }

        List<Graph>? loadedGraphs = null;
        FileStream zipFileStream = new FileStream(filePath, FileMode.Open);
        ZipArchive zipArchive = new ZipArchive(zipFileStream, ZipArchiveMode.Read);

        // First go through every type in the project and find every type with NodeAttribute
        // And inherits INodeBehaviour. 
        var typesWithAttribute = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => 
                t.GetCustomAttribute<DataParserAttribute>() != null &&
                typeof(IDataParser).IsAssignableFrom(t) &&
                !t.IsAbstract &&
                !t.IsInterface);

        if (typesWithAttribute.Count() <= 0)
        {
            Logger.Log("FileLoader", "Found no available parsers :(", LogLevel.Warn);
            return null;
        }

        int dataParserCount = typesWithAttribute.Count();
        bool loaded = false;
        Logger.Log("FileLoader", $"Loaded {dataParserCount} data parsers");

        foreach (var type in typesWithAttribute)
        {
            try
            {
                IDataParser parser = (IDataParser)Activator.CreateInstance(type)!;
                if (parser.TryParseData(zipArchive, out loadedGraphs))
                {
                    loaded = true;
                    break;
                }
            }
            catch
            {}
        }

        if (loadedGraphs == null && loaded)
        {
            Logger.Log("FileLoader", "Data successfully loaded but no graphs were created.", LogLevel.Warn);
            return null;
        }

        if (loadedGraphs == null)
        {
            Logger.Log("FileLoader", "Failed to load archive with available parsers", LogLevel.Error);
            return null;
        }

        Logger.Log("FileLoader", $"Loaded archive with contents: {string.Join(", ", zipArchive.Entries.Select(v => v.FullName))}");

        return loadedGraphs;
    } 
}
