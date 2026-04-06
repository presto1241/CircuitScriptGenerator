/*
 * Filename: RangedWeaponPropSetCurrentMagazineAmmunition.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: For RRO Ranged Weapon Props that use magazines (like a Laser Pistol), update the amount of ammo currently available in the weapon's magazine.

If "Ignore Total Ammo" is false the ammunition will be limited to the total ammunition that the weapon has available, and the total ammunition will remain constant. If this field is true, the magazine size will be set to whatever is passed into "Magazine Ammunition" and this may change the weapon's total ammunition available.

Unsupported Ranged Weapon Props will output a warning to the Maker Pen Console.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon Prop)
 * Magazine Ammunition (int)
 * Ignore Total Ammunition (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("447066e0-1dc5-4914-afab-3d42f6203a7a")]
public class RangedWeaponPropSetCurrentMagazineAmmunition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Set Current Magazine Ammunition";
    public string GetVariableQualifiedName() => "rangedWeaponPropSetCurrentMagazineAmmunition";
}