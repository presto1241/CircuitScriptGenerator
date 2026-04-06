/*
 * Filename: ProjectileLauncherGetFiringPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the player set by the Projectile Launcher Set Firing Player chip.
 * Types: 
 * 
 * INPUTS: 
 * Target (Projectile Launcher)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9bc9def7-d7c3-4248-ba1c-35116f013768")]
public class ProjectileLauncherGetFiringPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Projectile Launcher Get Firing Player";
    public string GetVariableQualifiedName() => "projectileLauncherGetFiringPlayer";
}