/*
 * Filename: RemovePlayerFromRadioChannel.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Remove a player from the radio channel they are in
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("eb605a54-315e-495e-b051-8d113c32ed7c")]
public class RemovePlayerFromRadioChannel : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Remove Player From Radio Channel";
    public string GetVariableQualifiedName() => "removePlayerFromRadioChannel";
}