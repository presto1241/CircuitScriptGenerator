/*
 * Filename: DisplayPlayerWorldUI.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Displays a target UI configuration above a given player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Player World UI)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("dfbf7060-c08a-4f20-818c-02afe1c36b38")]
public class DisplayPlayerWorldUI : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Display Player World UI";
    public string GetVariableQualifiedName() => "displayPlayerWorldUI";
}