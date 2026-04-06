/*
 * Filename: RangedWeaponSetHeadDamage.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Modifies how much damage this weapon does when its projectiles hit a player's head. Works with both RRO Ranged Weapon Props (e.g. the Laser Pistol) and the Projectile Launcher.

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

[Node("f9eeb1b4-5721-4d30-82d4-3bfdea0b8617")]
public class RangedWeaponSetHeadDamage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Set Head Damage";
    public string GetVariableQualifiedName() => "rangedWeaponSetHeadDamage";
}