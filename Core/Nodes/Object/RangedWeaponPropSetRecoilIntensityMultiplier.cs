/*
 * Filename: RangedWeaponPropSetRecoilIntensityMultiplier.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets a multiplier to modify the built-in recoil from this Ranged Weapon Prop.

Some ranged weapons do not support this and will log a maker pen warning when passed into this chip.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon Prop)
 * Multiplier (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f4ac80d5-5ec1-4b0a-9749-284671dd4b6f")]
public class RangedWeaponPropSetRecoilIntensityMultiplier : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Set Recoil Intensity Multiplier";
    public string GetVariableQualifiedName() => "rangedWeaponPropSetRecoilIntensityMultiplier";
}