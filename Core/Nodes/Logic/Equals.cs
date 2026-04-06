/*
 * Filename: Equals.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Compares the input values and outputs True if they are the same. False if they are different.
 * Types: any
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Equals (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("e1f1b65e-8d82-47af-8637-ae2d0afa431f")]
public class Equals : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Equals";
    public string GetVariableQualifiedName() => "equals";
}