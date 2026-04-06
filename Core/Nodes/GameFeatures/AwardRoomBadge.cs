/*
 * Filename: AwardRoomBadge.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Awards a Room Badge to a specific Player.

The Room Badge must be associated with the current room, and the Player must currently be in this room instance.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Room Badge (Room Badge)
 * Player (Player)
 * GiftPackageMessageOverride (string) - The message to show on the gift package delivered to Player. Leave this as "" to use the default gift package message for this badge.
 *
 * OUTPUTS: 
 * Run (exec)
 * On Ended (exec)
 * Room Badge (Room Badge)
 * Player (Player)
 * Succeeded (bool)
 * Player Already Had Badge (bool)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("142e3e21-de35-4c94-8c3b-4673d3f2720c")]
public class AwardRoomBadge : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Award Room Badge";
    public string GetVariableQualifiedName() => "awardRoomBadge";
}