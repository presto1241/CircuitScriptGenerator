/*
 * Filename: PlayerGetAimAssistTags.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the list of player tags that the provided player can target with aim assist.
By default, this list contains the #player tag.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Tags (List<string>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("5d6461e3-c6e0-40eb-8032-8595b6d9b0dc")]
public class PlayerGetAimAssistTags : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Aim Assist Tags";
    public string GetVariableQualifiedName() => "playerGetAimAssistTags";
}