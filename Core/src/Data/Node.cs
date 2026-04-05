/*
 * Filename: Node.cs
 * Created Date: Tuesday, March 31st 2026, 11:35:50 pm
 * Author: Preston
 * 
 * Description: This is essentially a chip.
 * This holds the chip id, its inputs, and outputs.
 */
namespace CircuitScriptGenerator.Core.Data;

public class Node
{
    public string Name { get; }
    public int NodeId { get; }
    public string AssetId { get; }

    public IReadOnlyList<Port> InputPorts => _inputPorts;
    public List<Port> _inputPorts = new(); 

    public IReadOnlyList<Port> OutputPorts => _outputPorts;
    public List<Port> _outputPorts = new();

    public Node(string name, int nodeId, string assetId)
    {
        Name = name;
        NodeId = nodeId;
        AssetId = assetId;
    }
}
