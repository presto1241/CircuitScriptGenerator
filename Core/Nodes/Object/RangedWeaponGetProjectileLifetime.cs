/*
 * Filename: RangedWeaponGetProjectileLifetime.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns how long in seconds projectiles from this weapon will stick around before vanishing if they haven't hit anything. For sticky projectiles like the ones fired from a Bow or Crossbow, this includes the time after they've hit a surface as well. Works with both RRO Ranged Weapon Props (e.g. the Laser Pistol) and the Projectile Launcher.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon)
 *
 * OUTPUTS: 
 * Lifetime (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("7af08c60-bd52-4733-9a9a-c22317f28738")]
public class RangedWeaponGetProjectileLifetime : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Get Projectile Lifetime";
    public string GetVariableQualifiedName() => "rangedWeaponGetProjectileLifetime";
}