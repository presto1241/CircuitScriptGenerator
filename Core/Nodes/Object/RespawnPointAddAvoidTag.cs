/*
 * Filename: RespawnPointAddAvoidTag.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Add a player tag to the "avoid" list of the target respawn point. Players with that tag will avoid this respawn point when being respawned with Respawn Point Respawn Player
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

[Node("82122e0c-d393-4735-a7ad-2217b09eb73c")]
public class RespawnPointAddAvoidTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Respawn Point Add Avoid Tag";
    public string GetVariableQualifiedName() => "respawnPointAddAvoidTag";
}