/*
 * Filename: RecRoomObjectGetHolderPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the player currently holding this object. Does not account for when objects are equipped but not directly grabbed. Returns Invalid Player if the object is not being held.
 * Types: 
 * 
 * INPUTS: 
 * Object (Rec Room Object)
 *
 * OUTPUTS: 
 * Is Held (bool)
 * Holder Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("cd10a7ff-0c35-4b46-abfb-8e2f18397ad5")]
public class RecRoomObjectGetHolderPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get Holder Player";
    public string GetVariableQualifiedName() => "recRoomObjectGetHolderPlayer";
}