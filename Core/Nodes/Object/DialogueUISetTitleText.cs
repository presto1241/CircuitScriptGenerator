/*
 * Filename: DialogueUISetTitleText.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the title field of the target Dialogue UI for the local player. Text will truncate after 48 characters.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (DialogueUI)
 * Title Text (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("45566130-ee6e-4eca-8f05-7e264001afc1")]
public class DialogueUISetTitleText : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dialogue UI Set Title Text";
    public string GetVariableQualifiedName() => "dialogueUISetTitleText";
}