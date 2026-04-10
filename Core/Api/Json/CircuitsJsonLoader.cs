/*
 * Filename: CircuitsJsonLoader.cs
 * Created Date: Thursday, April 9th 2026, 6:18:36 pm
 * Author: Preston
 * 
 * Description: A class to load every cv2 chip metadata into the library.
 */

using System.Reflection;
using CircuitScriptGenerator.Core.Api.Json.Data;
using CircuitScriptGenerator.Core.Api.Logging;
using Newtonsoft.Json;

namespace CircuitScriptGenerator.Core.Api.Json;

public static class CircuitsJsonLoader
{
    public static bool IsLoaded { get; private set; }

    public static Dictionary<string, NodeMetadata> Nodes => _root!.Nodes;
    private static NodesRoot? _root;
    
    public static void LoadJson()
    {
        var assembly = Assembly.GetExecutingAssembly();
        Stream? stream = assembly.GetManifestResourceStream(assembly.GetName().Name + ".circuitsv2.full.json");

        if (stream == null)
        {
            throw new FileNotFoundException("Could not find generation template in assembly.");
        }

        StreamReader reader = new StreamReader(stream);
        string jsonData = reader.ReadToEnd();
        _root = JsonConvert.DeserializeObject<NodesRoot>(jsonData);
        IsLoaded = true;

        Logger.Log("CircuitsJsonLoader", $"Loaded {Nodes.Keys.Count} nodes from json");

        stream.Close();
        reader.Close();
    }
}