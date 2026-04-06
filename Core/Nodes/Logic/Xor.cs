/*
 * Filename: Xor.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if exactly one of the inputs is True. Outputs False if all inputs are false, or more than one is True.
 * Types: 
 * 
 * INPUTS: 
 * Input (bool)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("6db8f573-5300-4aa0-bbfa-b5f01533069a")]
public class Xor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Xor";
    public string GetVariableQualifiedName() => "xor";
}