/*
 * Filename: RespawnPointAddSpawnTag.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Add a player tag to the "spawn" list of the target respawn point. Players with that tag will include this respawn point as an option when being respawned with Respawn Point Respawn Player
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

[Node("3e936c68-9fbf-4ace-89a3-68156859db19")]
public class RespawnPointAddSpawnTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Respawn Point Add Spawn Tag";
    public string GetVariableQualifiedName() => "respawnPointAddSpawnTag";
}