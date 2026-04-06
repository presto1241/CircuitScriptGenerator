/*
 * Filename: GetForwardVector.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the forward direction of a target, output as a vector.
 * Types: (Rec Room Object | Player)
 * 
 * INPUTS: 
 * Target (T)
 *
 * OUTPUTS: 
 * Vector (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("4536e1df-1138-4a2c-9117-475bb3f38eae")]
public class GetForwardVector : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Forward Vector";
    public string GetVariableQualifiedName() => "getForwardVector";
}