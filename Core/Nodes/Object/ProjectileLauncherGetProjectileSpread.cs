/*
 * Filename: ProjectileLauncherGetProjectileSpread.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the angle (in degrees) that projectiles fired from this Projectile Launcher will stray from the firing direction. This accounts for both accuracy and things like shotgun spread. Projectiles are randomly distributed somewhere within this angle when fired.
 * Types: 
 * 
 * INPUTS: 
 * Target (Projectile Launcher)
 *
 * OUTPUTS: 
 * Spread (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("7c6fcbd2-d306-4824-ae11-73e2c133a7fb")]
public class ProjectileLauncherGetProjectileSpread : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Projectile Launcher Get Projectile Spread";
    public string GetVariableQualifiedName() => "projectileLauncherGetProjectileSpread";
}