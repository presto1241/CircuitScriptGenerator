/*
 * Filename: UnequipfromSlots.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Dominant-Hand (bool)
 * Off-Hand (bool)
 * Left Hip Holster (bool)
 * Right Hip Holster (bool)
 * Shoulder Holster (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Objects Unequipped (List<Rec Room Object>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("13a06844-ab37-41d6-9358-0383cf3c35d7")]
public class UnequipfromSlots : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Unequip from Slots";
    public string GetVariableQualifiedName() => "unequipfromSlots";
}