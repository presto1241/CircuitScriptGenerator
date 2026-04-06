/*
 * Filename: DialogueUIGetIsEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not the target Dialogue UI is enabled for the local player.
 * Types: 
 * 
 * INPUTS: 
 * Target (DialogueUI)
 *
 * OUTPUTS: 
 * Is Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("24e650ed-b099-44ba-944a-d33ea34fff8b")]
public class DialogueUIGetIsEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dialogue UI Get Is Enabled";
    public string GetVariableQualifiedName() => "dialogueUIGetIsEnabled";
}