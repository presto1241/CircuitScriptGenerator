/*
 * Filename: GetPlayerWorldUIPrimaryBarEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the enabled state of the given player's primary bar in their current world UI.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("125d57be-9afa-46b3-a1c4-0c967d044334")]
public class GetPlayerWorldUIPrimaryBarEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player World UI Primary Bar Enabled";
    public string GetVariableQualifiedName() => "getPlayerWorldUIPrimaryBarEnabled";
}