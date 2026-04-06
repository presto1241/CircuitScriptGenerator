/*
 * Filename: RespawnPointRespawnPlayerAtRespawnPoint.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Spawn Point (Player Spawn Point V2)
 * Player (Player)
 * Clear Velocity (bool)
 * Use Rez Effects (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c52419da-019e-4104-95e3-0f0adfa8ebf2")]
public class RespawnPointRespawnPlayerAtRespawnPoint : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Respawn Point Respawn Player At Respawn Point";
    public string GetVariableQualifiedName() => "respawnPointRespawnPlayerAtRespawnPoint";
}