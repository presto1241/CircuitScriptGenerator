/*
 * Filename: ExplosionEmitterSetExplosionRadius.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the radius of the explosion for the target Explosion Emitter
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Explosion Emitter)
 * Radius (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("672e473f-7099-4f76-aead-8b3df7c2fcd2")]
public class ExplosionEmitterSetExplosionRadius : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Explosion Emitter Set Explosion Radius";
    public string GetVariableQualifiedName() => "explosionEmitterSetExplosionRadius";
}