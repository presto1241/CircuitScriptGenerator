/*
 * Filename: RangedWeaponSetProjectileLifetime.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Modifies how long in seconds projectiles from this weapon will stick around before vanishing if they haven't hit anything. For sticky projectiles like the ones fired from a Bow or Crossbow, this includes the time after they've hit a surface as well. Works with both RRO Ranged Weapon Props (e.g. the Laser Pistol) and the Projectile Launcher.

Unsupported Ranged Weapon Props will output a warning to the Maker Pen Console.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon)
 * Lifetime (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b91d3e3d-7c6b-4fba-9505-66c8afd0245d")]
public class RangedWeaponSetProjectileLifetime : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Set Projectile Lifetime";
    public string GetVariableQualifiedName() => "rangedWeaponSetProjectileLifetime";
}