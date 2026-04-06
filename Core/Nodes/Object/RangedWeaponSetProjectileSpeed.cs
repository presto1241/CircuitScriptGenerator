/*
 * Filename: RangedWeaponSetProjectileSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Modifies how fast projectiles fired from this weapon travel. Works with both RRO Ranged Weapon Props (e.g. the Laser Pistol) and the Projectile Launcher.

Unsupported ranged weapon props will output a warning to the Maker Pen console.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ranged Weapon)
 * Speed (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("01cf75ba-b056-4226-b646-84fee1b7c9aa")]
public class RangedWeaponSetProjectileSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Set Projectile Speed";
    public string GetVariableQualifiedName() => "rangedWeaponSetProjectileSpeed";
}