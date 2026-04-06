/*
 * Filename: RangedWeaponPropSetFireRate.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets both the manual and automatic fire rate for this Ranged Weapon Prop. If the weapon does not support continuous fire, the automatic fire rate will not be used.

Some ranged weapons do not support this and will log a maker pen warning when passed into this chip.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon Prop)
 * Manual Fire Rate (float)
 * Automatic Fire Rate (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("69963f8f-1d41-422e-bb79-83cf0b5e682d")]
public class RangedWeaponPropSetFireRate : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Set Fire Rate";
    public string GetVariableQualifiedName() => "rangedWeaponPropSetFireRate";
}