/*
 * Filename: RespawnPointRemoveAvoidTag.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Remove a player tag from the target respawn point's "avoid" list. It will no longer be avoided by players with the specified tag who are respawned using Respawn Point Respawn Player
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Spawn Point (Player Spawn Point V2)
 * Tag (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("1a6a4fc0-6e4a-4768-abea-a71c10ffa612")]
public class RespawnPointRemoveAvoidTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Respawn Point Remove Avoid Tag";
    public string GetVariableQualifiedName() => "respawnPointRemoveAvoidTag";
}