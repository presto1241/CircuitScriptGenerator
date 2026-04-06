/*
 * Filename: RoomOfferGetImage.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the image of the given room offer
 * Types: 
 * 
 * INPUTS: 
 * Room Offer (Room Offer)
 *
 * OUTPUTS: 
 * Image (RecNet Image)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("416591b6-cf95-4568-840b-347eb8f0dfc2")]
public class RoomOfferGetImage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Offer Get Image";
    public string GetVariableQualifiedName() => "roomOfferGetImage";
}