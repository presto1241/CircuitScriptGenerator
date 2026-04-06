/*
 * Filename: GameAISetUse3DAudio.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Enables or disables 3D spatial audio for the AI’s voice. When disabled, the voice is heard at equal volume, regardless of position.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Value (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("175ea0e8-78dc-4e4f-b9bc-f406c64f9ff4")]
public class GameAISetUse3DAudio : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Set Use 3D Audio";
    public string GetVariableQualifiedName() => "gameAISetUse3DAudio";
}