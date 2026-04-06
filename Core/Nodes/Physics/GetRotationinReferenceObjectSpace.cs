/*
 * Filename: GetRotationinReferenceObjectSpace.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the rotation of the target as a quaternion, in the coordinate space defined by the reference object.
 * Types: (Rec Room Object | Player)
 * 
 * INPUTS: 
 * Target (T)
 * Reference Object (R)
 *
 * OUTPUTS: 
 * Quaternion (Quaternion)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("14bf5961-9d94-4ce0-a97a-37f5f382376c")]
public class GetRotationinReferenceObjectSpace : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Rotation in Reference Object Space";
    public string GetVariableQualifiedName() => "getRotationinReferenceObjectSpace";
}