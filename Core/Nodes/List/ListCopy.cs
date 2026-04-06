/*
 * Filename: ListCopy.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a shallow clone of the given list.
 * Types: any
 * 
 * INPUTS: 
 * Target (List<T>)
 *
 * OUTPUTS: 
 * Copy (List<T>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("b336b889-407a-45c8-ad82-a89f4e033c05")]
public class ListCopy : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Copy";
    public string GetVariableQualifiedName() => "listCopy";
}