/*
 * Filename: GreaterThan.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns True if input A is greater than input B.
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

[Node("65aa2570-98b8-413b-a9a9-2eae9f562871")]
public class GreaterThan : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Greater Than";
    public string GetVariableQualifiedName() => "greaterThan";
}