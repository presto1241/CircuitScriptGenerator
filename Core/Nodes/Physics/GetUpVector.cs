/*
 * Filename: GetUpVector.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the up direction of the input target, output as a vector3.
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

[Node("824f6801-17b6-4ada-9a97-4f36cef02e8b")]
public class GetUpVector : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Up Vector";
    public string GetVariableQualifiedName() => "getUpVector";
}