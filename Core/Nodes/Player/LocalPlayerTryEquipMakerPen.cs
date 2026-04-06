/*
 * Filename: LocalPlayerTryEquipMakerPen.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Attempts to equip the Maker Pen to the local player's dominant hand. 'Success' will be false if the player does not have permission to use the Maker Pen in this room.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("5473719d-8cd1-41d1-b194-4c8dbfc45016")]
public class LocalPlayerTryEquipMakerPen : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Try Equip Maker Pen";
    public string GetVariableQualifiedName() => "localPlayerTryEquipMakerPen";
}