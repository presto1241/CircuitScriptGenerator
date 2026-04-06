/*
 * Filename: DialogueUISetTitleIsEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Toggles visibility of the target Dialogue UI’s title bar for the local player. Visibility is dependent on the Dialogue UI being enabled.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (DialogueUI)
 * Is Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("54a8ee30-21fa-4f74-8f54-5c8936a2e7bb")]
public class DialogueUISetTitleIsEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dialogue UI Set Title Is Enabled";
    public string GetVariableQualifiedName() => "dialogueUISetTitleIsEnabled";
}