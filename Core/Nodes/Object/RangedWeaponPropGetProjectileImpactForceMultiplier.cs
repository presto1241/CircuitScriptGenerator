/*
 * Filename: RangedWeaponPropGetProjectileImpactForceMultiplier.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the custom multiplier that modifies the built-in impact force when a projectile from this RRO Ranged Weapon Prop hits an object. This modifier is applied to strengthen or weaken the force that a projectile imparts on an object on hit.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon Prop)
 *
 * OUTPUTS: 
 * Multiplier (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("7526c892-e34d-4be1-8af6-cdbf5fc31f9e")]
public class RangedWeaponPropGetProjectileImpactForceMultiplier : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Get Projectile Impact Force Multiplier";
    public string GetVariableQualifiedName() => "rangedWeaponPropGetProjectileImpactForceMultiplier";
}