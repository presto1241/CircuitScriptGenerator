/*
 * Filename: PlayerGetFirstwithTag.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the first player with the input tag.
 * Types: 
 * 
 * INPUTS: 
 * Tag (string)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("48364320-cb02-41d8-9d8f-50291131dad2")]
public class PlayerGetFirstwithTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get First with Tag";
    public string GetVariableQualifiedName() => "playerGetFirstwithTag";
}