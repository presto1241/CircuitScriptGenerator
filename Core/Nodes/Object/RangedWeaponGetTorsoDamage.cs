/*
 * Filename: RangedWeaponGetTorsoDamage.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the amount of damage this weapon does when its projectiles hit a player's torso. Works with both RRO Ranged Weapon Props (e.g. the Laser Pistol) and the Projectile Launcher.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon)
 *
 * OUTPUTS: 
 * Damage (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("0da5a0be-9c01-4fcc-83a4-a660971c8644")]
public class RangedWeaponGetTorsoDamage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Get Torso Damage";
    public string GetVariableQualifiedName() => "rangedWeaponGetTorsoDamage";
}