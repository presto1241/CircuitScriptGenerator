/*
 * Filename: ListAllTrue.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: If all of the bool values in the list are True then return true.
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

[Node("7d474bd7-ee53-4e6d-a45f-cd64fce1c0dc")]
public class ListAllTrue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List All True";
    public string GetVariableQualifiedName() => "listAllTrue";
}