/*
 * Filename: InvisibleCollisionGetBlocksPlayers.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the target Invisible Collision object is set to collide with players.
 * Types: 
 * 
 * INPUTS: 
 * Target (Invisible Collision)
 *
 * OUTPUTS: 
 * Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("0938d870-2f6d-4144-ba3d-c73af0e46348")]
public class InvisibleCollisionGetBlocksPlayers : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Invisible Collision Get Blocks Players";
    public string GetVariableQualifiedName() => "invisibleCollisionGetBlocksPlayers";
}