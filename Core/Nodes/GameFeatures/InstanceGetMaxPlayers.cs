/*
 * Filename: InstanceGetMaxPlayers.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the maximum number of players that can fit in this room, as set in subroom settings.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Max Players (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("af660f62-d086-4731-ab9d-9a8e8a25c77e")]
public class InstanceGetMaxPlayers : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Instance Get Max Players";
    public string GetVariableQualifiedName() => "instanceGetMaxPlayers";
}