/*
 * Filename: DialogueUIGetTitleIsEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not the target Dialogue UI’s title bar is visible for the local player.
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

[Node("44661525-612e-4032-8278-fcb15a72aee0")]
public class DialogueUIGetTitleIsEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dialogue UI Get Title Is Enabled";
    public string GetVariableQualifiedName() => "dialogueUIGetTitleIsEnabled";
}