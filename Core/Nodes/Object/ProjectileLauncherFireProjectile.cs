/*
 * Filename: ProjectileLauncherFireProjectile.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: This chip requests that the specified Projectile Launcher fire a projectile according to its settings. If you run this too many times per second on a single Projectile Launcher, it could get throttled.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Projectile Launcher)
 * Direction (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("27e235ea-7305-4f3e-a426-04a887cbde6d")]
public class ProjectileLauncherFireProjectile : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Projectile Launcher Fire Projectile";
    public string GetVariableQualifiedName() => "projectileLauncherFireProjectile";
}