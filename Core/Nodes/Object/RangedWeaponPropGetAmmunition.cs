/*
 * Filename: RangedWeaponPropGetAmmunition.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets info about the current total ammunition and current magazine ammunition on a ranged weapon.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon Prop)
 *
 * OUTPUTS: 
 * Has Infinite Ammo (bool)
 * Current Total Ammo (int)
 * Uses Magazine (bool)
 * Current Magazine Size (int)
 * Magazine Capacity (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("3219c103-22dd-4d33-8188-14db79500ddc")]
public class RangedWeaponPropGetAmmunition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Get Ammunition";
    public string GetVariableQualifiedName() => "rangedWeaponPropGetAmmunition";
}