/*
 * Filename: ShowNotification.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Prints the input notification to the given player's screen.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Value (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("61bc2310-69f5-4dfa-b43c-12ae98dd05ab")]
public class ShowNotification : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Show Notification";
    public string GetVariableQualifiedName() => "showNotification";
}