/*
 * Filename: Not.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the opposite of the input boolean.
 * Types: 
 * 
 * INPUTS: 
 * Value (bool)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("ff551243-beb4-470e-ab48-9d616818d5e4")]
public class Not : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Not";
    public string GetVariableQualifiedName() => "not";
}