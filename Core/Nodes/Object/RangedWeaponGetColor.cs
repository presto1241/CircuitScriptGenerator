/*
 * Filename: RangedWeaponGetColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get the color of the target Ranged Weapon. In the case of a Projectile Launcher inside a custom object, this will return the color of the projectiles.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ranged Weapon)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("7ef41c60-14b9-44fc-b3bf-bc1b22cc55a7")]
public class RangedWeaponGetColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Get Color";
    public string GetVariableQualifiedName() => "rangedWeaponGetColor";
}