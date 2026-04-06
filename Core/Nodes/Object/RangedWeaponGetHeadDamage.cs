/*
 * Filename: RangedWeaponGetHeadDamage.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the amount of damage this weapon does when its projectiles hit a player's head. Works with both RRO Ranged Weapon Props (e.g. the Laser Pistol) and the Projectile Launcher.
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

[Node("7aa59933-c380-428e-aca9-2de2875cb38d")]
public class RangedWeaponGetHeadDamage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Get Head Damage";
    public string GetVariableQualifiedName() => "rangedWeaponGetHeadDamage";
}