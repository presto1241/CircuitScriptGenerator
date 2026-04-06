/*
 * Filename: PlayerSetRadioChannel.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Assign a player to a radio channel. The channel needs to be a non-negative integer value. Players within the same channel will be able to communicate in team radio.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Channel (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("231d05ba-8577-4d1e-888d-115e657dd525")]
public class PlayerSetRadioChannel : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Radio Channel";
    public string GetVariableQualifiedName() => "playerSetRadioChannel";
}