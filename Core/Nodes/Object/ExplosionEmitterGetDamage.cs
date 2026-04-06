/*
 * Filename: ExplosionEmitterGetDamage.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the current damage value of the target Explosion Emitter
 * Types: 
 * 
 * INPUTS: 
 * Target (Explosion Emitter)
 *
 * OUTPUTS: 
 * Damage (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("87d94359-da69-49ed-8b61-fbf78d79fa48")]
public class ExplosionEmitterGetDamage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Explosion Emitter Get Damage";
    public string GetVariableQualifiedName() => "explosionEmitterGetDamage";
}