/*
 * Filename: LocalPlayerSetRoomOfferImageOverride.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Overides the displayed image of a Room Offer for local player
 * Types: 
 * 
 * INPUTS: 
 * Set Override (exec)
 * Room Offer (Room Offer)
 * Image (RecNet Image)
 *
 * OUTPUTS: 
 * Set Override (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("2ca1fe19-f60c-4e41-a141-07dda4a1f127")]
public class LocalPlayerSetRoomOfferImageOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Set Room Offer Image Override";
    public string GetVariableQualifiedName() => "localPlayerSetRoomOfferImageOverride";
}