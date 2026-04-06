/*
 * Filename: RangedWeaponPropGetIsReloading.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not the RRO Ranged Weapon Prop (like a Laser Pistol) is currently reloading.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon Prop)
 *
 * OUTPUTS: 
 * Is Reloading (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a3c0855e-90e3-4daf-94c5-72dc1e8d25e4")]
public class RangedWeaponPropGetIsReloading : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Get Is Reloading";
    public string GetVariableQualifiedName() => "rangedWeaponPropGetIsReloading";
}