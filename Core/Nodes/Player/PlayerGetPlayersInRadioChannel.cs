/*
 * Filename: PlayerGetPlayersInRadioChannel.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a list of players that are set to the given radio channel.
 * Types: 
 * 
 * INPUTS: 
 * Channel (int)
 *
 * OUTPUTS: 
 * Players (List<Player>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("502c4b6c-47b6-4370-a1e0-9cab18b1af35")]
public class PlayerGetPlayersInRadioChannel : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Players In Radio Channel";
    public string GetVariableQualifiedName() => "playerGetPlayersInRadioChannel";
}