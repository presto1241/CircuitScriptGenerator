/*
 * Filename: ExplosionEmitterExplode.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Causes the target explosion emitter to explode
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Explosion Emitter)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("49774675-e750-441f-9e92-8455232f1703")]
public class ExplosionEmitterExplode : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Explosion Emitter Explode";
    public string GetVariableQualifiedName() => "explosionEmitterExplode";
}