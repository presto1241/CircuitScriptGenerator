/*
 * Filename: ExplosionEmitterSetDamage.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the damage value of the target Explosion Emitter
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Explosion Emitter)
 * Damage (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("748f210d-f9e2-4dca-a29a-8eacf99daff7")]
public class ExplosionEmitterSetDamage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Explosion Emitter Set Damage";
    public string GetVariableQualifiedName() => "explosionEmitterSetDamage";
}