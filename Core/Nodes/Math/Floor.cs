/*
 * Filename: Floor.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the smallest integral value less than or equal to the input value.
 * Types: 
 * 
 * INPUTS: 
 * Value (float)
 *
 * OUTPUTS: 
 * Result (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("c90d9339-cdce-4d22-a885-f142fd5567ab")]
public class Floor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Floor";
    public string GetVariableQualifiedName() => "floor";
}