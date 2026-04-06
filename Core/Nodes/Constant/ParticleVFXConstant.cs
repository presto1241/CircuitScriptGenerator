/*
 * Filename: ParticleVFXConstant.cs
 * Category: Constant
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Constant that can be configured to a Rec Room particle effect or a custom effect made in Rec Room Studio. Used with the Play Particle VFX At Position chip
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Particle VFX)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Constant;

[Node("488f91cc-cf70-4a84-a572-7ea367a13417")]
public class ParticleVFXConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Particle VFX Constant";
    public string GetVariableQualifiedName() => "particleVFXConstant";
}