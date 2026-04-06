/*
 * Filename: RangedWeaponPropSetInfiniteAmmunition.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Modifies whether or not an RRO Ranged Weapon Prop (like a Laser Pistol) has infinite ammo.

Unsupported Ranged Weapon Props will output a warning to the Maker Pen Console.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon Prop)
 * Infinite Ammo (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d435aa32-ebed-49a4-a74b-ad8509ad4d7f")]
public class RangedWeaponPropSetInfiniteAmmunition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Set Infinite Ammunition";
    public string GetVariableQualifiedName() => "rangedWeaponPropSetInfiniteAmmunition";
}