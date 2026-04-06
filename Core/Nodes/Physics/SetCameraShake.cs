/*
 * Filename: SetCameraShake.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Start a screen shake effect for the given player. This will have no effect on VR players.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Intensity (float)
 * Duration (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("a4bf7bb6-6dd9-4b34-85ab-2aaa324647e4")]
public class SetCameraShake : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Camera Shake";
    public string GetVariableQualifiedName() => "setCameraShake";
}