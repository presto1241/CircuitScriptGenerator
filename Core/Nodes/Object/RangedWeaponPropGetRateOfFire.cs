/*
 * Filename: RangedWeaponPropGetRateOfFire.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns both the manual and automatic fire rate for an RRO Ranged Weapon Prop. Also returns whether or not the weapon even supports automatic fire.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon Prop)
 *
 * OUTPUTS: 
 * Manual Fire Rate (float)
 * Has Automatic Fire (bool)
 * Automatic Fire Rate (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("073ab872-a70b-478f-ba4d-df442a1259c0")]
public class RangedWeaponPropGetRateOfFire : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Get Rate Of Fire";
    public string GetVariableQualifiedName() => "rangedWeaponPropGetRateOfFire";
}