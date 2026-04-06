/*
 * Filename: CallFunctionunbound.cs
 * Category: Commonly Used
 * Created Date: 2026-04-05T23:55:26+00:00
 * Author: Preston
 * 
 * Description: Calls the Function Definition node with the same name in this room.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * 
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Commonly Used;

[Node("0d2f8ac1-d0b7-427f-a261-6bf269af223f")]
public class CallFunctionunbound : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Call Function (unbound)";
    public string GetVariableQualifiedName() => "callFunctionunbound";
}