/*
 * Filename: RespawnPointRespawnPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
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

[Node("350cda38-d7c5-4319-bb15-a06f49bbb0b9")]
public class RespawnPointRespawnPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Respawn Point Respawn Player";
    public string GetVariableQualifiedName() => "respawnPointRespawnPlayer";
}