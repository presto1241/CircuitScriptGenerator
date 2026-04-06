/*
 * Filename: GameAIGetMaxRolloffDistance.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the maximum distance at which the AI’s voice can be heard.
 * Types: 
 * 
 * INPUTS: 
 * Target (Game AI)
 *
 * OUTPUTS: 
 * Value (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("6513964a-4225-44fd-9677-0275f7f1122c")]
public class GameAIGetMaxRolloffDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Get Max Rolloff Distance";
    public string GetVariableQualifiedName() => "gameAIGetMaxRolloffDistance";
}