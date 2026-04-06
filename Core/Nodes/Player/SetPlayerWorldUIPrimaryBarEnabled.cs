/*
 * Filename: SetPlayerWorldUIPrimaryBarEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the enabled state of the primary bar in the given player's active world UI.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("03c280c2-5f80-4ba9-8966-6c5d11da84a9")]
public class SetPlayerWorldUIPrimaryBarEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Player World UI Primary Bar Enabled";
    public string GetVariableQualifiedName() => "setPlayerWorldUIPrimaryBarEnabled";
}