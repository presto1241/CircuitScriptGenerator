/*
 * Filename: RecRoomObjectGetAllwithTag.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Searches the room for all objects with the input tag and outputs them as a list.

Objects are guaranteed to be returned in the same order for every player in an room. The order may change between instances of a room or when the room is reloaded.
 * Types: 
 * 
 * INPUTS: 
 * Tag (string)
 *
 * OUTPUTS: 
 * Objects with Tag (List<Rec Room Object>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("6404b6b4-3bc4-4bbb-8d2c-058a6834e9e9")]
public class RecRoomObjectGetAllwithTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get All with Tag";
    public string GetVariableQualifiedName() => "recRoomObjectGetAllwithTag";
}