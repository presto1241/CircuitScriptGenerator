/*
 * Filename: RangedWeaponSetProjectileColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Modifies the color of projectiles coming from an RRO Ranged Weapon Prop (e.g. the Laser Pistol) or a Projectile Launcher.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon)
 * Color (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("3a253a6e-fc0f-4ae2-b669-0418c09fc553")]
public class RangedWeaponSetProjectileColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Set Projectile Color";
    public string GetVariableQualifiedName() => "rangedWeaponSetProjectileColor";
}