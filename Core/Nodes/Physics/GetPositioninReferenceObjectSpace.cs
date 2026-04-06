/*
 * Filename: GetPositioninReferenceObjectSpace.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the position of the input object as a vector3, in the coordinate space defined by the reference object.
 * Types: (Rec Room Object | Player)
 * 
 * INPUTS: 
 * Target (T)
 * Reference Object (R)
 *
 * OUTPUTS: 
 * Position (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("72be9974-9713-415c-a29e-4a39a5ac4737")]
public class GetPositioninReferenceObjectSpace : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Position in Reference Object Space";
    public string GetVariableQualifiedName() => "getPositioninReferenceObjectSpace";
}