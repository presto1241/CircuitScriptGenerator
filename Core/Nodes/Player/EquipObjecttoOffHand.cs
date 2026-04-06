/*
 * Filename: EquipObjecttoOffHand.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Equip the target object to the specified player's "off hand," as defined by the player's settings
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

[Node("52da50b9-2d34-4128-a1bd-3e056f236e2c")]
public class EquipObjecttoOffHand : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Equip Object to Off Hand";
    public string GetVariableQualifiedName() => "equipObjecttoOffHand";
}