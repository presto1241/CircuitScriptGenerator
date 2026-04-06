/*
 * Filename: RootPlayer.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a reference to the player who owns the Player Logic Board in which this chip is nested. Only useful in the Player Definition Board, and will present as invalid in most test scenarios.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("2d92f1a6-f219-4163-99d9-42e71dbc5adf")]
public class RootPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Root Player";
    public string GetVariableQualifiedName() => "rootPlayer";
}