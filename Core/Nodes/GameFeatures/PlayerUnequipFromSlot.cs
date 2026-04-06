/*
 * Filename: PlayerUnequipFromSlot.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: For the specified player, unequip anything which is equipped to the specified slot. If the slot is of Inventory type, this chip will take effect whether or not the slot is enabled.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Player (Player)
 * Equipment Slot (Equipment Slot)
 *
 * OUTPUTS: 
 * Run (exec)
 * On Unequip Complete (exec)
 * Was Unequipped (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("a672e48b-931e-48d3-ba8c-34b3f415919c")]
public class PlayerUnequipFromSlot : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Unequip From Slot";
    public string GetVariableQualifiedName() => "playerUnequipFromSlot";
}