/*
 * Filename: PlayerGetAvatarVisible.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether a given player's avatar is visible
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Avatar Visible (bool)
 * Has Local Override (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("c352042a-9600-481d-97e8-02e46de06e46")]
public class PlayerGetAvatarVisible : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Avatar Visible";
    public string GetVariableQualifiedName() => "playerGetAvatarVisible";
}