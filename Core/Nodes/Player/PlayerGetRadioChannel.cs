/*
 * Filename: PlayerGetRadioChannel.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get the radio channel number of a player. If a player is not in any, this node returns -1
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Channel (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("be2f38d2-c6cb-4d9a-b74d-0a664c216a7b")]
public class PlayerGetRadioChannel : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Radio Channel";
    public string GetVariableQualifiedName() => "playerGetRadioChannel";
}