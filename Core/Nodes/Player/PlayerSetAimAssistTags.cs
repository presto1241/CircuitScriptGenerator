/*
 * Filename: PlayerSetAimAssistTags.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the list of player tags that the provided player can target with aim assist.
By default, this list contains the #player tag.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Tags (List<string>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("19883a68-58b5-480e-a5cd-97a526e08fdd")]
public class PlayerSetAimAssistTags : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Aim Assist Tags";
    public string GetVariableQualifiedName() => "playerSetAimAssistTags";
}