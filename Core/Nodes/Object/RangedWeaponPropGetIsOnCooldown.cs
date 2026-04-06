/*
 * Filename: RangedWeaponPropGetIsOnCooldown.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not the RRO Ranged Weapon Prop (like a Laser Pistol) is currently on cooldown from firing a shot. When a weapon is on cooldown, it cannot fire again until its cooldown has finished.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon Prop)
 *
 * OUTPUTS: 
 * Is On Cooldown (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d9bdbdd5-df4a-4bd6-a697-a89e74a7a215")]
public class RangedWeaponPropGetIsOnCooldown : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Prop Get Is On Cooldown";
    public string GetVariableQualifiedName() => "rangedWeaponPropGetIsOnCooldown";
}