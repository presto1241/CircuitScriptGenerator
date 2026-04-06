/*
 * Filename: PlayerGetEquippedObjects.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets equipped objects from a player.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Dominant Hand Object (Rec Room Object)
 * Off-Hand Object (Rec Room Object)
 * Left Hip Holster Object (Rec Room Object)
 * Right Hip Holster Object (Rec Room Object)
 * Shoulder Holster Object (Rec Room Object)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("f0827a17-7d21-45ba-b302-c2b068bd50ca")]
public class PlayerGetEquippedObjects : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Equipped Objects";
    public string GetVariableQualifiedName() => "playerGetEquippedObjects";
}