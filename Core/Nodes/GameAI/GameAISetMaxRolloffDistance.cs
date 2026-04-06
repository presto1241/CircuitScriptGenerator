/*
 * Filename: GameAISetMaxRolloffDistance.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the maximum roll-off distance for the AI’s voice output. This is the farthest distance at which the voice remains audible.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Value (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("f4571a14-cf09-4f41-b141-56d0c9fa16e5")]
public class GameAISetMaxRolloffDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Set Max Rolloff Distance";
    public string GetVariableQualifiedName() => "gameAISetMaxRolloffDistance";
}