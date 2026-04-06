/*
 * Filename: GameAIGetUse3DAudio.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Enables or disables 3D spatial audio for the AI’s voice. When disabled, the voice is heard at equal volume, regardless of position.
 * Types: 
 * 
 * INPUTS: 
 * Target (Game AI)
 *
 * OUTPUTS: 
 * Value (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("c20680a5-143d-40c2-ace1-ec4a577e1f6a")]
public class GameAIGetUse3DAudio : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Get Use 3D Audio";
    public string GetVariableQualifiedName() => "gameAIGetUse3DAudio";
}