/*
 * Filename: RangedWeaponGetRecRoomObjectDamage.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the damage value that projectiles from the target launcher will do when hitting Rec Room Objects.
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

[Node("630823d4-c27f-493e-81a3-ae482448403d")]
public class RangedWeaponGetRecRoomObjectDamage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ranged Weapon Get Rec Room Object Damage";
    public string GetVariableQualifiedName() => "rangedWeaponGetRecRoomObjectDamage";
}