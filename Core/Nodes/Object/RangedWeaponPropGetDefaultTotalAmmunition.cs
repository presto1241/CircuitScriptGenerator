/*
 * Filename: RangedWeaponPropGetDefaultTotalAmmunition.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the total ammunition configured on this weapon, unaffected by the current state of the gun.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon Prop)
 *
 * OUTPUTS: 
 * Default Infinite Ammunition (bool)
 * Default Total Ammunition (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("13bf448e-5d3f-489f-8628-b4d88a523afe")]
public class RangedWeaponPropGetDefaultTotalAmmunition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Get Default Total Ammunition";
    public string GetVariableQualifiedName() => "rangedWeaponPropGetDefaultTotalAmmunition";
}