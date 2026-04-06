/*
 * Filename: TruncateToDecimalPlace.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Truncates the given number to the provided decimal place.

Examples: 
TruncateToDecimalPlace(1234.4321, 0) = 1234
TruncateToDecimalPlace(1234.4321, 2) = 1234.43
TruncateToDecimalPlace(77.77, 0) = 77
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

[Node("b32c07c5-1bf8-499b-8e6b-c50d23105437")]
public class TruncateToDecimalPlace : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Truncate To Decimal Place";
    public string GetVariableQualifiedName() => "truncateToDecimalPlace";
}