/*
 * Filename: IsValid.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns True if the input value is valid - meaning that it can be used by other chips.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (T)
 *
 * OUTPUTS: 
 * Is Valid (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("24a1be50-ef1b-4e54-836b-4a2a95780b4e")]
public class IsValid : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Is Valid";
    public string GetVariableQualifiedName() => "isValid";
}