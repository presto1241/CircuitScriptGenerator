/*
 * Filename: PlayerGetXP.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns current XP of specified player. Will not function correctly unless Room Progression is enabled in Room Settings.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * XP (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("88a12c40-5a38-4304-be23-36f769c2a4b8")]
public class PlayerGetXP : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get XP";
    public string GetVariableQualifiedName() => "playerGetXP";
}