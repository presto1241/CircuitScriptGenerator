/*
 * Filename: GetPlayerWorldUIPrimaryBarColor.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the color of the given player's primary bar in their current world UI.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("72101b8c-e522-43ad-ad96-7332f7962c10")]
public class GetPlayerWorldUIPrimaryBarColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player World UI Primary Bar Color";
    public string GetVariableQualifiedName() => "getPlayerWorldUIPrimaryBarColor";
}