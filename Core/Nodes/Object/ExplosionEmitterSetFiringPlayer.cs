/*
 * Filename: ExplosionEmitterSetFiringPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the firing player of the target Explosion Emitter. If none is set, the component will use the authority player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Explosion Emitter)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d39b968d-bdab-4548-aaa7-745e3155789e")]
public class ExplosionEmitterSetFiringPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Explosion Emitter Set Firing Player";
    public string GetVariableQualifiedName() => "explosionEmitterSetFiringPlayer";
}