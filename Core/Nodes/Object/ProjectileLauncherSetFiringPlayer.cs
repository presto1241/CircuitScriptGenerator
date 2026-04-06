/*
 * Filename: ProjectileLauncherSetFiringPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the firing player of the target Projectile Launcher. If none is set, the component will use the authority player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Projectile Launcher)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("ebff1459-5eb7-456c-a753-f8267d45f79d")]
public class ProjectileLauncherSetFiringPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Projectile Launcher Set Firing Player";
    public string GetVariableQualifiedName() => "projectileLauncherSetFiringPlayer";
}