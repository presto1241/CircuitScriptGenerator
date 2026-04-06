/*
 * Filename: ExplosionEmitterGetExplosionRadius.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the radius of the explosion of the target Explosion Emitter
 * Types: 
 * 
 * INPUTS: 
 * Target (Explosion Emitter)
 *
 * OUTPUTS: 
 * Radius (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("eff7cfca-dcee-4ea1-887f-e4c60f3c8269")]
public class ExplosionEmitterGetExplosionRadius : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Explosion Emitter Get Explosion Radius";
    public string GetVariableQualifiedName() => "explosionEmitterGetExplosionRadius";
}