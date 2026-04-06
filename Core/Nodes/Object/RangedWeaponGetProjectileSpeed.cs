/*
 * Filename: RangedWeaponGetProjectileSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns how fast projectiles fired from this weapon travel. Works with both RRO Ranged Weapon Props (e.g. the Laser Pistol) and the Projectile Launcher.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon)
 *
 * OUTPUTS: 
 * Speed (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("1803843e-4e3b-4422-ada9-5f8959337ee5")]
public class RangedWeaponGetProjectileSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Get Projectile Speed";
    public string GetVariableQualifiedName() => "rangedWeaponGetProjectileSpeed";
}