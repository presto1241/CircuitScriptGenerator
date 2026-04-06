/*
 * Filename: RecRoomObjectGetAllwithTagdeprecated.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Searches the room for all objects with the input tag and outputs them as a list.
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

[Node("02d69553-ae96-4c2d-8477-59ada6a66783")]
public class RecRoomObjectGetAllwithTagdeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get All with Tag (deprecated)";
    public string GetVariableQualifiedName() => "recRoomObjectGetAllwithTagdeprecated";
}