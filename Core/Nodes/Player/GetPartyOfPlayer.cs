/*
 * Filename: GetPartyOfPlayer.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the party of the input player as List<Player>. If the player is not in a party, it will return a list containing only that player.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Party (List<Player>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("dcbd4d6a-8f42-48ef-ad66-e1f245228d84")]
public class GetPartyOfPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Party Of Player";
    public string GetVariableQualifiedName() => "getPartyOfPlayer";
}