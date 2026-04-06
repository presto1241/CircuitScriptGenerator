/*
 * Filename: GameAIRemoveConversationItem.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Deletes a specific memory item from the AI's internal conversation state. This action prevents the AI from recalling or referencing the removed information in future interactions.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Conversation Item Id (string)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Removed (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("9d59abab-5f87-48ed-a9ab-cddef8c1b23d")]
public class GameAIRemoveConversationItem : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Remove Conversation Item";
    public string GetVariableQualifiedName() => "gameAIRemoveConversationItem";
}