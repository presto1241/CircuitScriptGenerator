/*
 * Filename: ExplosionEmitterGetFiringPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the player set by the Explosion Emitter Set Firing Player chip.
 * Types: 
 * 
 * INPUTS: 
 * Target (Explosion Emitter)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("36cd4562-2c1f-43e3-ba90-56daa0cb7339")]
public class ExplosionEmitterGetFiringPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Explosion Emitter Get Firing Player";
    public string GetVariableQualifiedName() => "explosionEmitterGetFiringPlayer";
}