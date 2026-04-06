/*
 * Filename: MakeTuple.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Creates a Tuple from a pair of inputted parameters
 * Types: any
 * 
 * INPUTS: 
 * Item 0 (T0)
 * Item 1 (T1)
 *
 * OUTPUTS: 
 * Tuple ((T0, T1))
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("bee72c1d-266b-4ea4-b185-7500618030c6")]
public class MakeTuple : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Make Tuple";
    public string GetVariableQualifiedName() => "makeTuple";
}