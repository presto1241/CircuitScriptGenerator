/*
 * Filename: GreaterorEqual.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns True if input A is greater than or equal to input B.
 * Types: (int | float)
 * 
 * INPUTS: 
 * A (T)
 * B (T)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("f3ced0d8-396e-4311-a807-8ffd9b147060")]
public class GreaterorEqual : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Greater or Equal";
    public string GetVariableQualifiedName() => "greaterorEqual";
}