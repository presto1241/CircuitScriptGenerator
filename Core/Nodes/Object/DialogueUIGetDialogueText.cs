/*
 * Filename: DialogueUIGetDialogueText.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the current text of the target Dialogue UI’s main body for the local player, and whether or not it’s currently interactive.
 * Types: 
 * 
 * INPUTS: 
 * Target (DialogueUI)
 *
 * OUTPUTS: 
 * Body Text (string)
 * Is Interactive (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("ecd48cf6-f25a-4650-a120-4bbf05fbfa1c")]
public class DialogueUIGetDialogueText : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dialogue UI Get Dialogue Text";
    public string GetVariableQualifiedName() => "dialogueUIGetDialogueText";
}