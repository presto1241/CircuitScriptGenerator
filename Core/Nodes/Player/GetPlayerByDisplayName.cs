/*
 * Filename: GetPlayerByDisplayName.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets a Player based on a display name. (E.g. my display name is Coach and if I input a string "Coach", the output would be my Player object.) Outputs an invalid Player if nobody in the room has the given display name.
 * Types: 
 * 
 * INPUTS: 
 * Name (string)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("637e07e4-9b93-44b6-bba3-68966080d064")]
public class GetPlayerByDisplayName : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player By Display Name";
    public string GetVariableQualifiedName() => "getPlayerByDisplayName";
}