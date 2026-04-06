/*
 * Filename: ExplosionEmitterSetExplosionColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the particle color of the target Explosion Emitter
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Explosion Emitter)
 * Color (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a3211c4f-9924-4a9a-afea-ab48f37bbc67")]
public class ExplosionEmitterSetExplosionColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Explosion Emitter Set Explosion Color";
    public string GetVariableQualifiedName() => "explosionEmitterSetExplosionColor";
}