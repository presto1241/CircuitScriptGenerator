/*
 * Filename: RespawnPointRemoveSpawnRole.cs
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
 * Role (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("22b02578-a084-42ac-a27f-72a1fcb7cd63")]
public class RespawnPointRemoveSpawnRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Respawn Point Remove Spawn Role";
    public string GetVariableQualifiedName() => "respawnPointRemoveSpawnRole";
}