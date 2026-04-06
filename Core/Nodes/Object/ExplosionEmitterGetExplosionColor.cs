/*
 * Filename: ExplosionEmitterGetExplosionColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the particle color of the target Explosion Emitter
 * Types: 
 * 
 * INPUTS: 
 * Target (Explosion Emitter)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("6039d63b-f484-4436-bb7c-ea58529ed4ec")]
public class ExplosionEmitterGetExplosionColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Explosion Emitter Get Explosion Color";
    public string GetVariableQualifiedName() => "explosionEmitterGetExplosionColor";
}