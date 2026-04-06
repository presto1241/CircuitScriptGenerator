/*
 * Filename: CeiltoInt.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the smallest integer value greater than or equal to the input value.
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

[Node("38b502dc-dd35-4083-a2b0-8a8e5f69a958")]
public class CeiltoInt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ceil to Int";
    public string GetVariableQualifiedName() => "ceiltoInt";
}