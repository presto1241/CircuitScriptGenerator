/*
 * Filename: RangedWeaponGetLimbDamage.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the amount of damage this weapon does when its projectiles hit a player's limb or hand. Works with both RRO Ranged Weapon Props (e.g. the Laser Pistol) and the Projectile Launcher.
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

[Node("ed1f109d-bc85-4e4b-8f15-d33363aed7dd")]
public class RangedWeaponGetLimbDamage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Get Limb Damage";
    public string GetVariableQualifiedName() => "rangedWeaponGetLimbDamage";
}