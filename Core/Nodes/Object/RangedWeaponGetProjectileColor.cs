/*
 * Filename: RangedWeaponGetProjectileColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the color of projectiles coming from an RRO Ranged Weapon Prop (e.g. the Laser Pistol) or a Projectile Launcher.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("29005ae6-2611-4ed3-9bed-e256749b487a")]
public class RangedWeaponGetProjectileColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Get Projectile Color";
    public string GetVariableQualifiedName() => "rangedWeaponGetProjectileColor";
}