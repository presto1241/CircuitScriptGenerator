/*
 * Filename: RangedWeaponGetProjectileGravityEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Toggles whether or not projectiles fired from an RRO Ranged Weapon Prop (like a Laser Pistol) or a Projectile Launcher are affected by gravity.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon)
 *
 * OUTPUTS: 
 * Gravity Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f027202c-6699-4e49-a4c5-5a70abe6cf22")]
public class RangedWeaponGetProjectileGravityEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Get Projectile Gravity Enabled";
    public string GetVariableQualifiedName() => "rangedWeaponGetProjectileGravityEnabled";
}