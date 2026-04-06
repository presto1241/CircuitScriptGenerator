/*
 * Filename: PlayParticleVFXAtPosition.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Plays a Particle VFX one time with the position, orientation, scale, speed, and optional color tint provided
 * Types: (Vector3 | Quaternion)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Particle VFX)
 * Position (Vector3)
 * Orientation (TOrientation)
 * Scale (float)
 * Speed (float)
 * Apply Color Tint (bool)
 * Color Tint (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("fb85ba6b-61bf-4b0c-8c51-1319a72afbe8")]
public class PlayParticleVFXAtPosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Play Particle VFX At Position";
    public string GetVariableQualifiedName() => "playParticleVFXAtPosition";
}