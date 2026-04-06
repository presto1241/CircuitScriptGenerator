/*
 * Filename: RangedWeaponPropSetMagazineCapacity.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the amount of ammunition that can fit into the magazine after reloading.  Only works for some weapons.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon Prop)
 * Magazine Capacity (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("8fc830dc-0dd5-480f-92d0-b83d1e252a32")]
public class RangedWeaponPropSetMagazineCapacity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Set Magazine Capacity";
    public string GetVariableQualifiedName() => "rangedWeaponPropSetMagazineCapacity";
}