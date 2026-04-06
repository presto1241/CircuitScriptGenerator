/*
 * Filename: RecRoomObjectGetAllChildrenwithTag.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Searches the room for all objects with the input tag and outputs a list of their direct children and all descendants in the hierarchy.
 * Types: 
 * 
 * INPUTS: 
 * Object (Rec Room Object)
 * Tag (string)
 *
 * OUTPUTS: 
 * Children Objects with Tag (List<Rec Room Object>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c8ead7ca-2727-4358-b52b-012d56aa707f")]
public class RecRoomObjectGetAllChildrenwithTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get All Children with Tag";
    public string GetVariableQualifiedName() => "recRoomObjectGetAllChildrenwithTag";
}