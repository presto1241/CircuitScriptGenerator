/*
 * Filename: GetPlayerByAccountName.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets a Player based on an Account Name. (E.g. my account name is @Coach and if I input the string "Coach", the output would be my Player object.) Outputs an invalid Player if nobody in the room has the given account name.
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

[Node("2ee5a268-9d44-4326-8a34-ad126a3218f2")]
public class GetPlayerByAccountName : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player By Account Name";
    public string GetVariableQualifiedName() => "getPlayerByAccountName";
}