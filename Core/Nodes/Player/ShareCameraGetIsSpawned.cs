/*
 * Filename: ShareCameraGetIsSpawned.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets whether the target player has their Share Camera spawned
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Is Spawned (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("f28a5263-76d9-4bba-97f2-2654ae04ce61")]
public class ShareCameraGetIsSpawned : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Share Camera Get Is Spawned";
    public string GetVariableQualifiedName() => "shareCameraGetIsSpawned";
}