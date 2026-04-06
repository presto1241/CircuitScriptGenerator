/*
 * Filename: FloortoInt.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the smallest integer value less than or equal to the input value.
 * Types: 
 * 
 * INPUTS: 
 * Value (float)
 *
 * OUTPUTS: 
 * Result (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("bc451cab-2292-4e60-832d-31060eb82bd0")]
public class FloortoInt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Floor to Int";
    public string GetVariableQualifiedName() => "floortoInt";
}