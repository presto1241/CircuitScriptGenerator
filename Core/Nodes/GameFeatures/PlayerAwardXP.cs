/*
 * Filename: PlayerAwardXP.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Award XP to specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Player (Player)
 * Amount (int)
 *
 * OUTPUTS: 
 * Run (exec)
 * On Award Complete (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("beb93f31-9a12-4b47-a9cc-961febb623aa")]
public class PlayerAwardXP : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Award XP";
    public string GetVariableQualifiedName() => "playerAwardXP";
}