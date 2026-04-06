/*
 * Filename: LocalPlayerClearRoomOfferImageOverride.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clear the local image override for a room offer
 * Types: 
 * 
 * INPUTS: 
 * Clear Override (exec)
 * Room Offer (Room Offer)
 *
 * OUTPUTS: 
 * Clear Override (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("2d2713ea-67b9-47c0-bc53-0cc1c5d9ca6a")]
public class LocalPlayerClearRoomOfferImageOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Clear Room Offer Image Override";
    public string GetVariableQualifiedName() => "localPlayerClearRoomOfferImageOverride";
}