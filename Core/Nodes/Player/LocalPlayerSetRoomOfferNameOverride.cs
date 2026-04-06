/*
 * Filename: LocalPlayerSetRoomOfferNameOverride.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the name override for a room offer
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Room Offer (Room Offer)
 * Name (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("9d6e1d07-f4fb-44b8-b261-1949e105a3cb")]
public class LocalPlayerSetRoomOfferNameOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Set Room Offer Name Override";
    public string GetVariableQualifiedName() => "localPlayerSetRoomOfferNameOverride";
}