/*
 * Filename: ProjectileLauncherSetProjectileSpread.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Modifies the angle (in degrees) that projectiles fired from this Projectile Launcher will stray from the firing direction. This affects both accuracy and things like shotgun spread. Projectiles are randomly distributed somewhere within this angle when fired.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Projectile Launcher)
 * Spread (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c01cee87-a81e-4cdb-84c5-d443cfe53bce")]
public class ProjectileLauncherSetProjectileSpread : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Projectile Launcher Set Projectile Spread";
    public string GetVariableQualifiedName() => "projectileLauncherSetProjectileSpread";
}