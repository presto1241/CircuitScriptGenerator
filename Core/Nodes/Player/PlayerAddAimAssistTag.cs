/*
 * Filename: PlayerAddAimAssistTag.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Adds a tag to the list of player tags that the provided player can target with aim assist.
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

[Node("3ac91358-d131-4e01-95e0-a24d309886c1")]
public class PlayerAddAimAssistTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Add Aim Assist Tag";
    public string GetVariableQualifiedName() => "playerAddAimAssistTag";
}