/*
 * Filename: RoundToDecimalPlace.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Rounds the given number to the provided decimal place.

Examples: 
RoundToDecimalPlace(1234.4321, 0) = 1234
RoundToDecimalPlace(1234.4321, 2) = 1234.43
RoundToDecimalPlace(77.77, 0) = 78
 * Types: 
 * 
 * INPUTS: 
 * Value (float)
 * Decimals (int)
 *
 * OUTPUTS: 
 * Result (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("21e728ff-9d6d-4df6-ae0a-5de2db1cdab4")]
public class RoundToDecimalPlace : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Round To Decimal Place";
    public string GetVariableQualifiedName() => "roundToDecimalPlace";
}