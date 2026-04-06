/*
 * Filename: ListAnyTrue.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: If any bool value in the list is True then return True.
 * Types: 
 * 
 * INPUTS: 
 * Target (List<bool>)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("f9589495-685e-4e14-af2e-5cd45f860021")]
public class ListAnyTrue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Any True";
    public string GetVariableQualifiedName() => "listAnyTrue";
}