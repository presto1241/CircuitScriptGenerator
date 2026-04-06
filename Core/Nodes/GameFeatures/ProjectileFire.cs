/*
 * Filename: ProjectileFire.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Fires a Projectile from a source using the values configured on the input Projectile Constant
 * Types: (Vector3 | Rec Room Object)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Projectile (Projectile)
 * Projectile Source (TProjectileSource)
 * Direction (TDirection)
 * Speed Multiplier (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("d1a2e2de-1e07-45d5-b4aa-cd9eca624985")]
public class ProjectileFire : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Projectile Fire";
    public string GetVariableQualifiedName() => "projectileFire";
}