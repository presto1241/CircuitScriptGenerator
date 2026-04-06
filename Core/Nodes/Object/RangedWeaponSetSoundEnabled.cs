/*
 * Filename: RangedWeaponSetSoundEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Toggles whether or not an RRO Ranged Weapon Prop (like a Laser Pistol) or a Projectile Launcher emits any built-in sounds.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon)
 * Sound Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f1c586e6-f823-4bec-9d03-4d8ac447f490")]
public class RangedWeaponSetSoundEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Set Sound Enabled";
    public string GetVariableQualifiedName() => "rangedWeaponSetSoundEnabled";
}