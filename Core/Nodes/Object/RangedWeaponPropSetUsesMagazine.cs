/*
 * Filename: RangedWeaponPropSetUsesMagazine.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether or not a weapon uses a magazine that needs to be manually reloaded. Only works for some weapons.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon Prop)
 * Uses Magazine (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("ec418dd3-21d5-4789-85c2-07d7cb01f45b")]
public class RangedWeaponPropSetUsesMagazine : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Set Uses Magazine";
    public string GetVariableQualifiedName() => "rangedWeaponPropSetUsesMagazine";
}