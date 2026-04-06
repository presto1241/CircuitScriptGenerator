/*
 * Filename: RangedWeaponPropGetRecoilIntensityMultiplier.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the custom multiplier that modifies the built-in recoil on an RRO Ranged Weapon Prop. This modifier is applied to strengthen or weaken the recoil that ranged weapons already have.
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

[Node("a5425f4c-ab87-4f02-ba82-bb407ac45cb3")]
public class RangedWeaponPropGetRecoilIntensityMultiplier : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Get Recoil Intensity Multiplier";
    public string GetVariableQualifiedName() => "rangedWeaponPropGetRecoilIntensityMultiplier";
}