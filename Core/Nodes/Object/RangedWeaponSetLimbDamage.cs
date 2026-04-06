/*
 * Filename: RangedWeaponSetLimbDamage.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Modifies how much damage this weapon does when its projectiles hit a player's limb or hand. Works with both RRO Ranged Weapon Props (e.g. the Laser Pistol) and the Projectile Launcher.

Unsupported ranged weapon props will output a warning to the Maker Pen Console.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon)
 * Damage (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("3dd1fa27-a800-4d05-8b47-16ad48311135")]
public class RangedWeaponSetLimbDamage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Set Limb Damage";
    public string GetVariableQualifiedName() => "rangedWeaponSetLimbDamage";
}