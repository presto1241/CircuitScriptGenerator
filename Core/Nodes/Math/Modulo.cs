/*
 * Filename: Modulo.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the modulo of the first value when divided by the second.
 * Types: (int | float)
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Remainder (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("60da34d9-7e21-4cb6-a279-f083634c2979")]
public class Modulo : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Modulo";
    public string GetVariableQualifiedName() => "modulo";
}