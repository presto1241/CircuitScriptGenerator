/*
 * Filename: RangedWeaponSetRecRoomObjectDamage.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the damage value that projectiles from the target launcher will do when hitting Rec Room Objects.
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

[Node("1fcd6f83-b403-426d-8ded-7064e8790b2d")]
public class RangedWeaponSetRecRoomObjectDamage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Set Rec Room Object Damage";
    public string GetVariableQualifiedName() => "rangedWeaponSetRecRoomObjectDamage";
}