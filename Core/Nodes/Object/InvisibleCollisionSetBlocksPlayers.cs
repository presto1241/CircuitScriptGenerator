/*
 * Filename: InvisibleCollisionSetBlocksPlayers.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the player collision state of a target Invisible Collision object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Invisible Collision)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("ed61effe-a684-4c1a-92c8-79fc6df010fb")]
public class InvisibleCollisionSetBlocksPlayers : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Invisible Collision Set Blocks Players";
    public string GetVariableQualifiedName() => "invisibleCollisionSetBlocksPlayers";
}