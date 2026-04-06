/*
 * Filename: Vector3MoveTowards.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Moves a vector towards target, not moving more than max delta distance at a time
 * Types: 
 * 
 * INPUTS: 
 * Current (Vector3)
 * Target (Vector3)
 * Max Delta (float)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("266d90c7-403e-4059-a481-ce3e22d61420")]
public class Vector3MoveTowards : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Move Towards";
    public string GetVariableQualifiedName() => "vector3MoveTowards";
}