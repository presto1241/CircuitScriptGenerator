/*
 * Filename: RangedWeaponPropSetProjectileImpactForceMultiplier.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets a multiplier to modify the built-in impact force when a bullet from this Ranged Weapon Prop hits an object.

Some ranged weapons do not support this and will log a maker pen warning when passed into this chip.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon Prop)
 * Multiplier (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("051c20f8-b1c9-4ee9-9a4f-0bab4b9f8b77")]
public class RangedWeaponPropSetProjectileImpactForceMultiplier : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Set Projectile Impact Force Multiplier";
    public string GetVariableQualifiedName() => "rangedWeaponPropSetProjectileImpactForceMultiplier";
}