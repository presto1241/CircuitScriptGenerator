/*
 * Filename: EquipObjecttoDominantHand.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Equip the target object to the specified player's "main hand," as defined by the player's settings
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Object To Equip (Rec Room Object)
 * Force Equip (bool)
 * Steal (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("c840f770-80aa-4e96-8677-963a2ca3cff1")]
public class EquipObjecttoDominantHand : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Equip Object to Dominant Hand";
    public string GetVariableQualifiedName() => "equipObjecttoDominantHand";
}