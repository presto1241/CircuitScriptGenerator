/*
 * Filename: GameAISetIsDopplerEnabled.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Enables or disables the Doppler effect for the AI’s voice.

This feature only applies when 3D audio is active.
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

[Node("fe0c3ec4-7320-4857-915a-be17ba700f8b")]
public class GameAISetIsDopplerEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Set Is Doppler Enabled";
    public string GetVariableQualifiedName() => "gameAISetIsDopplerEnabled";
}