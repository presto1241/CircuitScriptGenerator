/*
 * Filename: RangedWeaponPropResetCurrentAmmunition.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Instantly resets the ammunition of a gun back to its configured defaults
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon Prop)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9d6f262c-98bb-46d7-90f4-ad72b7f2a32b")]
public class RangedWeaponPropResetCurrentAmmunition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Reset Current Ammunition";
    public string GetVariableQualifiedName() => "rangedWeaponPropResetCurrentAmmunition";
}