/*
 * Filename: RangedWeaponPropSetTotalAmmunition.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Modifies the total ammo of an RRO Ranged Weapon Prop (like a Laser Pistol). For weapons that have magazines, this accounts for both the magazine ammo and the backup ammo when they reload their magazine.

"New Ammo Refills Magazine" directly affects the current magazine for weapons that use one. Otherwise, new ammo will go to backup ammo where players have to reload in order to access it.

Unsupported Ranged Weapon Props will output a warning to the Maker Pen Console.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon Prop)
 * Total Ammunition (int)
 * New Ammo Refills Magazine (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("3f153cb2-b984-4ecb-9c3f-a4d1620f6c16")]
public class RangedWeaponPropSetTotalAmmunition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Set Total Ammunition";
    public string GetVariableQualifiedName() => "rangedWeaponPropSetTotalAmmunition";
}