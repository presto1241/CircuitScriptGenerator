/*
 * Filename: LocalPlayerClearRoomOfferNameOverride.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clears the name override for a room offer
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Room Offer (Room Offer)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("35a06114-236d-4342-98e5-13679a9f4518")]
public class LocalPlayerClearRoomOfferNameOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Clear Room Offer Name Override";
    public string GetVariableQualifiedName() => "localPlayerClearRoomOfferNameOverride";
}