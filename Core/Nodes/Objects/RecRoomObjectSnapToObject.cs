/*
 * Filename: RecRoomObjectSnapToObject.cs
 * Category: Objects
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Snaps an object to another object. Returns true if both objects have Snap Points attached to them and successfully snapped together.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Snap From (Rec Room Object)
 * Snap To (Rec Room Object)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Snap Successful (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Objects;

[Node("8658eb3c-a4e8-4218-9d47-661d1e664597")]
public class RecRoomObjectSnapToObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Snap To Object";
    public string GetVariableQualifiedName() => "recRoomObjectSnapToObject";
}