/*
 * Filename: VectorComponentGetVector.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the direction and magnitude of the Vector Component.
 * Types: 
 * 
 * INPUTS: 
 * Direction (Vector Component)
 * Magnitude (float)
 *
 * OUTPUTS: 
 * Vector (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("74ba9189-2880-46fa-b4b0-3c9a7152489e")]
public class VectorComponentGetVector : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector Component Get Vector";
    public string GetVariableQualifiedName() => "vectorComponentGetVector";
}