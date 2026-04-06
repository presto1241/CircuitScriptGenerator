/*
 * Filename: VectorGetMagnitude.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the length of the input vector.
 * Types: 
 * 
 * INPUTS: 
 * Vector3 (Vector3)
 *
 * OUTPUTS: 
 * Magnitude (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("c3b9ba98-6c4a-44c2-9125-043314fba4a6")]
public class VectorGetMagnitude : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector Get Magnitude";
    public string GetVariableQualifiedName() => "vectorGetMagnitude";
}