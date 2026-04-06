/*
 * Filename: RecRoomObjectGetLastHoldingOrEquippingPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the player who last held or equipped an object.
 * Types: 
 * 
 * INPUTS: 
 * Object (Rec Room Object)
 *
 * OUTPUTS: 
 * Player (Player)
 * Currently Held Or Equipped (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a76a9898-4add-4765-9f5b-f366b586e51c")]
public class RecRoomObjectGetLastHoldingOrEquippingPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get Last Holding Or Equipping Player";
    public string GetVariableQualifiedName() => "recRoomObjectGetLastHoldingOrEquippingPlayer";
}