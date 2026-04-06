/*
 * Filename: GetVelocity.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the velocity of a Player or a Rec Room Object. If the velocity has just been changed via circuits, it will return the previous velocity.
 * Types: (Rec Room Object | Player)
 * 
 * INPUTS: 
 * Target (T)
 *
 * OUTPUTS: 
 * Velocity (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("0310de62-2ede-4af0-b551-0228290fc54c")]
public class GetVelocity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Velocity";
    public string GetVariableQualifiedName() => "getVelocity";
}