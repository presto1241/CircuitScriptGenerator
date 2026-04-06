/*
 * Filename: Graph.cs
 * Created Date: Tuesday, March 31st 2026, 11:35:50 pm
 * Author: Preston
 * 
 * Description: This class holds all the nodes for a specific graph.
 * This includes the entry node, and all connecting nodes
 */
namespace CircuitScriptGenerator.Core.Data;

public class Graph
{
    public IReadOnlyList<Node> Nodes => _nodes;
    private List<Node> _nodes = new();

    public Graph()
    {}

    /// <summary>
    /// This is effectively the same as List<T>.First().
    /// </summary>
    /// <returns>The Entry Node</returns>
    public Node GetEntryNode()
    {
        return Nodes.First();
    }

    /// <summary>
    /// Get the first nodes name, this is an easy way to get the name of the graph.
    /// </summary>
    /// <returns></returns>
    public string GetEntryName()
    {
        return Nodes.First().Name;
    }
}
