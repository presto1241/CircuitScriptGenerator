/*
 * Filename: RespawnPointRemoveSpawnTag.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Remove a player tag from the target respawn point's "spawn" list. This respawn point will no longer be considered by players with the specified tag when they are respawned with Respawn Point Respawn Player
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

[Node("99cb7522-13a7-4aec-9166-dc0497057bbb")]
public class RespawnPointRemoveSpawnTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Respawn Point Remove Spawn Tag";
    public string GetVariableQualifiedName() => "respawnPointRemoveSpawnTag";
}