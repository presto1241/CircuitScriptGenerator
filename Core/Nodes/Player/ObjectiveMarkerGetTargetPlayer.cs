/*
 * Filename: ObjectiveMarkerGetTargetPlayer.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Get Target Player returns the player targeted by target Objective Marker, if it’s tracking a player. If target Objective Marker is not tracking a player, returns Invalid Player.
 * Types: 
 * 
 * INPUTS: 
 * Target (Objective Marker)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("f008de51-c5bb-4107-84e8-18a2d5b648bd")]
public class ObjectiveMarkerGetTargetPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Get Target Player";
    public string GetVariableQualifiedName() => "objectiveMarkerGetTargetPlayer";
}