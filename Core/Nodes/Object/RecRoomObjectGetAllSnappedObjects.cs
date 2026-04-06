/*
 * Filename: RecRoomObjectGetAllSnappedObjects.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets all root objects directly and indirectly connected to this object via snap points.
 * Types: 
 * 
 * INPUTS: 
 * Object (Rec Room Object)
 *
 * OUTPUTS: 
 * Snapped Objects (List<Rec Room Object>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("6cf7c504-fd8b-47dd-8215-52e1ffd9862e")]
public class RecRoomObjectGetAllSnappedObjects : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get All Snapped Objects";
    public string GetVariableQualifiedName() => "recRoomObjectGetAllSnappedObjects";
}