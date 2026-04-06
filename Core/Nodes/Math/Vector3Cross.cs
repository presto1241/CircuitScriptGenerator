/*
 * Filename: Vector3Cross.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: The cross product of two vectors results in a third vector which is perpendicular to the two input vectors.
 * Types: 
 * 
 * INPUTS: 
 * Lhs (Vector3)
 * Rhs (Vector3)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("6bd92538-6889-41f3-b819-9511e6f81944")]
public class Vector3Cross : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Cross";
    public string GetVariableQualifiedName() => "vector3Cross";
}