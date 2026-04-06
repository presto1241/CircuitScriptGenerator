/*
 * Filename: ListMax.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the highest value in the target list.
 * Types: (float | int)
 * 
 * INPUTS: 
 * Target (List<T>)
 *
 * OUTPUTS: 
 * Result (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("47428133-4492-422a-aeab-82c21667543e")]
public class ListMax : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Max";
    public string GetVariableQualifiedName() => "listMax";
}