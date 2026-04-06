/*
 * Filename: AbsoluteValue.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the magnitude of the number. Is always positive.
 * Types: (float | int)
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Result (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("98b99011-9be8-43b3-89cc-1e9d55bd8b51")]
public class AbsoluteValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Absolute Value";
    public string GetVariableQualifiedName() => "absoluteValue";
}