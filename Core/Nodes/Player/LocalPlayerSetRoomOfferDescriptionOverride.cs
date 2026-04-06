/*
 * Filename: LocalPlayerSetRoomOfferDescriptionOverride.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Overides the description of a Room Offer for local player
 * Types: 
 * 
 * INPUTS: 
 * Set Override (exec)
 * Room Offer (Room Offer)
 * Description (string)
 *
 * OUTPUTS: 
 * Set Override (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("63ada75a-4b4e-4cb9-8c28-fee86ddebe8a")]
public class LocalPlayerSetRoomOfferDescriptionOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Set Room Offer Description Override";
    public string GetVariableQualifiedName() => "localPlayerSetRoomOfferDescriptionOverride";
}