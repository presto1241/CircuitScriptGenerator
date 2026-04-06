/*
 * Filename: INodeBehaviour.cs
 * Created Date: Sunday, April 5th 2026, 1:22:47 am
 * Author: Preston
 * 
 * Description: An interface that lets nodes easily be called from other scripts.
 */
using System.Reflection;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Api.Nodes;

public static class NodeStorage
{
    private static Dictionary<string, INodeBehaviour>? _loadedNodes;
    public static bool GetNodesLoaded() => _loadedNodes != null;

    /// <summary>
    /// Load every node that can be found in the project and create a dictionary.
    /// </summary>
    public static void LoadNodes()
    {

        // First go through every type in the project and find every type with NodeAttribute
        // And inherits INodeBehaviour. 
        var typesWithAttribute = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => 
                t.GetCustomAttribute<NodeAttribute>() != null &&
                typeof(INodeBehaviour).IsAssignableFrom(t) &&
                !t.IsAbstract &&
                !t.IsInterface);

        Console.WriteLine($"[NodeStorage] Found {typesWithAttribute.Count()} nodes.");

        if (_loadedNodes != null) _loadedNodes.Clear();
        else _loadedNodes = new();

        foreach (var type in typesWithAttribute)
        {
            var attribute = type.GetCustomAttribute<NodeAttribute>()!;
            var behaviour = (INodeBehaviour)Activator.CreateInstance(type)!;

            Console.WriteLine($"[NodeStorage] Adding {behaviour.GetName()} : {attribute.AssetId}");
            _loadedNodes.Add(attribute.AssetId, behaviour);
        }
    }

    public static bool TryGetNode(string nodeId, out INodeBehaviour? nodeBehaviour)
    {
        nodeBehaviour = null;
        if (_loadedNodes == null) return false;

        return _loadedNodes.TryGetValue(nodeId, out nodeBehaviour);
    }
}