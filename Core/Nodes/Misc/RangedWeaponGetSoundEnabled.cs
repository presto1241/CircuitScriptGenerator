/*
 * Filename: RangedWeaponGetSoundEnabled.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not an RRO Ranged Weapon Prop (like a Laser Pistol) or a Projectile Launcher emits any built-in sounds.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon)
 *
 * OUTPUTS: 
 * Sound Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("33e5e79a-6183-439b-9887-dead69c2a8d9")]
public class RangedWeaponGetSoundEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Get Sound Enabled";
    public string GetVariableQualifiedName() => "rangedWeaponGetSoundEnabled";
}