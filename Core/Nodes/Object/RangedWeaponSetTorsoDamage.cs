/*
 * Filename: RangedWeaponSetTorsoDamage.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Modifies how much damage this weapon does when its projectiles hit a player's torso. Works with both RRO Ranged Weapon Props (e.g. the Laser Pistol) and the Projectile Launcher.

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

[Node("531dc709-286e-429c-9d51-537a63d74f76")]
public class RangedWeaponSetTorsoDamage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Set Torso Damage";
    public string GetVariableQualifiedName() => "rangedWeaponSetTorsoDamage";
}