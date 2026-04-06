/*
 * Filename: RangedWeaponPropGetProjectileSpreadMultiplier.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the custom multiplier that modifies the built-in projectile spread on an RRO Ranged Weapon Prop. This modifier is applied to strengthen or weaken both the accuracy and bullet spread that ranged weapons already have.
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

[Node("23aa10fe-834e-4cb6-a975-67d25a00a16f")]
public class RangedWeaponPropGetProjectileSpreadMultiplier : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Get Projectile Spread Multiplier";
    public string GetVariableQualifiedName() => "rangedWeaponPropGetProjectileSpreadMultiplier";
}