/*
 * Filename: RecRoomObjectGetDirectlySnappedObjects.cs
 * Category: Objects
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets all root objects conneted directly to the object via snap points.
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

namespace CircuitScriptGenerator.Core.Nodes.Objects;

[Node("4ddedf4a-57d6-468d-bd64-69910bad796f")]
public class RecRoomObjectGetDirectlySnappedObjects : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get Directly Snapped Objects";
    public string GetVariableQualifiedName() => "recRoomObjectGetDirectlySnappedObjects";
}