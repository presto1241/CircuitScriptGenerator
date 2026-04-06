/*
 * Filename: ProjectileConstant.cs
 * Category: Rec Room Studio
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Constant that can be configured to custom projectiles made in Rec Room Studio. Used with Projectile Fire chip
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Projectile)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.RecRoomStudio;

[Node("bf0ae6b7-5cf3-4d4e-b47c-3d0771b2359c")]
public class ProjectileConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Projectile Constant";
    public string GetVariableQualifiedName() => "projectileConstant";
}