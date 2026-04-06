/*
 * Filename: DialogueUIGetTitleText.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the current title of the target Dialogue UI for the local player.
 * Types: 
 * 
 * INPUTS: 
 * Target (DialogueUI)
 *
 * OUTPUTS: 
 * Title Text (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("17a13c0d-f5c0-4806-b6ee-1af03eb81bdb")]
public class DialogueUIGetTitleText : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dialogue UI Get Title Text";
    public string GetVariableQualifiedName() => "dialogueUIGetTitleText";
}