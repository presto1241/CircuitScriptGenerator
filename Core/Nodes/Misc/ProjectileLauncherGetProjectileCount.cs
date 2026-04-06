/*
 * Filename: ProjectileLauncherGetProjectileCount.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns how many projectiles are fired whenever a Projectile Launcher fires.
 * Types: 
 * 
 * INPUTS: 
 * Target (Projectile Launcher)
 *
 * OUTPUTS: 
 * Count (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("25f4df63-828a-482b-89e5-96e357575dfe")]
public class ProjectileLauncherGetProjectileCount : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Projectile Launcher Get Projectile Count";
    public string GetVariableQualifiedName() => "projectileLauncherGetProjectileCount";
}