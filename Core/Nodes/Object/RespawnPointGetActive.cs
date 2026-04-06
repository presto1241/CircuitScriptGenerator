/*
 * Filename: RespawnPointGetActive.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the target Respawn Point is currently active
 * Types: 
 * 
 * INPUTS: 
 * Target (Player Spawn Point V2)
 *
 * OUTPUTS: 
 * Active (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("49bab5c6-d519-4af5-a5ee-466798e3e8bd")]
public class RespawnPointGetActive : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Respawn Point Get Active";
    public string GetVariableQualifiedName() => "respawnPointGetActive";
}