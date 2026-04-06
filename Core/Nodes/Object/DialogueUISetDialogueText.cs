/*
 * Filename: DialogueUISetDialogueText.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the text of the target Dialogue UI’s main body for the local player. Text will truncate after 256 characters. If “Is interactive” is true, an arrow will appear in the lower right when the text has fully animated in, and the whole panel will be clickable for the player. The Next Pressed event will fire in the Dialogue UI’s board scope when this interactive panel is clicked.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (DialogueUI)
 * Body Text (string)
 * Is Interactive (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("bc6602e4-e88b-4db4-9655-0a6baf50997e")]
public class DialogueUISetDialogueText : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dialogue UI Set Dialogue Text";
    public string GetVariableQualifiedName() => "dialogueUISetDialogueText";
}