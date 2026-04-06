/*
 * Filename: PlayerGetAllAttachedRecRoomObjects.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets a list of all the Rec Room Objects which are currently attached to a player.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Objects (List<Rec Room Object>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("979bbf48-62dc-4510-82f0-d69283056c2f")]
public class PlayerGetAllAttachedRecRoomObjects : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get All Attached Rec Room Objects";
    public string GetVariableQualifiedName() => "playerGetAllAttachedRecRoomObjects";
}