/*
 * Filename: RangedWeaponSetProjectileGravityEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Modifies whether or not projectiles fired from an RRO Ranged Weapon Prop (like a Laser Pistol) or a Projectile Launcher are affected by gravity.

Unsupported Ranged Weapon Props will output a warning to the Maker Pen Console.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon)
 * Gravity Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("56eb6021-078a-46f4-b2bb-3abb7b853211")]
public class RangedWeaponSetProjectileGravityEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Set Projectile Gravity Enabled";
    public string GetVariableQualifiedName() => "rangedWeaponSetProjectileGravityEnabled";
}