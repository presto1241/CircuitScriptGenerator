/*
 * Filename: RecRoomObjectGetAllofTypewithTag.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Searches the room for all objects with the input tag that are also of the selected Rec Room object type, and outputs them as a list.

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

[Node("724b02c3-9ba4-40aa-b06d-e84a3ce182ec")]
public class RecRoomObjectGetAllofTypewithTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get All of Type with Tag";
    public string GetVariableQualifiedName() => "recRoomObjectGetAllofTypewithTag";
}