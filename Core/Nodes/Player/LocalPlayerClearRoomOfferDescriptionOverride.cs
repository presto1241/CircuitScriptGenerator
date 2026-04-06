/*
 * Filename: LocalPlayerClearRoomOfferDescriptionOverride.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clear the local description override for a room offer
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

[Node("38753f93-dfa4-4160-acde-d7869c83adf6")]
public class LocalPlayerClearRoomOfferDescriptionOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Clear Room Offer Description Override";
    public string GetVariableQualifiedName() => "localPlayerClearRoomOfferDescriptionOverride";
}