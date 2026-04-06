/*
 * Filename: PlayerRemoveAimAssistTag.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Removes a tag from the list of player tags that the provided player can target with aim assist.
By default, this list contains the #player tag.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Tag (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("03d08e3c-b639-43ca-9443-dee4b160ad0e")]
public class PlayerRemoveAimAssistTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Remove Aim Assist Tag";
    public string GetVariableQualifiedName() => "playerRemoveAimAssistTag";
}