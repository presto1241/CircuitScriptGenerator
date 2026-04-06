/*
 * Filename: RangedWeaponPropSetProjectileSpreadMultiplier.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets a multiplier to modify the bullet spread for this Ranged Weapon Prop, letting you make guns more or less accurate. If a gun is already perfectly accurate, this does nothing.

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

[Node("333f9804-55c1-4134-930d-e5f114bc325e")]
public class RangedWeaponPropSetProjectileSpreadMultiplier : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Set Projectile Spread Multiplier";
    public string GetVariableQualifiedName() => "rangedWeaponPropSetProjectileSpreadMultiplier";
}