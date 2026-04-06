/*
 * Filename: IfValue.cs
 * Category: Commonly Used
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs one input value based on the input condition. Outputs the "Then" input if the input condition is True. Outputs the "Else" input if the input condition is False. Only reads one of the inputs, not both.
 * Types: any
 * 
 * INPUTS: 
 * If (bool)
 * Then (T)
 * Else (T)
 *
 * OUTPUTS: 
 * Result (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.CommonlyUsed;

[Node("a4f8a9a1-fd7b-4702-8345-93ae4d57f333")]
public class IfValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "If Value";
    public string GetVariableQualifiedName() => "ifValue";
}