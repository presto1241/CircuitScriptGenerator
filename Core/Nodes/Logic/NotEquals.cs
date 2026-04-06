/*
 * Filename: NotEquals.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Compares the input values and outputs True if they are different. False if they are the same.
 * Types: any
 * 
 * INPUTS: 
 * Value (T)
 * Value (T)
 *
 * OUTPUTS: 
 * Equals (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("98a46410-ddd1-46b8-a99e-0642f75a0861")]
public class NotEquals : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Not Equals";
    public string GetVariableQualifiedName() => "notEquals";
}