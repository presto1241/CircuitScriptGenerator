/*
 * Filename: ProjectileLauncherSetProjectileCount.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Modifies how many projectiles are fired whenever a Projectile Launcher fires. Use in conjunction with Projectile Spread to make a projectile launcher that acts like a shotgun.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Projectile Launcher)
 * Count (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("28132c36-99ac-405d-807e-aeacbc37a3f1")]
public class ProjectileLauncherSetProjectileCount : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Projectile Launcher Set Projectile Count";
    public string GetVariableQualifiedName() => "projectileLauncherSetProjectileCount";
}